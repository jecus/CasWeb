using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.Repositiry.Interfaces;
using BusinessLayer.Views;
using Entity.Extentions;
using Entity.Infrastructure;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDevelopment.Helper;
using WebDevelopment.Infrastructude;
using WebDevelopment.Infrastructude.JWT;

namespace WebDevelopment.Controllers
{
	[Auth(Roles.Sender)]
	[AircraftRoute("components")]
	public class ComponentController : Controller
	{
		private readonly IComponentRepository _componentRepository;
		private readonly DatabaseContext _context;

		public ComponentController(IComponentRepository componentRepository, DatabaseContext context)
		{
			_componentRepository = componentRepository;
			_context = context;
		}

		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var view = await _componentRepository.GetComponentsByBaseComponentIds(GlobalObject.BaseComponentIds);
			var bcView = await _componentRepository.GetAircraftBaseComponents(GlobalObject.AircraftId);
			var res = new List<ComponentView>();
			res.AddRange(view);
			res.AddRange(bcView);
			
			return View(res);
		}

		[HttpGet("transfer")]
		public async Task<ActionResult> ComponentDirective_HierarchyBinding(int componentId, [DataSourceRequest] DataSourceRequest request)
		{
			var tr = await _context.ComponentDirectives
				.AsNoTracking()
				.Where(i => i.ComponentId == componentId)
				.OnlyActive()
				.Include(i => i.Component)
				.Include(i => i.Component.Model)
				.Include(i => i.Component.Product)
				.Include(i => i.Component.ATAChapter)
				.Include(i => i.Component.TransferRecords)
				.ToListAsync();
			return Json(tr.ToBlView().ToDataSourceResult(request));
		}
	}
}