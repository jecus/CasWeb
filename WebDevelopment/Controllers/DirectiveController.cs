using System.Threading.Tasks;
using BusinessLayer.Dictionaties;
using BusinessLayer.Repositiry.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebDevelopment.Helper;
using WebDevelopment.Infrastructude;
using WebDevelopment.Infrastructude.JWT;

namespace WebDevelopment.Controllers
{
	[Auth(Roles.Sender)]
	[AircraftRoute("directive")]
	public class DirectiveController : Controller
	{
		private readonly IDirectiveRepository _directiveRepository;

		public DirectiveController(IDirectiveRepository directiveRepository)
		{
			_directiveRepository = directiveRepository;
		}

		public async Task<IActionResult> Index([FromRoute]int aircraftId, DirectiveType directiveType)
		{
			var view = await _directiveRepository.GetDirectives(aircraftId, directiveType);
			return View(view);
		}
	}
}