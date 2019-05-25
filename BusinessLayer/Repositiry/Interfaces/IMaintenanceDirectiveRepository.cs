using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLayer.Views;

namespace BusinessLayer.Repositiry.Interfaces
{
	public interface IMaintenanceDirectiveRepository
	{
		Task<List<MaintenanceDirectiveView>> GetMaintenanceDirective(int aircraftId);
	}
}