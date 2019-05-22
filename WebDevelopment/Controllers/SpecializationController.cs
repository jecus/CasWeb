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
	[Route("specializations")]
	public class SpecializationController : Controller
    {
        private readonly DatabaseContext _db;

        public SpecializationController(DatabaseContext db)
        {

            _db = db;
        }


        public async Task<IActionResult> Index()
        {
            var specializations = await _db.Specializations
				.OnlyActive()
                .AsNoTracking()
                .Include(i => i.Department)
				.ToListAsync();
            var spec = specializations.ToBlView();

            ViewData["Specialization"] = spec;

            return View();
        }
    }
}