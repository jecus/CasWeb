﻿using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLayer.Mapping;
using BusinessLayer.Repositiry;
using BusinessLayer.Repositiry.Interfaces;
using BusinessLayer.Views;
using Entity.Infrastructure;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDevelopment.Helper;

namespace WebDevelopment.Controllers
{
    public class AircraftController : Controller
    {
	    private readonly IAircraftRepository _aircraftRepository;
        private readonly DatabaseContext _db;
        private readonly IMapper _mapper;

        public AircraftController(IAircraftRepository aircraftRepository, DatabaseContext db, IMapper mapper)
        {
            _aircraftRepository = aircraftRepository;
            _db = db;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int aircraftId)
        {
            var aircraft = await _aircraftRepository.GetById(aircraftId);
 
            ViewData["MainMenu"] = AircraftMainMenu.Items.OrderByDescending(i => i.SubMenu.Count() > 0).ThenBy(i => i.Header).ToList();
            ViewData["Aircraft"] = aircraft;
            ViewData["Operator"] = await _db.Operators.FirstOrDefaultAsync();
            return View();
        }
    }
}