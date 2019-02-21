using System.Threading.Tasks;
using BusinessLayer.Repositiry.Interfaces;
using BusinessLayer.Views;
using Entity.Extentions;
using Entity.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Repositiry
{
	public class UserRepository : IUserRepository
	{
		private readonly DatabaseContext _db;

		public UserRepository(DatabaseContext databaseContext)
		{
			_db = databaseContext;
		}

		public async Task<UserView> GetUserByLoginPassword(string login, string password)
		{
			var user = await _db.Users
				.AsNoTracking()
				.OnlyActive()
				.FirstOrDefaultAsync(i => i.Login == login && i.Password == password);
			return user.ToBlView();
		}

		public async Task<bool> IsAuthorized(string login, string password)
		{
			var user = await _db.Users
				.AsNoTracking()
				.FirstOrDefaultAsync(i => i.Login == login && i.Password == password);
			return user != null;
		}
	}
}