using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using Entity.Extentions;
using Entity.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDevelopment.Infrastructude;

namespace WebDevelopment.Controllers
{
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
                    times = $"{TimeSpan.FromMinutes(flight.OutTime.Value).TimeToString()} - {TimeSpan.FromMinutes(flight.InTime.Value).TimeToString()}";

                string route;
                if (flight.AtlbRecordType != AtlbRecordType.Maintenance)
                    route = flight.StationFroms.Iata + " - " + flight.StationTos.Iata;
                else route = flight.StationTos.Iata;

                flight.Times = times;
                flight.Route = route;
            }

            return View(view);
            
        }
    }
}