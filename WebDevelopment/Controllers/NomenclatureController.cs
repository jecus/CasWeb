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
	[Route("nomenclatures")]
	public class NomenclatureController : Controller
	{
		private readonly DatabaseContext _db;

		public NomenclatureController(DatabaseContext db)
		{
			_db = db;
		}

		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var nomenclatures = await _db.Nomenclatures
				.Include(i => i.Department)
				.AsNoTracking()
				.OnlyActive()
				.ToListAsync();

			var res = nomenclatures.ToBlView();
			ViewData["Nomenclatures"] = res;
			return View();
		}
	}
}