using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using Entity.Extentions;
using Entity.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebDevelopment.Controllers
{
    public class DocumentController : Controller
    {

        private readonly DatabaseContext _db;

        public DocumentController(DatabaseContext db)
        {
            _db = db;
        }

        public async Task <IActionResult> Index()
        {
            var documents = await _db.Documents
                .OnlyActive()
                .AsNoTracking()
				.Include(i => i.DocumentSubType)
				.Include(i => i.Supplier)
				.Include(i => i.ResponsibleOccupation)
				.Include(i => i.Nomenсlature)
				.Include(i => i.ServiceType)
				.Include(i => i.Department)
				.Include(i => i.Location)
				.ToListAsync();


            var docIds = documents.Select(i => i.ItemId);
            var fileLinks = await _db.ItemFileLinks
	            .AsNoTracking()
	            .Where(i => i.ParentTypeId == 1275 && docIds.Contains(i.ParentId))
	            .ToListAsync();

            var doc = documents.ToBlView();

            foreach (var documentView in doc)
	            documentView.ItemFileLink = fileLinks.FirstOrDefault(i => i.ParentId == documentView.ItemId);

            ViewData["Documents"] = doc;

            return View();
        }

        public IActionResult Get(int id)
        {
	        return PartialView();
        }

	}
}