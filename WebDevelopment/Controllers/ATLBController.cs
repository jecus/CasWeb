using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.Views;
using Entity.Extentions;
using Entity.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDevelopment.Helper;
using WebDevelopment.Infrastructude;

namespace WebDevelopment.Controllers
{
    [AircraftRoute("atlb")]
    public class ATLBController : Controller
    {
        private readonly DatabaseContext _db;

        public ATLBController(DatabaseContext db)
        {
	        _db = db;
        }

        public async Task<IActionResult> Index([FromRoute]int aircraftId)
        {
            var atlbs = await _db.Atlbs
                .Where(i => i.AircraftID == aircraftId)
                .AsNoTracking()
                .OnlyActive()
                .ToListAsync();

            var view = atlbs.ToBlView();

            foreach (var atlb in view)
            {
                var first = await _db.AircraftFlights
                    .OnlyActive()
                    .AsNoTracking()
                    .OrderBy(i => i.FlightDate)
                    .FirstOrDefaultAsync(i => i.ATLBID == atlb.Id);

                var last = await _db.AircraftFlights
                    .OnlyActive()
                    .AsNoTracking()
                    .OrderBy(i => i.FlightDate)
                    .LastOrDefaultAsync(i => i.ATLBID == atlb.Id);

                var pages = (first != null && first.PageNo != "" ? first.PageNo : "XXX") + " - " +
                            (last != null && last.PageNo != "" ? last.PageNo : "XXX");

                var dates = (first != null ? first.FlightDate.ToUniversalString(): "YY:MM:DD") + " - " +
                           (last != null ? last.FlightDate.ToUniversalString() : "YY:MM:DD");

                atlb.Pages = pages;
                atlb.Dates = dates;
            }

            return View(view);
        }

        [Route("edit")]
        public async Task<IActionResult> ModalEdit(int atlbId)
        {
            var a = await _db.Atlbs
                .FirstOrDefaultAsync(i => i.Id == atlbId);
            return PartialView("Modal", a.ToBlView());
        }

        [Route("create")]
        public async Task<IActionResult> ModalCreate()
        {
	        return PartialView("Modal", new ATLBView());
        }

		[HttpPost]
        public async Task<IActionResult> Create(ATLBView view)
        {
            await _db.SaveAsync(view.ToEntity());
            return RedirectToAction("Index", new {aircraftId = GlobalObject.AircraftId });
        }
    }
}