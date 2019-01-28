using System.Threading.Tasks;
using BusinessLayer.Views;

namespace BusinessLayer.Repositiry.Interfaces
{
	public interface IUserRepository
	{
		Task<UserView> GetUserByLoginPassword(string login, string password);

		Task<bool> IsAuthorized(string login, string password);
	}
}