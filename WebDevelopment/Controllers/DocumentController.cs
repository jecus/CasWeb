using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLayer.Mapping;
using BusinessLayer.Views;
using Entity.Extentions;
using Entity.Infrastructure;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebDevelopment.Controllers
{
    public class DocumentController : Controller
    {

        private readonly DatabaseContext _db;
        private readonly IMapper _mapper;

        public DocumentController(DatabaseContext db, IMapper mapper)
        {

            _db = db;
            _mapper = mapper;
        }

        public async Task <IActionResult> Index()
        {
            var documents = await _db.Documents
                .OnlyActive()
                .AsNoTracking()
                //.Include(i => i.DocumentSubType)
                //.Include(i => i.Supplier)
                //.Include(i => i.ResponsibleOccupation)
                //.Include(i => i.Nomenсlature)
                //.Include(i => i.ServiceType)
                //.Include(i => i.Department)
                //.Include(i => i.Location)
                .ToListAsync();
            var doc = _mapper.MapToBlView<Document, DocumentView>(documents).ToList();

            ViewData["Documents"] = doc;

            return View();
        }
    }
}