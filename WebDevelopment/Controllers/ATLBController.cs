using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.Views;
using Entity.Extentions;
using Entity.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDevelopment.Helper;

namespace WebDevelopment.Controllers
{
    [Route("{aircraftId}/atlb")]
    public class ATLBController : Controller
    {
        private readonly DatabaseContext _db;

        public ATLBController(DatabaseContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index(int aircraftId)
        {
            var atlbs = await _db.Atlbs
                .Where(i => i.AircraftID == aircraftId)
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

            var mainMenu = new AircraftMainMenu(Url, aircraftId);
            ViewData["MainMenu"] = mainMenu.Items.OrderByDescending(i => i.SubMenu.Count() > 0).ThenBy(i => i.Header).ToList();
            ViewData["AircraftId"] = aircraftId;
            return View(view);
        }

        [Route("edit")]
        public async Task<IActionResult> Modal(int atlbId)
        {
            var a = await _db.Atlbs
                .FirstOrDefaultAsync(i => i.Id == atlbId);
            return PartialView("Modal", a.ToBlView());
        }

        //[Route("new")]
        //public async Task<IActionResult> ModalNew(int aircraftId)
        //{
        //    return PartialView("Modal", new ATLBView { AircraftID = aircraftId });
        //}

        [HttpPost]
        public async Task<IActionResult> Create(ATLBView view)
        {
            if (view.Id > 0)
            {
                _db.Atlbs.Add(view.ToEntity());
            }
            await _db.SaveChangesAsync();

            return Ok();
        }
    }
}