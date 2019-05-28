using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLayer.Views;

namespace BusinessLayer.Repositiry.Interfaces
{
	public interface IWorkPackageRepository
	{
		Task<List<WorkPackageView>> GetWorkPackages(int aircraftId);
	}
}