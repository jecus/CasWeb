using System.Threading.Tasks;
using BusinessLayer.Repositiry.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebDevelopment.Helper;
using WebDevelopment.Infrastructude;
using WebDevelopment.Infrastructude.JWT;

namespace WebDevelopment.Controllers
{
	[Auth(Roles.Sender)]
	[AircraftRoute("wprecords")]
	public class WorkPackageRecordController : Controller
	{
		private readonly IWorkPackageRepository _workPackageRepository;

		public WorkPackageRecordController(IWorkPackageRepository workPackageRepository)
		{
			_workPackageRepository = workPackageRepository;
		}

		public async Task<IActionResult> Index(int wpId)
		{
			var res = await _workPackageRepository.GetWorkPackageRecordsTask(wpId);
			foreach (var view in res)
				view.Task.Type = GridViewGroupHelper.GetGroupString(view.Task.Parent);
			return View(res);
		}
	}
}