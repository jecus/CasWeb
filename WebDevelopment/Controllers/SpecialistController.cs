using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using Entity.Extentions;
using Entity.Infrastructure;
using Entity.Models.General;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDevelopment.Helper;
using WebDevelopment.Infrastructude.JWT;

namespace WebDevelopment.Controllers
{
	[Auth(Roles.Sender)]
	public class SpecialistController : Controller
    {
        private readonly DatabaseContext _db;

        public SpecialistController(DatabaseContext db)
        {

            _db = db;
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
            var spec = specialists.ToBlView();

            ViewData["Specialists"] = spec;

            return View();
        }

        public IActionResult Details(int id)
        {
            Specialist c = _db.Specialists.FirstOrDefault(sp => sp.Id == id);
            return PartialView(c);
        }
    }
}