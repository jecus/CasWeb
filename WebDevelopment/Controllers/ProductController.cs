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
	public class ProductController : Controller
    {
		private readonly DatabaseContext _db;

		public ProductController(DatabaseContext db)
		{

			_db = db;
		}

		[HttpGet("product")]
		public async Task<IActionResult> GetAllProducts()
		{
			var equipment = await _db.Products
				.Include(i => i.GoodStandart)
				.Include(i => i.ATAChapter)
				.OnlyActive()
				.AsNoTracking()
				.ToListAsync();
			var equip = equipment.ToBlView();

			ViewData["EquipmentAndMaterials"] = equip;

			return View();
		}

		[HttpGet("component-model")]
		public async Task<IActionResult> GetAllModels()
		{
			var model = await _db.ComponentModels
				.Include(i => i.GoodStandart)
				.Include(i => i.ATAChapter)
				.OnlyActive()
				.AsNoTracking()
				.ToListAsync();
			var mod = model.ToBlView();

			ViewData["ComponentModels"] = mod;

			return View();
		}
	}
}