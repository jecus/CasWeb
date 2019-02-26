using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLayer.Views;

namespace BusinessLayer.Repositiry.Interfaces
{
    public interface IComponentRepository
    {
        Task<List<ComponentView>> GetAllStoreComponent();
    }
}