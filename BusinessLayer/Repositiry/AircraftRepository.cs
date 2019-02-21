using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLayer.Mapping;
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
		private readonly IMapper _mapper;

		public AircraftRepository(IMapper mapper, DatabaseContext databaseContext)
		{
			_mapper = mapper;
			_db = databaseContext;
		}

		public async Task<AircraftView> GetById(int id)
		{
			var aircraft = await _db.Aircrafts
				.OnlyActive()
                .Include(i => i.Model)
				.FirstOrDefaultAsync(i => i.ItemId == id);
			return _mapper.MapToBlView<Aircraft, AircraftView>(aircraft);
		}

		public async Task<List<AircraftView>> Get(IEnumerable<int> ids)
		{
			var aircraft = await _db.Aircrafts
				.AsNoTracking()
				.OnlyActive()
				.Where(i => ids.Contains(i.ItemId))
				.ToListAsync();
			return (List<AircraftView>) _mapper.MapToBlView<Aircraft, AircraftView>(aircraft);
		}

		public async Task<List<AircraftView>> GetAll()
		{
			var aircraft = await _db.Aircrafts
				.AsNoTracking()
				.OnlyActive()
				.Include(i => i.Model)
				.ToListAsync();
			return (List<AircraftView>)_mapper.MapToBlView<Aircraft, AircraftView>(aircraft);
		}
	}
}