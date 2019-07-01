using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using BusinessLayer.Views;
using Entity.Models.General;

namespace BusinessLayer.Repositiry.Interfaces
{
    public interface IComponentRepository
    {
	    Task<List<ComponentView>> GetComponentsByBaseComponentIds(IEnumerable<int> baseComponentIds);

		Task<List<int>> GetAircraftBaseComponentIds(int aircraftId);

		Task<List<BaseComponentView>> GetAircraftBaseComponents(int aircraftId);

		Task<List<ComponentView>> GetAllStoreComponent();
        Task<List<ComponentView>> GetStoreComponent(int storeId);
    }
}