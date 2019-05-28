using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Repositiry.Interfaces;
using BusinessLayer.Views;
using Entity.Extentions;
using Entity.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Repositiry
{
	public class WorkPackageRepository : IWorkPackageRepository
	{
		private readonly DatabaseContext _db;

		public WorkPackageRepository(DatabaseContext db)
		{
			_db = db;
		}

		public async Task<List<WorkPackageView>> GetWorkPackages(int aircraftId)
		{
			var wp = await _db.WorkPackages
				.Where(i => i.ParentId == aircraftId)
				.OnlyActive()
				.AsNoTracking()
				.ToListAsync();

			var view = wp.ToBlView();

			var airportIds = new List<int>();
			airportIds.AddRange(view.Select(i => i.PerfAfter.AirportFromId));
			airportIds.AddRange(view.Select(i => i.PerfAfter.AirportToId));

			var airports = await _db.AirportCodes
				.Where(i => airportIds.Contains(i.Id))
				.OnlyActive()
				.AsNoTracking()
				.ToListAsync();

			var airportView = airports.ToBlView();

			var flightNumIds = view.Select(i => i.PerfAfter.FlightNumId);
			var flightNums = await _db.FlightNums
				.Where(i => flightNumIds.Contains(i.Id))
				.OnlyActive()
				.AsNoTracking()
				.ToListAsync();

			var flightNum = flightNums.ToBlView();

			foreach (var workPackageView in view)
			{
				workPackageView.PerfAfter.AirportFrom = airportView.FirstOrDefault(i => i.Id == workPackageView.PerfAfter.AirportFromId);
				workPackageView.PerfAfter.AirportTo = airportView.FirstOrDefault(i => i.Id == workPackageView.PerfAfter.AirportToId);
				workPackageView.PerfAfter.FlightNum = flightNum.FirstOrDefault(i => i.Id == workPackageView.PerfAfter.FlightNumId);
			}

			return view;
		}
	}
}