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
		[HttpGet("ad")]
		public async Task<IActionResult> All([FromRoute]int aircraftId, int directiveType)
		{
			var view = await _directiveRepository.GetDirectives(aircraftId, DirectiveType.GetDirectiveTypeById(directiveType));
			return View(view);
		}

		[HttpGet("eo")]
		public async Task<IActionResult> Eo([FromRoute]int aircraftId, int directiveType)
		{
			var view = await _directiveRepository.GetDirectives(aircraftId, DirectiveType.GetDirectiveTypeById(directiveType));
			return View(view);
		}

		[HttpGet("sb")]
		public async Task<IActionResult> Sb([FromRoute]int aircraftId, int directiveType)
		{
			var view = await _directiveRepository.GetDirectives(aircraftId, DirectiveType.GetDirectiveTypeById(directiveType));
			return View(view);
		}
	}
}