using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.Repositiry.Interfaces;
using BusinessLayer.Views;
using Entity.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDevelopment.Helper;
using WebDevelopment.Infrastructude;
using WebDevelopment.Infrastructude.JWT;
using WebDevelopment.Models;

namespace WebDevelopment.Controllers
{
	[Auth(Roles.Sender)]
	[AircraftRoute("atlb")]
    public class ATLBController : Controller
    {
	    private readonly IAtlbRepository _atlbRepository;
	    private readonly DatabaseContext _db;

        public ATLBController(IAtlbRepository atlbRepository,DatabaseContext db)
        {
	        _atlbRepository = atlbRepository;
	        _db = db;
        }

		public async Task<IActionResult> Index([FromRoute]int aircraftId)
		{
			var view = await _atlbRepository.GetAircraftAtlbs(aircraftId);
			return View(view);
		}

		[Route("atlbevent")]
		public async Task<IActionResult> AtlbEvent([FromRoute]int aircraftId)
        {
	        var view = await _atlbRepository.GetAircraftAtlbs(aircraftId, 0);
	        return View(view);
        }

		[Route("edit")]
        public async Task<IActionResult> ModalEdit(int atlbId)
        {
	        var view = await _atlbRepository.GetById(atlbId);
            return PartialView("Modal", view);
        }

        [Route("create")]
        public async Task<IActionResult> ModalCreate()
        {
	        return PartialView("Modal", new ATLBView());
        }

		[HttpPost]
        public async Task<IActionResult> Create(ATLBView view)
        {
            await _db.SaveAsync(view.ToEntity());
            return RedirectToAction("Index", new {aircraftId = GlobalObject.AircraftId });
        }

        [Route("confirm")]
		public async Task<IActionResult> ConfirmDelete(int atlbId)
		{
			return PartialView("Modals/ConfirmDeleteModal", new ModalDeleteView("ATLB", "Delete", atlbId));
		}

		[HttpPost("delete")]
		public async Task<IActionResult> Delete(int id)
		{
			var atlb = await _db.Atlbs.AsNoTracking().FirstOrDefaultAsync(i => i.Id == id);
			await _db.Delete(atlb);
			return RedirectToAction("Index", new { aircraftId = GlobalObject.AircraftId });
		}
	}
}