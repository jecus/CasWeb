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
	public class OrderController : Controller
    {
	    private readonly DatabaseContext _db;

	    public OrderController(DatabaseContext db)
	    {

		    _db = db;
	    }

		[HttpGet("initial")]
		public async Task<IActionResult> Initial()
        {
			var initial = await _db.InitialOrders
				.OnlyActive()
				.AsNoTracking()
				.ToListAsync();
			var init = initial.ToBlView();

			ViewData["InitialOrders"] = init;

			return View();
		}

		[HttpGet("quotation")]
		public async Task<IActionResult> Quotation()
		{
			var quotation = await _db.RequestForQuotations
				.OnlyActive()
				.AsNoTracking()
				.ToListAsync();
			var quot = quotation.ToBlView();

			ViewData["RequestForQuotations"] = quot;

			return View();
		}

		[HttpGet("purchase")]
		public async Task<IActionResult> Purchase()
		{
			var purchase = await _db.PurchaseOrders
				.OnlyActive()
				.AsNoTracking()
				.ToListAsync();
			var purch = purchase.ToBlView();

			ViewData["PurchaseOrders"] = purch;

			return View();
		}
	}
}