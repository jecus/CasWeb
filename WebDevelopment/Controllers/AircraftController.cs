using System.Linq;
using BusinessLayer.Repositiry;
using BusinessLayer.Repositiry.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebDevelopment.Helper;

namespace WebDevelopment.Controllers
{
    public class AircraftController : Controller
    {
	    private readonly IAircraftRepository _aircraftRepository;

	    public AircraftController(AircraftRepository aircraftRepository)
	    {
		    _aircraftRepository = aircraftRepository;
	    }

        public IActionResult Index(int aircraftId)
        {
	        ViewData["MainMenu"] = AircraftMainMenu.Items.OrderByDescending(i => i.SubMenu.Count() > 0).ThenBy(i => i.Header).ToList();

			return View();
        }
    }
}