using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLayer.Mapping;
using BusinessLayer.Views;
using Entity.Extentions;
using Entity.Infrastructure;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebDevelopment.Controllers
{
    public class SpecialistController : Controller
    {
        private readonly DatabaseContext _db;
        private readonly IMapper _mapper;

        public SpecialistController(DatabaseContext db, IMapper mapper)
        {

            _db = db;
            _mapper = mapper;
        }


        public async Task<IActionResult> Index()
        {
            var specialists = await _db.Specialists
                .OnlyActive()
                .AsNoTracking()
                .Include(i => i.AGWCategory)
                .Include(i => i.Facility)
                .Include(i => i.Specialization)
                .ThenInclude(i => i.Department)
                .ToListAsync();
            var spec = _mapper.MapToBlView<Specialist, SpecialistView>(specialists).ToList();

            ViewData["Specialists"] = spec;

            return View();
        }
    }
}