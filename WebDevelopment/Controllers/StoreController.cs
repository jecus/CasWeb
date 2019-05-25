using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.Repositiry.Interfaces;
using BusinessLayer.Views;
using Entity.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDevelopment.Helper;
using WebDevelopment.Infrastructude.JWT;

namespace WebDevelopment.Controllers
{
	[Auth(Roles.Sender)]
	[Route("store")]
	public class StoreController : Controller
    {
        private readonly DatabaseContext _db;
        private readonly IComponentRepository _componentRepository;

        public StoreController(DatabaseContext db, IComponentRepository componentRepository)
        {
            _db = db;
            _componentRepository = componentRepository;
        }

        [HttpGet("inventory")]
		public async Task <IActionResult> Inventory()
        {
            var result = await _componentRepository.GetAllStoreComponent();
            ViewData["Components"] = result.Where(i => i.ParentStore != null).ToList();

            return View(); 
        }

		[HttpGet("{storeId}")]
        public async Task<IActionResult> Index(int storeId)
        {
	        var result = await _componentRepository.GetStoreComponent(storeId);
	        ViewData["Components"] = result.Where(i => i.ParentStore != null).ToList();
	        ViewData["Store"] = _db.Stores.FirstOrDefault(i => i.Id == storeId).ToBlView();

	        return View();
        }
	}
}