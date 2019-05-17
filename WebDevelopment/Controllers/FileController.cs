using System;
using System.IO;
using System.Threading.Tasks;
using Entity.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDevelopment.Helper;
using WebDevelopment.Infrastructude.JWT;

namespace WebDevelopment.Controllers
{
	[Auth(Roles.Sender)]
	public class FileController : Controller
	{
		private readonly DatabaseContext _db;

		public FileController(DatabaseContext db)
		{
			_db = db;
		}

		[HttpGet]
		public async Task<ActionResult> OpenPdf(int? fileId)
		{
			var file = await _db.AttachedFiles
				.AsNoTracking()
				.FirstOrDefaultAsync(i => i.Id == fileId);

			return File(file.FileData, System.Net.Mime.MediaTypeNames.Application.Pdf, file.FileName);
		}
	}
}