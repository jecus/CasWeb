using System.Threading.Tasks;
using AutoMapper;
using BusinessLayer.Mapping;
using BusinessLayer.Repositiry.Interfaces;
using BusinessLayer.Views;
using Entity.Extentions;
using Entity.Infrastructure;
using Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Repositiry
{
	public class UserRepository : IUserRepository
	{
		private readonly DatabaseContext _db;
		private readonly IMapper _mapper;

		public UserRepository(IMapper mapper, DatabaseContext databaseContext)
		{
			_mapper = mapper;
			_db = databaseContext;
		}

		public async Task<UserView> GetUserByLoginPassword(string login, string password)
		{
			var user = await _db.Users
				.AsNoTracking()
				.OnlyActive()
				.FirstOrDefaultAsync(i => i.Login == login && i.Password == password);
			return _mapper.MapToBlView<User, UserView>(user);
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