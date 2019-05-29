using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Repositiry.Interfaces;
using Entity.Extentions;
using Entity.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDevelopment.Helper;
using WebDevelopment.Infrastructude;
using WebDevelopment.Infrastructude.JWT;

namespace WebDevelopment.Controllers
{
	[Auth(Roles.Sender)]
	[AircraftRoute("workpackages")]
	public class WorkPackageController : Controller
    {
	    private readonly IWorkPackageRepository _workPackageRepository;
	    private readonly DatabaseContext _db;

	    public WorkPackageController(IWorkPackageRepository workPackageRepository, DatabaseContext db)
	    {
		    _workPackageRepository = workPackageRepository;
		    _db = db;
	    }

	    [HttpGet]
		public async Task<IActionResult> Index(int aircraftId)
        {
	        var wp = await _workPackageRepository.GetWorkPackages(new List<int> { aircraftId });
	        return View(wp);
        }

		[HttpGet("all")]
        public async Task<IActionResult> AllWorkPackages()
        {
	        var aircraftIds = await _db.Aircrafts
		        .AsNoTracking()
		        .OnlyActive()
		        .Select(i => i.Id)
		        .ToListAsync();

			var wp = await _workPackageRepository.GetWorkPackages(new List<int>(aircraftIds));
	        return View(wp);
        }
	}
}