using System;
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
using WebDevelopment.Models;

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
					.Where(i => i.ATLBID == atlb.Id)
					.OrderBy(i => i.FlightDate).Select(i => new { i.PageNo, i.FlightDate })
					.FirstOrDefaultAsync();

				var last = await _db.AircraftFlights
					.OnlyActive()
					.AsNoTracking()
					.Where(i => i.ATLBID == atlb.Id)
					.OrderBy(i => i.FlightDate).Select(i => new { i.PageNo, i.FlightDate})
					.LastOrDefaultAsync();

				var pages = (first != null && first.PageNo != "" ? first.PageNo : "XXX") + " - " +
				            (last != null && last.PageNo != "" ? last.PageNo : "XXX");

				var dates = (first != null ? first.FlightDate.ToUniversalString() : "YY:MM:DD") + " - " +
				            (last != null ? last.FlightDate.ToUniversalString() : "YY:MM:DD");

				atlb.Pages = pages;
				atlb.Dates = dates;
                atlb.DateFrom = first?.FlightDate.Value ?? DateTime.MinValue;
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

        [Route("confirm")]
		public async Task<IActionResult> ConfirmDelete(int atlbId)
		{
			return PartialView("Modals/ConfirmDeleteModal", new ModalDeleteView("ATLB", "Delete", atlbId));
		}

		[HttpPost("delete")]
		public async Task<IActionResult> Delete(int id)
		{
			var atlb = await _db.Atlbs.AsNoTracking().FirstOrDefaultAsync(i => i.Id == id);
			await _db.Delete(atlb);
			return RedirectToAction("Index", new { aircraftId = GlobalObject.AircraftId });
		}
	}
}