using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLayer.Repositiry.Interfaces;
using BusinessLayer.Views;
using Entity.Extentions;
using Entity.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Repositiry
{
	public class ProductRepository : IProductRepository
	{
		private readonly DatabaseContext _db;

		public ProductRepository(DatabaseContext db)
		{
			_db = db;
		}


		public async Task<List<ProductView>> GetAllEquipment()
		{
			var equipment = await _db.Products
				.Include(i => i.GoodStandart)
				.Include(i => i.ATAChapter)
				.OnlyActive()
				.AsNoTracking()
				.ToListAsync();
			var equip = equipment.ToBlView();
			return equip;
		}

		public async Task<List<ComponentModelView>> GetAllComponentModel()
		{
			var model = await _db.ComponentModels
				.Include(i => i.GoodStandart)
				.Include(i => i.ATAChapter)
				.OnlyActive()
				.AsNoTracking()
				.ToListAsync();
			var mod = model.ToBlView();

			return mod;
		}

		public async Task<List<IProductView>> GetAll()
		{
			var res = new List<IProductView>();
			res.AddRange(await GetAllEquipment());
			res.AddRange(await GetAllComponentModel());

			return res;
		}
	}
}