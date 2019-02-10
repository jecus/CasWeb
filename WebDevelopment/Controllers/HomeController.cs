using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLayer.Mapping;
using BusinessLayer.Repositiry;
using BusinessLayer.Repositiry.Interfaces;
using BusinessLayer.Views;
using Entity.Extentions;
using Entity.Infrastructure;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDevelopment.Helper;
using WebDevelopment.Models;

namespace WebDevelopment.Controllers
{
	public class HomeController : Controller
	{
		private readonly IAircraftRepository _aircraftRepository;
		private readonly DatabaseContext _db;
        private readonly IMapper _mapper;

        public HomeController(IAircraftRepository aircraftRepository, DatabaseContext db, IMapper mapper)
        {
	        _aircraftRepository = aircraftRepository;
	        _db = db;
            _mapper = mapper;
        }


		public async Task<IActionResult> Index()
		{
			var airctafts = await _aircraftRepository.GetAll();

			var res = airctafts
				.OrderBy(i => i.RegistrationNumber)
                .ToList();

            var stores = await _db.Stores
                .OnlyActive()
                .ToListAsync();
            var str = _mapper.MapToBlView<Store, StoreView>(stores)
                .OrderBy(i => i.StoreName)
                .ToList();

            var documents = await _db.Documents.OnlyActive()
                .OrderByDescending(x => x.ItemId)
                .Take(5)
                .ToListAsync();
            var doc = _mapper.MapToBlView<Document, DocumentView>(documents).ToList();
            var doccount = await _db.Documents.CountAsync();

            var op = await _db.Operators.AsNoTracking().FirstOrDefaultAsync();

            ViewData["Aircrafts"] = res;
            ViewData["Stores"] = str;
            ViewData["Documents"] = doc;
            ViewData["AircraftsCount"] = res.Count;
            ViewData["StoreCount"] = str.Count;
            ViewData["DocumentCount"] = doccount;
            ViewData["AircraftLast"] = $"Last created Aircraft {airctafts.OrderBy(i => i.ItemId)?.LastOrDefault()?.RegistrationNumber}" ;
            ViewData["StoreLast"] = $"Last created Store {stores.OrderBy(i => i.ItemId)?.LastOrDefault()?.StoreName}" ;
            ViewData["DocumentLast"] = $"Last added document {documents.OrderBy(i => i.ItemId)?.LastOrDefault()?.Description}" ;
            ViewData["MainMenu"] = MainMenu.Items.OrderByDescending(i => i.SubMenu.Count() > 0).ThenBy(i => i.Header).ToList(); 
            ViewData["Operators"] = op;


            return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
