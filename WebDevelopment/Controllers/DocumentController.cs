using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLayer.Repositiry.Interfaces;
using Entity.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace WebDevelopment.Controllers
{
    public class DocumentController : Controller
    {

        private readonly DatabaseContext _db;
        private readonly IMapper _mapper;

        public DocumentController(DatabaseContext db, IMapper mapper)
        {

            _db = db;
            _mapper = mapper;
        }

        public async Task <IActionResult> Index()
        {
            return View();
        }
    }
}