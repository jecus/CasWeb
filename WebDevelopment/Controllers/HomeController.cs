using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.Repositiry.Interfaces;
using Entity.Extentions;
using Entity.Infrastructure;
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

        public HomeController(IAircraftRepository aircraftRepository, DatabaseContext db)
        {
	        _aircraftRepository = aircraftRepository;
	        _db = db;
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


            var str = stores.ToBlView()
                .OrderBy(i => i.StoreName)
                .ToList();

            var documents = await _db.Documents.OnlyActive()
                .OrderByDescending(x => x.Id)
                .Take(5)
                .ToListAsync();
            var doc = documents.ToBlView().ToList();
            var doccount = await _db.Documents.CountAsync();

            var op = await _db.Operators.AsNoTracking().FirstOrDefaultAsync();

			ViewData["Documents"] = doc;
			ViewData["AircraftsCount"] = res.Count;
			ViewData["StoreCount"] = str.Count;
			ViewData["DocumentCount"] = doccount;
			ViewData["AircraftLast"] = $"Last created Aircraft {airctafts.OrderBy(i => i.Id)?.LastOrDefault()?.RegistrationNumber}";
			ViewData["StoreLast"] = $"Last created Store {stores.OrderBy(i => i.Id)?.LastOrDefault()?.StoreName}";
			ViewData["DocumentLast"] = $"Last added document {documents.OrderBy(i => i.Id)?.LastOrDefault()?.Description}";
			ViewData["Operators"] = op;

			var mainMenu = new MainMenu(Url);
			LayoutViewModel.StoreViews = str;
			LayoutViewModel.AircraftViews = res;
			LayoutViewModel.Operator = op;
			LayoutViewModel.MainMenu = mainMenu.Items.OrderByDescending(i => i.SubMenu.Count() > 0).ThenBy(i => i.Header).ToList(); ;



            return View();
		}

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
