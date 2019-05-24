using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLayer.Views;

namespace BusinessLayer.Repositiry.Interfaces
{
	public interface IAtlbRepository
	{
		Task<List<ATLBView>> GetAircraftAtlbs(int aircraftId);
		Task<ATLBView> GetById(int atlbId);
	}
}