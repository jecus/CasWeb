using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Dictionaties;
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
				.Include(i => i.ATAChapter)
				.AsNoTracking()
				.OnlyActive()
				.ToListAsync();

			var mpdIds = mpds.Select(i => i.Id);
			var fileLinks = await _db.ItemFileLinks
				.AsNoTracking()
				.Where(i => i.ParentTypeId == SmartCoreType.MaintenanceDirective.ItemId && mpdIds.Contains(i.ParentId))
				.ToListAsync();

			var view = mpds.ToBlView();
			
			foreach (var directiveView in view)
				directiveView.ItemFileLink.AddRange(fileLinks.Where(i => i.ParentId == directiveView.Id));
			
			return view;
		}
	}
}