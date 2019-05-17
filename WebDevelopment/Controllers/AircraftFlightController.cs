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
using WebDevelopment.Infrastructude.JWT;
using WebDevelopment.Models;

namespace WebDevelopment.Controllers
{
	[Auth(Roles.Sender)]
	[AircraftRoute("fligts")]
    public class AircraftFlightController : Controller
    {
        private readonly DatabaseContext _db;

        public AircraftFlightController(DatabaseContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index(int atlbId)
        {
            GlobalObject.AtlbId = atlbId;
            var flights = await _db.AircraftFlights
                .Where(i => i.ATLBID == atlbId)
                .AsNoTracking()
                .Include(i => i.StationFroms)
                .Include(i => i.StationTos)
                .Include(i => i.FlightNumber)
                .OnlyActive()
                .ToListAsync();

            var view = flights.ToBlView();

            
            foreach (var flight in view)
            {
                var times = "";
                if (flight.AtlbRecordType != AtlbRecordType.Maintenance)
                    times = $"{TimeSpan.FromMinutes(flight.OutTime).TimeToString()} - {TimeSpan.FromMinutes(flight.InTime).TimeToString()}";

                string route;
                if (flight.AtlbRecordType != AtlbRecordType.Maintenance)
                    route = flight.StationFroms.Iata + " - " + flight.StationTos.Iata;
                else route = flight.StationTos.Iata;

                flight.Times = times;
                flight.Route = route;
            }

            return View(view);
            
        }

        [Route("addflight")]
        public async Task<IActionResult> ModalAddRegFlight()
        {
			var flightNum = await _db.FlightNums
				.AsNoTracking()
				.OnlyActive()
				.ToListAsync();

			var stations = await _db.AirportCodes
				.AsNoTracking()
				.OnlyActive()
				.ToListAsync();

			var reasons = await _db.Reasons
				.AsNoTracking()
				.OnlyActive()
				.ToListAsync();

			var ata = await _db.AtaChapters
				.AsNoTracking()
				.OnlyActive()
				.ToListAsync();

			var spec = await _db.Specialists
				.AsNoTracking()
				.OnlyActive()
				.ToListAsync();

			var disc = await _db.Discrepancies
				.AsNoTracking()
				.OnlyActive()
				.Include(i => i.CorrectiveAction)
				.Include(i => i.CorrectiveAction.CertificateOfReleaseToService)
				.Include(i => i.ATAChapter)
				.ToListAsync();

			ViewData["FlightNums"] = flightNum.ToBlView();
			ViewData["AirportCodes"] = stations.ToBlView();
			ViewData["Reasons"] = reasons.ToBlView();
			ViewData["Discrepancy"] = disc.ToBlView();
			ViewData["Specialists"] = spec.ToBlView();
			ViewData["AtaChapter"] = ata.ToBlView().OrderBy(i => i.ShortName).ToList();

			var a = await _db.AircraftFlights
				.Include(i => i.FlightNumber)
				.Include(i => i.StationFroms)
				.Include(i => i.StationTos)
				.FirstOrDefaultAsync();

			var flight = a.ToBlView();
			flight.Discrepancy.AddRange(disc.ToBlView());

			return PartialView("ModalAddRegFlight", new AircraftFlightView());
        }

        [HttpPost]
        public async Task<IActionResult> Create(AircraftFlightView view)
        {
            await _db.SaveAsync(view.ToEntity());
            return RedirectToAction("Index", new { atlbId = GlobalObject.AtlbId, aircraftId = GlobalObject.AircraftId });
        }

        [Route("editflight")]
        public async Task<IActionResult> ModalEditRegFlight(int flightId)
        {
            var flightNum = await _db.FlightNums
                .AsNoTracking()
                .OnlyActive()
                .ToListAsync();

            var stations = await _db.AirportCodes
                .AsNoTracking()
                .OnlyActive()
                .ToListAsync();

            var reasons = await _db.Reasons
                .AsNoTracking()
                .OnlyActive()
                .ToListAsync();

            var ata = await _db.AtaChapters
                .AsNoTracking()
                .OnlyActive()
                .ToListAsync();

            var spec = await _db.Specialists
                .AsNoTracking()
                .OnlyActive()
                .ToListAsync();

            var disc = await _db.Discrepancies
                .AsNoTracking()
                .OnlyActive()
                .Include(i => i.CorrectiveAction)
                .Include(i => i.CorrectiveAction.CertificateOfReleaseToService)
                .Include(i => i.ATAChapter)
                .Where(i => i.FlightID == flightId)
                .ToListAsync();

            ViewData["FlightNums"] = flightNum.ToBlView();
            ViewData["AirportCodes"] = stations.ToBlView();
            ViewData["Reasons"] = reasons.ToBlView();
            ViewData["Discrepancy"] = disc.ToBlView();
            ViewData["Specialists"] = spec.ToBlView();
            ViewData["AtaChapter"] = ata.ToBlView().OrderBy(i => i.ShortName).ToList();

            var a = await _db.AircraftFlights
                .Include(i => i.FlightNumber)
                .Include(i => i.StationFroms)
                .Include(i => i.StationTos)
                .FirstOrDefaultAsync(i => i.Id == flightId);

            var flight = a.ToBlView();
            flight.Discrepancy.AddRange(disc.ToBlView());

            return PartialView("ModalAddRegFlight", flight);
        }

        [Route("addmaint")]
        public async Task<IActionResult> ModalAddMaint()
        {
            var flightNum = await _db.FlightNums
                .AsNoTracking()
                .OnlyActive()
                .ToListAsync();

            var stations = await _db.AirportCodes
                .AsNoTracking()
                .OnlyActive()
                .ToListAsync();

            ViewData["FlightNums"] = flightNum.ToBlView();
            ViewData["AirportCodes"] = stations.ToBlView();

            return PartialView("ModalAddMaint", new AircraftFlightView());
        }

        [Route("confirm")]
        public async Task<IActionResult> ConfirmDelete(int flightId)
        {
            return PartialView("Modals/ConfirmDeleteModal", new ModalDeleteView("AircraftFlight", "Delete", flightId));
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var flight = await _db.AircraftFlights.AsNoTracking().FirstOrDefaultAsync(i => i.Id == id);
            await _db.Delete(flight);
            return RedirectToAction("Index", new { aircraftId = GlobalObject.AircraftId });
        }
    }
}