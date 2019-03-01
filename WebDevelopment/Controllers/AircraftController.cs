using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.Repositiry.Interfaces;
using BusinessLayer.Views;
using Entity.Extentions;
using Entity.Infrastructure;
using Entity.Models.General;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDevelopment.Helper;

namespace WebDevelopment.Controllers
{
    public class AircraftController : Controller
    {
	    private readonly IAircraftRepository _aircraftRepository;
        private readonly DatabaseContext _db;

        public AircraftController(IAircraftRepository aircraftRepository, DatabaseContext db)
        {
            _aircraftRepository = aircraftRepository;
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int aircraftId)
        {
            var aircraft = await _aircraftRepository.GetById(aircraftId);
            var bc = await _db.Components
	            .AsNoTracking()
	            .OnlyActive()
	            .Where(i => i.IsBaseComponent && i.TransferRecords.OrderBy(t => t.TransferDate).FirstOrDefault(t => t.ParentID == i.Id).DestinationObjectID == aircraftId &&
	                        i.TransferRecords.OrderBy(t => t.TransferDate).FirstOrDefault(t => t.ParentID == i.Id).DestinationObjectType == 7)
	            .Include(i => i.TransferRecords)
	            .Include(i => i.Model)
	            .ToListAsync();


            var mainMenu = new AircraftMainMenu(Url);
            ViewData["MainMenu"] = mainMenu.Items.OrderByDescending(i => i.SubMenu.Count() > 0).ThenBy(i => i.Header).ToList();
            ViewData["Aircraft"] = aircraft;
            ViewData["Operator"] = await _db.Operators.FirstOrDefaultAsync();
            ViewData["BaseComponents"] = bc.ToBaseComponentView();
            return View();
        }
    }
}