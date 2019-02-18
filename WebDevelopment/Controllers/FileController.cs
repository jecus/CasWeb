using System.IO;
using System.Threading.Tasks;
using Entity.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebDevelopment.Controllers
{
	public class FileController : Controller
	{
		private readonly DatabaseContext _db;

		public FileController(DatabaseContext db)
		{
			_db = db;
		}

		[HttpPost]
		public async Task<ActionResult> OpenPdf(int? fileId)
		{
			//var file = await _db.Files
			//	.AsNoTracking()
			//	.FirstOrDefaultAsync(i => i.ItemId == fileId);

			//return File(file.FileData, System.Net.Mime.MediaTypeNames.Application.Octet, file.FileName);

			var fileName = $"2.JPG";
			var filepath = $"D:\\Фото\\{fileName}";
			byte[] fileBytes = System.IO.File.ReadAllBytes(filepath);
			return File(fileBytes, "application/x-msdownload", fileName);
		}
	}
}