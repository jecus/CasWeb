using System.Threading.Tasks;
using BusinessLayer.Repositiry.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebDevelopment.Helper;
using WebDevelopment.Infrastructude;
using WebDevelopment.Infrastructude.JWT;

namespace WebDevelopment.Controllers
{
	[Auth(Roles.Sender)]
	[AircraftRoute("workpackage")]
	public class WorkPackageController : Controller
    {
	    private readonly IWorkPackageRepository _workPackageRepository;

	    public WorkPackageController(IWorkPackageRepository workPackageRepository)
	    {
		    _workPackageRepository = workPackageRepository;
	    }
        public async Task<IActionResult> Index(int aircraftId)
        {
	        var wp = await _workPackageRepository.GetWorkPackages(aircraftId); 

            return View(wp);
        }
    }
}