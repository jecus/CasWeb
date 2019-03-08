using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.Repositiry.Interfaces;
using Entity.Extentions;
using Entity.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDevelopment.Helper;
using WebDevelopment.Infrastructude;

namespace WebDevelopment.Controllers
{
	[Route("aircraft/{aircraftId}")]
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
        public async Task<IActionResult> Index([FromRoute]int aircraftId)
        {
	        GlobalObject.AircraftId = aircraftId;
	        GlobalObject.AircraftMainMenu = new AircraftMainMenu(Url, aircraftId);

            var aircraft = await _aircraftRepository.GetById(aircraftId);
            var bc = await _db.Components
	            .AsNoTracking()
	            .OnlyActive()
	            .Where(i => i.IsBaseComponent && i.TransferRecords.OrderBy(t => t.TransferDate).FirstOrDefault(t => t.ParentID == i.Id).DestinationObjectID == aircraftId &&
	                        i.TransferRecords.OrderBy(t => t.TransferDate).FirstOrDefault(t => t.ParentID == i.Id).DestinationObjectType == 7)
	            .Include(i => i.TransferRecords)
	            .Include(i => i.Model)
	            .ToListAsync();


            ViewData["Aircraft"] = aircraft;
            ViewData["Operator"] = await _db.Operators.FirstOrDefaultAsync();
            ViewData["BaseComponents"] = bc.ToBaseComponentView();
            return View();
        }
    }
}