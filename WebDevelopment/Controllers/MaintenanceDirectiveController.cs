using System.Threading.Tasks;
using BusinessLayer.Repositiry.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebDevelopment.Helper;
using WebDevelopment.Infrastructude;
using WebDevelopment.Infrastructude.JWT;

namespace WebDevelopment.Controllers
{
	[Auth(Roles.Sender)]
	[AircraftRoute("maintenanceDirective")]
	public class MaintenanceDirectiveController : Controller
	{
		private readonly IMaintenanceDirectiveRepository _maintenanceDirectiveRepository;

		public MaintenanceDirectiveController(IMaintenanceDirectiveRepository maintenanceDirectiveRepository)
		{
			_maintenanceDirectiveRepository = maintenanceDirectiveRepository;
		}

		public async Task<IActionResult> Index([FromRoute]int aircraftId)
		{
			var view = await _maintenanceDirectiveRepository.GetMaintenanceDirective(aircraftId);
			return View(view);
		}
	}
}