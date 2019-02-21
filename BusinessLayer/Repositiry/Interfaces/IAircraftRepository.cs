using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLayer.Views;

namespace BusinessLayer.Repositiry.Interfaces
{
	public interface IAircraftRepository
	{
		Task<AircraftView> GetById(int id);
		Task<List<AircraftView>> Get(IEnumerable<int> ids);
		Task<List<AircraftView>> GetAll();
	}
}