using System.Threading.Tasks;
using BusinessLayer.Repositiry.Interfaces;
using Entity.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using WebDevelopment.Helper;
using WebDevelopment.Infrastructude.JWT;

namespace WebDevelopment.Controllers
{
	[Auth(Roles.Sender)]
	public class ProductController : Controller
    {
	    private readonly IProductRepository _productRepository;
	    private readonly DatabaseContext _db;

		public ProductController(IProductRepository productRepository,DatabaseContext db)
		{
			_productRepository = productRepository;
			_db = db;
		}

		[HttpGet("product")]
		public async Task<IActionResult> GetAllProducts()
		{
			var equip = await _productRepository.GetAllEquipment();
			ViewData["EquipmentAndMaterials"] = equip;

			return View();
		}

		[HttpGet("component-model")]
		public async Task<IActionResult> GetAllModels()
		{
			var mod = await _productRepository.GetAllComponentModel();
			ViewData["ComponentModels"] = mod;

			return View();
		}

		public async Task<IActionResult> GetAll()
		{
			var res = await _productRepository.GetAll();
			ViewData["All"] = res;

			return View();
		}
	}
}