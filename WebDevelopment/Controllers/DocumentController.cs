using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using Entity.Extentions;
using Entity.Infrastructure;
using Entity.Models.General;
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

        public async Task<IActionResult> Modal(int id)
        {
            var specialization = await _db.Specializations
                .AsNoTracking()
                .OnlyActive()
                .ToListAsync();

            var documentSubTypes = await _db.DocumentSubTypes
                .AsNoTracking()
                .OnlyActive()
                .ToListAsync();

            var suppliers = await _db.Suppliers
                .AsNoTracking()
                .OnlyActive()
                .ToListAsync();

            var serviceTypes = await _db.ServiceTypes
                .AsNoTracking()
                .OnlyActive()
                .ToListAsync();

            var nomenclatures = await _db.Nomenclatures
                .AsNoTracking()
                .OnlyActive()
                .ToListAsync();

            var departments = await _db.Departments
                .AsNoTracking()
                .OnlyActive()
                .ToListAsync();

            var locations = await _db.Locations
                .AsNoTracking()
                .OnlyActive()
                .ToListAsync();

            ViewData["Specialization"] = specialization.ToBlView();
            ViewData["DocumentSubTypes"] = documentSubTypes.ToBlView();
            ViewData["Suppliers"] = suppliers.ToBlView();
            ViewData["ServiceTypes"] = serviceTypes.ToBlView();
            ViewData["Nomenclatures"] = nomenclatures.ToBlView();
            ViewData["Departments"] = departments.ToBlView();
            ViewData["Locations"] = locations.ToBlView();
            var d = await _db.Documents
                .Include(i => i.DocumentSubType)
                .Include(i => i.Supplier)
                .Include(i => i.ResponsibleOccupation)
                .Include(i => i.Nomenсlature)
                .Include(i => i.ServiceType)
                .Include(i => i.Department)
                .Include(i => i.Location)
                .FirstOrDefaultAsync(sp => sp.ItemId == id);
            return PartialView(d.ToBlView());
        }

	}
}