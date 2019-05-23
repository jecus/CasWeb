using System;
using System.Collections.Generic;
using System.Linq;
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
	public class PurchaseController : Controller
    {
	    private readonly DatabaseContext _db;

	    public PurchaseController(DatabaseContext db)
	    {

		    _db = db;
	    }

	    [HttpGet("supplier")]
	    public async Task<IActionResult> Suppliers()
	    {
		    var supplier = await _db.Suppliers
			    .OnlyActive()
			    .AsNoTracking()
			    .ToListAsync();
		    var supp = supplier.ToBlView();

		    ViewData["Suppliers"] = supp;

		    return View();
	    }
	}
}