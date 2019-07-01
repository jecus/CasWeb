using System.Threading.Tasks;
using BusinessLayer.Repositiry.Interfaces;
using Microsoft.AspNetCore.Mvc;
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

		public ComponentController(IComponentRepository componentRepository)
		{
			_componentRepository = componentRepository;
		}

		public async Task<IActionResult> Index([FromRoute]int aircraftId)
		{
			var view = await _componentRepository.GetComponentsByBaseComponentIds(GlobalObject.BaseComponentIds);
			return View(view);
		}
	}
}