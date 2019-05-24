using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLayer.Views;

namespace BusinessLayer.Repositiry.Interfaces
{
	public interface IProductRepository
	{
		Task<List<ProductView>> GetAllEquipment();
		Task<List<ComponentModelView>> GetAllComponentModel();
		Task<List<IProductView>> GetAll();
	}
}