using System;
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
	public class AtlbRepository : IAtlbRepository
	{
		private readonly DatabaseContext _db;

		public AtlbRepository(DatabaseContext db)
		{
			_db = db;
		}

		public async Task<List<ATLBView>> GetAircraftAtlbs(int aircraftId)
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
					.OrderBy(i => i.FlightDate).Select(i => new { i.PageNo, i.FlightDate })
					.LastOrDefaultAsync();

				var pages = (first != null && first.PageNo != "" ? first.PageNo : "XXX") + " - " +
				            (last != null && last.PageNo != "" ? last.PageNo : "XXX");

				var dates = (first != null ? first.FlightDate.ToUniversalString() : "YY:MM:DD") + " - " +
				            (last != null ? last.FlightDate.ToUniversalString() : "YY:MM:DD");

				atlb.Pages = pages;
				atlb.Dates = dates;
				atlb.DateFrom = first?.FlightDate.Value ?? DateTime.MinValue;
			}

			return view;
		}

		public async Task<ATLBView> GetById(int atlbId)
		{
			var atlb = await _db.Atlbs
				.FirstOrDefaultAsync(i => i.Id == atlbId);

			return atlb.ToBlView();
		}
	}
}