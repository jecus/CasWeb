using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Repositiry.Interfaces;
using Entity.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace WebDevelopment.Controllers
{
    public class StoreController : Controller
    {
        private readonly DatabaseContext _db;
        private readonly IComponentRepository _componentRepository;

        public StoreController(DatabaseContext db, IComponentRepository componentRepository)
        {
            _db = db;
            _componentRepository = componentRepository;
        }

        public async Task <IActionResult> Index()
        {
      
            var result = await _componentRepository.GetAllStoreComponent();
            ViewData["Components"] = result.Where(i => i.ParentStore != null).ToList();

            return View(); 
        }
    }
}