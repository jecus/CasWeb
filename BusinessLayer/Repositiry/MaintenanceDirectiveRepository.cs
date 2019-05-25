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
	public class MaintenanceDirectiveRepository : IMaintenanceDirectiveRepository
	{
		private readonly IComponentRepository _componentRepository;
		private readonly DatabaseContext _db;

		public MaintenanceDirectiveRepository(IComponentRepository componentRepository, DatabaseContext db)
		{
			_componentRepository = componentRepository;
			_db = db;
		}

		public async Task<List<MaintenanceDirectiveView>> GetMaintenanceDirective(int aircraftId)
		{
			var basecomponentIds = await _componentRepository.GetAircraftBaseComponentIds(aircraftId);
			var mpds = await _db.MaintenanceDirectives
				.Where(i => basecomponentIds.Contains(i.ComponentId.Value))
				.AsNoTracking().OnlyActive().ToListAsync();

			return mpds.ToBlView();
		}
	}
}