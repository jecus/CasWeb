using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Repositiry.Interfaces;
using BusinessLayer.Views;
using Entity.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDevelopment.Helper;
using WebDevelopment.Infrastructude;
using WebDevelopment.Infrastructude.JWT;

namespace WebDevelopment.Controllers
{
	[Auth(Roles.Sender)]
	[Route("aircraft/{aircraftId}")]
    public class AircraftController : Controller
    {
	    private readonly IAircraftRepository _aircraftRepository;
	    private readonly IComponentRepository _componentRepository;
	    private readonly DatabaseContext _db;

        public AircraftController(IAircraftRepository aircraftRepository, IComponentRepository componentRepository, DatabaseContext db)
        {
            _aircraftRepository = aircraftRepository;
            _componentRepository = componentRepository;
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Index([FromRoute]int aircraftId)
        {
	        GlobalObject.AircraftMainMenu = new AircraftMainMenu(Url, aircraftId);

	        var bc = await _componentRepository.GetAircraftBaseComponents(aircraftId);
	        foreach (var view in bc)
	        {
		        view.ParentAircraftId = aircraftId;
	        }
	        GlobalObject.BaseComponent = new List<BaseComponentView>(bc);

			var aircraft = await _aircraftRepository.GetById(aircraftId);
			GlobalObject.Aircraft = aircraft;
			ViewData["Operator"] = await _db.Operators.FirstOrDefaultAsync();
            ViewData["BaseComponents"] = bc;
			return View(aircraft);
        }
    }
}