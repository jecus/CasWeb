﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Repositiry.Interfaces;
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
	        GlobalObject.AircraftId = aircraftId;
	        GlobalObject.AircraftMainMenu = new AircraftMainMenu(Url, aircraftId);

	        var bc = await _componentRepository.GetAircraftBaseComponents(aircraftId);
	        GlobalObject.BaseComponentIds = new List<int>(bc.Select(i => i.Id));

			var aircraft = await _aircraftRepository.GetById(aircraftId);
            GlobalObject.RegistrationNumber = aircraft.RegistrationNumber;
            ViewData["Operator"] = await _db.Operators.FirstOrDefaultAsync();
            ViewData["BaseComponents"] = bc;
			return View(aircraft);
        }
    }
}