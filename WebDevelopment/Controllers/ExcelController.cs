using System;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;

namespace WebDevelopment.Controllers
{
	public class ExcelController : Controller
	{
		[HttpPost]
		public ActionResult ExcelExport(string contentType, string base64, string fileName)
		{
			var fileContents = Convert.FromBase64String(base64);
			return File(fileContents, contentType, fileName);
		}
	}
}