using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLayer.Views;

namespace BusinessLayer.Repositiry.Interfaces
{
	public interface IStockCalculator
	{
		Task CalculateStock(List<ComponentView> components, List<int> storeId);
	}
}