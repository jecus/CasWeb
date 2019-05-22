using System.Threading.Tasks;
using BusinessLayer;
using Entity.Extentions;
using Entity.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDevelopment.Helper;
using WebDevelopment.Infrastructude.JWT;

namespace WebDevelopment.Controllers
{
	[Auth(Roles.Sender)]
	[Route("departments")]
	public class DepartmentController : Controller
	{
		private readonly DatabaseContext _db;

		public DepartmentController(DatabaseContext db)
		{
			_db = db;
		}

		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var departments = await _db.Departments
				.AsNoTracking()
				.OnlyActive()
				.ToListAsync();

			var res = departments.ToBlView();
			ViewData["Departments"] = res;
			return View();
		}
	}
}