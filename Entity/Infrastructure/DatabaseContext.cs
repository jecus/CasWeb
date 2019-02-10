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
		public DbSet<AccessoryDescription> AccessoryDescriptions { get; set; }
		public DbSet<Component> Components { get; set; }
		public DbSet<TransferRecord> TransferRecords { get; set; }

		public DatabaseContext(DbContextOptions<DatabaseContext> opt):base(opt)
		{
			Database.SetCommandTimeout(610);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Aircraft>()
				.HasOne(a => a.Model)
				.WithMany(b => b.Aircrafts)
				.HasForeignKey(b => b.ModelId);

			modelBuilder.Entity<Component>()
				.HasOne(a => a.Model)
				.WithMany(b => b.Components)
				.HasForeignKey(b => b.ModelId);

			modelBuilder.Entity<Component>()
				.HasMany(a => a.TransferRecords)
				.WithOne(b => b.Component)
				.HasForeignKey(b => b.ParentID);
		}
	}
}