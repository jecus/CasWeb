using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Repositiry.Interfaces;
using BusinessLayer.Views;
using Entity.Extentions;
using Entity.Infrastructure;
using Entity.Models;
using Entity.Models.General;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Repositiry
{
	public class AircraftRepository : IAircraftRepository
	{
		private readonly DatabaseContext _db;

		public AircraftRepository(DatabaseContext databaseContext)
		{
			_db = databaseContext;
		}

		public async Task<AircraftView> GetById(int id)
		{
			var aircraft = await _db.Aircrafts
				.OnlyActive()
                .Include(i => i.Model)
				.FirstOrDefaultAsync(i => i.Id == id);
            return aircraft.ToBlView();

        }

		public async Task<List<AircraftView>> Get(IEnumerable<int> ids)
		{
			var aircraft = await _db.Aircrafts
				.AsNoTracking()
				.OnlyActive()
				.Where(i => ids.Contains(i.Id))
				.ToListAsync();
			return aircraft.ToBlView();
		}

		public async Task<List<AircraftView>> GetAll()
		{
			var aircraft = await _db.Aircrafts
				.AsNoTracking()
				.OnlyActive()
				.Include(i => i.Model)
				.ToListAsync();
			return aircraft.ToBlView();
		}
	}
}