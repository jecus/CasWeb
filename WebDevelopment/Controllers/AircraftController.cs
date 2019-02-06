using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebDevelopment.Helper;

namespace WebDevelopment.Controllers
{

    public class AircraftController : Controller
    {
        public IActionResult Index(int aircraftId)
        {
	        ViewData["MainMenu"] = AircraftMainMenu.Items.OrderByDescending(i => i.SubMenu.Count() > 0).ThenBy(i => i.Header).ToList();

			return View();
        }
    }
}