

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BusinessLayer.Dictionaties;
using BusinessLayer.Repositiry.Interfaces;
using BusinessLayer.Views;
using Entity.Extentions;
using Entity.Infrastructure;
using Entity.Models.General;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Repositiry
{
	public class DirectiveRepository : IDirectiveRepository
	{
		private readonly DatabaseContext _db;
		private IComponentRepository _componentRepository;

		public DirectiveRepository(IComponentRepository componentRepository, DatabaseContext db)
		{
			_componentRepository = componentRepository;
			_db = db;
		}

		public async Task<List<DirectiveView>> GetDirectives(int aircraftId, DirectiveType directiveType)
		{
			var basecomponentIds = await _componentRepository.GetAircraftBaseComponentIds(aircraftId);
			var directives = await _db.Directives
				.Where(FilterByType(basecomponentIds,directiveType))
				.Include(i => i.ATAChapter)
				.AsNoTracking()
				.OnlyActive()
				.ToListAsync();

			var ids = directives.Select(i => i.Id);
			var fileLinks = await _db.ItemFileLinks
				.AsNoTracking()
				.Where(i => i.ParentTypeId == SmartCoreType.Directive.ItemId && ids.Contains(i.ParentId))
				.ToListAsync();

			var view = directives.ToBlView();

			foreach (var directiveView in view)
			{
				directiveView.ItemFileLink.AddRange(fileLinks.Where(i => i.ParentId == directiveView.Id));
			}

			return view;
		}


		private Expression<Func<Directive, bool>> FilterByType(IEnumerable<int> baseComponentIds, DirectiveType directiveType)
		{
			Expression <Func<Directive, bool>> res;
			
			if (directiveType == DirectiveType.All)
			{
				int[] ids =
				{
					DirectiveType.AirworthenessDirectives.ItemId,
					DirectiveType.DamagesRequiring.ItemId,
					DirectiveType.EngineeringOrders.ItemId,
					DirectiveType.OutOfPhase.ItemId,
					DirectiveType.SB.ItemId
				};

				res = d => baseComponentIds.Contains(d.ComponentId.Value) && ids.Contains(d.DirectiveType.Value);
			}
			else if (directiveType == DirectiveType.EngineeringOrders)
			{
				res = d => baseComponentIds.Contains(d.ComponentId.Value) && 
				           (!string.IsNullOrEmpty(d.EngineeringOrders) ||
				           d.ServiceBulletinFileID.Value > 0 ||
				           d.DirectiveType == DirectiveType.EngineeringOrders.ItemId);
			}
			else if (directiveType == DirectiveType.SB)
			{
				res = d => baseComponentIds.Contains(d.ComponentId.Value) && 
				           (!string.IsNullOrEmpty(d.ServiceBulletinNo) ||
				           d.ServiceBulletinFileID.Value > 0 ||
				           d.DirectiveType == DirectiveType.SB.ItemId);
			}
			else
			{
				res = d => baseComponentIds.Contains(d.ComponentId.Value) && 
				           (d.Title != "N/A" &&
				           d.DirectiveType == directiveType.ItemId);
			}

			return res;
		}
	}
}