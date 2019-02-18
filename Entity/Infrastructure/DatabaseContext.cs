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
		public DbSet<DocumentSubType> DocumentSubTypes { get; set; }
		public DbSet<Supplier> Suppliers { get; set; }
		public DbSet<Specialization> Specializations { get; set; }
		public DbSet<Nomenclature> Nomenclatures { get; set; }
		public DbSet<ServiceType> ServiceTypes { get; set; }
		public DbSet<Department> Departments { get; set; }
		public DbSet<Location> Locations { get; set; }
		public DbSet<ItemFileLink> ItemFileLinks { get; set; }
		public DbSet<AttachedFile> Files { get; set; }
		public DbSet<LocationsType> LcoaLocationsTypes { get; set; }

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
			
            modelBuilder.Entity<Document>()
                .HasOne(a => a.DocumentSubType)
                .WithMany(b => b.Documents)
                .HasForeignKey(b => b.SubTypeId);

            modelBuilder.Entity<Document>()
                .HasOne(a => a.Supplier)
                .WithMany(b => b.Documents)
                .HasForeignKey(b => b.SupplierId);

            modelBuilder.Entity<Document>()
                .HasOne(a => a.ResponsibleOccupation)
                .WithMany(b => b.Documents)
                .HasForeignKey(b => b.ResponsibleOccupationId);

            modelBuilder.Entity<Document>()
                .HasOne(a => a.Nomenсlature)
                .WithMany(b => b.Documents)
                .HasForeignKey(b => b.NomenсlatureId);

            modelBuilder.Entity<Document>()
                .HasOne(a => a.ServiceType)
                .WithMany(b => b.Documents)
                .HasForeignKey(b => b.ServiceTypeId);

            modelBuilder.Entity<Document>()
                .HasOne(a => a.Department)
                .WithMany(b => b.Documents)
                .HasForeignKey(b => b.DepartmentId);

            modelBuilder.Entity<Document>()
                .HasOne(a => a.Location)
                .WithMany(b => b.Documents)
                .HasForeignKey(b => b.LocationId);

            modelBuilder.Entity<Specialist>()
                .HasOne(a => a.AGWCategory)
                .WithMany(b => b.Specialists)
                .HasForeignKey(b => b.AGWCategoryId);

            modelBuilder.Entity<Specialist>()
                .HasOne(a => a.Facility)
                .WithMany(b => b.Specialists)
                .HasForeignKey(b => b.Location);

            modelBuilder.Entity<Specialist>()
                .HasOne(a => a.Specialization)
                .WithMany(b => b.Specialists)
                .HasForeignKey(b => b.SpecializationID);

            modelBuilder.Entity<Specialization>()
                .HasOne(a => a.Department)
                .WithMany(b => b.Specializations)
                .HasForeignKey(b => b.DepartmentId);
        }
	}
}