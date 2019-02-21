using Entity.Models.Dictionaries;
using Entity.Models.General;
using Microsoft.EntityFrameworkCore;
using AccessoryDescription = Entity.Models.AccessoryDescription;
using AGWCategorie = Entity.Models.AGWCategorie;
using Aircraft = Entity.Models.Aircraft;
using Component = Entity.Models.Component;
using Department = Entity.Models.Department;
using Document = Entity.Models.Document;
using DocumentSubType = Entity.Models.DocumentSubType;
using Location = Entity.Models.Location;
using LocationsType = Entity.Models.LocationsType;
using Nomenclature = Entity.Models.Nomenclature;
using ServiceType = Entity.Models.ServiceType;
using Specialist = Entity.Models.Specialist;
using Specialization = Entity.Models.Specialization;

namespace Entity.Infrastructure
{
	public sealed class DatabaseContext : DbContext
	{
        #region Dictionaries

        public DbSet<AccessoryDescription> AccessoryDescriptions { get; set; }
        public DbSet<AGWCategorie> AgwCategories { get; set; }
        public DbSet<AircraftOtherParameter> AircraftOtherParameters { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<AirportCode> AirportCodes { get; set; }
        public DbSet<ATAChapter> AtaChapters { get; set; }
        public DbSet<CruiseLevel> CruiseLevels { get; set; }
        public DbSet<DamageChart> DamageCharts { get; set; }
        public DbSet<DefferedCategorie> DefferedCategories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DocumentSubType> DocumentSubTypes { get; set; }
        public DbSet<EmployeeSubject> EmployeeSubjects { get; set; }
        public DbSet<EventCategorie> EventCategories { get; set; }
        public DbSet<EventClass> EventClasses { get; set; }
        public DbSet<FlightNum> FlightNums { get; set; }
        public DbSet<GoodStandart> GoodStandarts { get; set; }
        public DbSet<LicenseRemarkRight> LicenseRemarkRights { get; set; }
        public DbSet<LifeLimitCategorie> LifeLimitCategories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<LocationsType> LocationsTypes { get; set; }
        public DbSet<Nomenclature> Nomenclatures { get; set; }
        public DbSet<NonRoutineJob> NonRoutineJobs { get; set; }
        public DbSet<Reason> Reasons { get; set; }
        public DbSet<Restriction> Restrictions { get; set; }
        public DbSet<SchedulePeriod> SchedulePeriods { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<TripNames> TripNameses { get; set; }

        #endregion

        #region General

        public DbSet<AccessoryRequired> AccessoryRequireds { get; set; }
        public DbSet<ActualStateRecord> ActualStateRecords { get; set; }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<AircraftEquipment> AircraftEquipments { get; set; }
        public DbSet<AircraftFlight> AircraftFlights { get; set; }
        public DbSet<AircraftWorkerCategory> AircraftWorkerCategories { get; set; }
        public DbSet<ATLB> Atlbs { get; set; }
        public DbSet<AttachedFile> AttachedFiles { get; set; }
        public DbSet<Audit> Audits { get; set; }
        public DbSet<AuditRecord> AuditRecords { get; set; }
        public DbSet<CategoryRecord> CategoryRecords { get; set; }
        public DbSet<CertificateOfReleaseToService> CertificateOfReleaseToServices { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<ComponentDirective> ComponentDirectives { get; set; }
        public DbSet<ComponentLLPCategoryChangeRecord> ComponentLlpCategoryChangeRecords { get; set; }
        public DbSet<ComponentLLPCategoryData> ComponentLlpCategoryDatas { get; set; }
        public DbSet<ComponentOilCondition> ComponentOilConditions { get; set; }
        public DbSet<ComponentWorkInRegimeParam> ComponentWorkInRegimeParams { get; set; }
        public DbSet<CorrectiveAction> CorrectiveActions { get; set; }
        public DbSet<DamageDocument> DamageDocuments { get; set; }
        public DbSet<DamageSector> DamageSectors { get; set; }
        public DbSet<Directive> Directives { get; set; }
        public DbSet<DirectiveRecord> DirectiveRecords { get; set; }
        public DbSet<Discrepancy> Discrepancies { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<EngineAccelerationTime> EngineAccelerationTimes { get; set; }
        public DbSet<EngineCondition> EngineConditions { get; set; }
        public DbSet<EngineTimeInRegime> EngineTimeInRegimes { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventCondition> EventConditions { get; set; }
        public DbSet<EventTypeRiskLevelChangeRecord> EventTypeRiskLevelChangeRecords { get; set; }
        public DbSet<FlightCargoRecord> FlightCargoRecords { get; set; }
        public DbSet<FlightCrewRecord> FlightCrewRecords { get; set; }
        public DbSet<FlightNumber> FlightNumbers { get; set; }
        public DbSet<FlightNumberAircraftModelRelation> FlightNumberAircraftModelRelations { get; set; }
        public DbSet<FlightNumberAirportRelation> FlightNumberAirportRelations { get; set; }
        public DbSet<FlightNumberCrewRecord> FlightNumberCrewRecords { get; set; }
        public DbSet<FlightNumberPeriod> FlightNumberPeriods { get; set; }
        public DbSet<FlightPassengerRecord> FlightPassengerRecords { get; set; }
        public DbSet<FlightPlanOps> FlightPlanOpses { get; set; }
        public DbSet<FlightPlanOpsRecords> FlightPlanOpsRecordses { get; set; }
        public DbSet<FlightTrack> FlightTracks { get; set; }
        public DbSet<FlightTrackRecord> FlightTrackRecords { get; set; }
        public DbSet<Hangar> Hangars { get; set; }
        public DbSet<HydraulicCondition> HydraulicConditions { get; set; }
        public DbSet<InitialOrder> InitialOrders { get; set; }
        public DbSet<InitialOrderRecord> InitialOrderRecords { get; set; }
        public DbSet<ItemFileLink> ItemFileLinks { get; set; }
        public DbSet<ItemsRelation> ItemsRelations { get; set; }
        public DbSet<JobCard> JobCards { get; set; }
        public DbSet<JobCardTask> JobCardTasks { get; set; }
        public DbSet<KitSuppliersRelation> KitSuppliersRelations { get; set; }
        public DbSet<KnowledgeModule> KnowledgeModules { get; set; }
        public DbSet<LandingGearCondition> LandingGearConditions { get; set; }
        public DbSet<MaintenanceCheck> MaintenanceChecks { get; set; }
        public DbSet<MaintenanceCheckBindTaskRecord> MaintenanceCheckBindTaskRecords { get; set; }
        public DbSet<MaintenanceCheckType> MaintenanceCheckTypes { get; set; }
        public DbSet<MaintenanceDirective> MaintenanceDirectives { get; set; }
        public DbSet<MaintenanceProgramChangeRecord> MaintenanceProgramChangeRecords { get; set; }
        public DbSet<ModuleRecord> ModuleRecords { get; set; }
        public DbSet<MTOPCheck> MtopChecks { get; set; }
        public DbSet<MTOPCheckRecord> MtopCheckRecords { get; set; }
        public DbSet<Operator> Operators { get; set; }
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<ProcedureDocumentReference> ProcedureDocumentReferences { get; set; }
        public DbSet<ProductCost> ProductCosts { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<PurchaseRequestRecord> PurchaseRequestRecords { get; set; }
        public DbSet<QuotationCost> QuotationCosts { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestForQuotation> RequestForQuotations { get; set; }
        public DbSet<RequestForQuotationRecord> RequestForQuotationRecords { get; set; }
        public DbSet<RequestRecord> RequestRecords { get; set; }
        public DbSet<RunUp> RunUps { get; set; }
        public DbSet<SmsEventType> SmsEventTypes { get; set; }
        public DbSet<Specialist> Specialists { get; set; }
        public DbSet<SpecialistCAA> SpecialistCaas { get; set; }
        public DbSet<SpecialistInstrumentRating> SpecialistInstrumentRatings { get; set; }
        public DbSet<SpecialistLicense> SpecialistLicenses { get; set; }
        public DbSet<SpecialistLicenseDetail> SpecialistLicenseDetails { get; set; }
        public DbSet<SpecialistLicenseRating> SpecialistLicenseRatings { get; set; }
        public DbSet<SpecialistLicenseRemark> SpecialistLicenseRemarks { get; set; }
        public DbSet<SpecialistMedicalRecord> SpecialistMedicalRecords { get; set; }
        public DbSet<SpecialistTraining> SpecialistTrainings { get; set; }
        public DbSet<StockComponentInfo> StockComponentInfos { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierDocument> SupplierDocuments { get; set; }
        public DbSet<TransferRecord> TransferRecords { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }
        public DbSet<WorkOrderRecord> WorkOrderRecords { get; set; }
        public DbSet<WorkPackage> WorkPackages { get; set; }
        public DbSet<WorkPackageRecord> WorkPackageRecords { get; set; }
        public DbSet<WorkPackageSpecialists> WorkPackageSpecialistses { get; set; }
        public DbSet<WorkShop> WorkShops { get; set; }

        #endregion



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