using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.Repositiry.Interfaces;
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
		public async Task<IActionResult> Index([FromRoute]int aircraftId)
		{
			var view = await _componentRepository.GetComponentsByBaseComponentIds(GlobalObject.BaseComponentIds);
			return View(view);
		}

		[HttpGet("transfer")]
		public async Task<ActionResult> TransferRecord_HierarchyBinding(int componentId, [DataSourceRequest] DataSourceRequest request)
		{
			var tr = await _context.TransferRecords.AsNoTracking().Where(i => i.ParentID == componentId).ToListAsync();
			return Json(tr.ToBlView().ToDataSourceResult(request));
		}
	}
}