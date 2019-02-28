using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Dictionaties;
using BusinessLayer.Repositiry.Interfaces;
using BusinessLayer.Views;
using Entity.Infrastructure;
using Entity.Models.General;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Repositiry
{
	public class StockCalculator : IStockCalculator
	{
		private readonly DatabaseContext _db;

		public StockCalculator(DatabaseContext db)
		{
			_db = db;
		}

		public async Task CalculateStock(List<ComponentView> components, List<int> storeId)
		{
			var allShouldBe = await _db.StockComponentInfos.Where(i => storeId.Contains(i.StoreID.Value)).ToListAsync();
			foreach (var stock in allShouldBe)
			{
				var goodClass = stock.ComponentClass.HasValue ? GoodsClass.GetItemById(stock.ComponentClass.Value) : GoodsClass.Unknown;

				var currentStock = components.Where(t => t.GoodsClass == goodClass &&
					                      t.PartNumber.Replace(" ", "").ToLower() ==
					                      stock.PartNumber.Replace(" ", "").ToLower()).ToArray();

				if (!currentStock.Any())
					continue;
				var current = currentStock.Sum(component => component.Quantity <= 0 ? 1 : component.Quantity);

				foreach (var t in currentStock)
				{
					t.Current = current;
					t.ShouldBeOnStock = stock.Amount;
				}
			}
		}
	}
}