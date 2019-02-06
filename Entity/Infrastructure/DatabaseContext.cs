using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Entity.Infrastructure
{
	public sealed class DatabaseContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Aircraft> Aircrafts { get; set; }
		public DbSet<Store> Stores { get; set; }
		public DbSet<Document> Documents { get; set; }
		public DbSet<Operator> Operators { get; set; }

		public DatabaseContext(DbContextOptions<DatabaseContext> opt):base(opt)
		{
			Database.SetCommandTimeout(610);
		}
	}
}