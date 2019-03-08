using System.Threading.Tasks;
using Entity.Models.Dictionaries;
using Entity.Models.General;
using Microsoft.EntityFrameworkCore;

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
			#region AccessoryRequired

			modelBuilder.Entity<AccessoryRequired>()
				.HasOne(i => i.Product)
				.WithMany(i => i.AccessoryRequireds)
				.HasForeignKey(i => i.AccessoryDescriptionId);

			modelBuilder.Entity<AccessoryRequired>()
				.HasOne(i => i.Standart)
				.WithMany(i => i.AccessoryRequireds)
				.HasForeignKey(i => i.GoodStandartId);

			#endregion

			#region AircraftEquipment

			modelBuilder.Entity<AircraftEquipment>()
				.HasOne(i => i.AircraftOtherParameter)
				.WithMany(i => i.AircraftEquipments)
				.HasForeignKey(i => i.AircraftOtherParameterId);

			#endregion

			#region AircraftFlight

			modelBuilder.Entity<AircraftFlight>()
				.HasOne(i => i.FlightNumber)
				.WithMany(i => i.AircraftFlights)
				.HasForeignKey(i => i.FlightNumberId);

			modelBuilder.Entity<AircraftFlight>()
				.HasOne(i => i.Level)
				.WithMany(i => i.AircraftFlights)
				.HasForeignKey(i => i.LevelId);

			modelBuilder.Entity<AircraftFlight>()
				.HasOne(i => i.StationFroms)
				.WithMany(i => i.AircraftFlightsFrom)
				.HasForeignKey(i => i.StationFromId);

			modelBuilder.Entity<AircraftFlight>()
				.HasOne(i => i.StationTos)
				.WithMany(i => i.AircraftFlightsTo)
				.HasForeignKey(i => i.StationToId);


			modelBuilder.Entity<AircraftFlight>()
				.HasOne(i => i.CancelReason)
				.WithMany(i => i.AircraftFlightsCancels)
				.HasForeignKey(i => i.CancelReasonId);

			modelBuilder.Entity<AircraftFlight>()
				.HasOne(i => i.DelayReason)
				.WithMany(i => i.AircraftFlightsDelays)
				.HasForeignKey(i => i.DelayReasonId);

			//modelBuilder.Entity<AircraftFlight>()
			//	.HasMany(i => i.Files).WithOne(i => i.AircraftFlight).HasForeignKey(i => i.ParentId);

			#endregion

			#region Aircraft

			modelBuilder.Entity<Aircraft>()
				.HasOne(a => a.Model)
				.WithMany(b => b.Aircrafts)
				.HasForeignKey(b => b.ModelId);

			modelBuilder.Entity<Aircraft>()
				.HasMany(i => i.MaintenanceProgramChangeRecords).WithOne(i => i.ParentAircraft).HasForeignKey(i => i.ParentAircraftId);

			#endregion

			#region ATLB

			//modelBuilder.Entity<ATLB>()
			//	.HasMany(i => i.Files).WithOne(i => i.Atlb).HasForeignKey(i => i.ParentId);

			#endregion

			#region Audit

			//modelBuilder.Entity<Audit>()
			//	.HasMany(i => i.Files).WithOne(i => i.Audit).HasForeignKey(i => i.ParentId);
			modelBuilder.Entity<Audit>()
				.HasMany(i => i.AuditRecords).WithOne(i => i.Audit).HasForeignKey(i => i.AuditId);

			#endregion

			#region CategoryRecord

			modelBuilder.Entity<CategoryRecord>()
				.HasOne(i => i.AircraftModel)
				.WithMany(i => i.CategoryRecords)
				.HasForeignKey(i => i.AircraftTypeId);

			modelBuilder.Entity<CategoryRecord>()
				.HasOne(i => i.AircraftWorkerCategory)
				.WithMany(i => i.CategoryRecords)
				.HasForeignKey(i => i.AircraftWorkerCategoryId);

			#endregion

			#region CertificateOfReleaseToService

			modelBuilder.Entity<CertificateOfReleaseToService>()
				.HasOne(i => i.AuthorizationB1)
				.WithMany(i => i.CertificateOfReleaseToServiceB1s)
				.HasForeignKey(i => i.AuthorizationB1Id);

			modelBuilder.Entity<CertificateOfReleaseToService>()
				.HasOne(i => i.AuthorizationB2)
				.WithMany(i => i.CertificateOfReleaseToServiceB2s)
				.HasForeignKey(i => i.AuthorizationB2Id);

			#endregion

			#region ComponentDirective

			//modelBuilder.Entity<ComponentDirective>()
			//	.HasMany(i => i.Files).WithOne(i => i.ComponentDirective).HasForeignKey(i => i.ParentId);

			modelBuilder.Entity<ComponentDirective>()
				.HasMany(i => i.PerformanceRecords).WithOne(i => i.ComponentDirective).HasForeignKey(i => i.ParentID);

			modelBuilder.Entity<ComponentDirective>()
				.HasMany(i => i.Kits).WithOne(i => i.ComponentDirective).HasForeignKey(i => i.ParentId);

			modelBuilder.Entity<ComponentDirective>()
				.HasMany(i => i.CategoriesRecords).WithOne(i => i.ComponentDirective).HasForeignKey(i => i.ParentId);

			#endregion

			#region ComponentLLPCategoryChangeRecord

			modelBuilder.Entity<ComponentLLPCategoryChangeRecord>()
				.HasOne(i => i.ToCategory)
				.WithMany(i => i.CategoryChangeRecords)
				.HasForeignKey(i => i.ToCategoryId);

			//modelBuilder.Entity<ComponentLLPCategoryChangeRecord>()
			//	.HasMany(i => i.Files).WithOne(i => i.CategoryChangeRecord).HasForeignKey(i => i.ParentId);

			#endregion

			#region ComponentLLPCategoryData

			modelBuilder.Entity<ComponentLLPCategoryData>()
				.HasOne(i => i.ParentCategory)
				.WithMany(i => i.CategoryDatas)
				.HasForeignKey(i => i.LLPCategoryId);

			#endregion

			#region Component

			modelBuilder.Entity<Component>()
				.HasOne(i => i.ATAChapter)
				.WithMany(i => i.Components)
				.HasForeignKey(i => i.ATAChapterId);

			modelBuilder.Entity<Component>()
				.HasOne(i => i.Model)
				.WithMany(i => i.Components)
				.HasForeignKey(i => i.ModelId);

			modelBuilder.Entity<Component>()
				.HasOne(i => i.Location)
				.WithMany(i => i.Components)
				.HasForeignKey(i => i.LocationId);

			modelBuilder.Entity<Component>()
				.HasOne(i => i.FromSupplier)
				.WithMany(i => i.Components)
				.HasForeignKey(i => i.FromSupplierId);

			modelBuilder.Entity<Component>()
				.HasMany(i => i.SupplierRelations).WithOne(i => i.Component).HasForeignKey(i => i.KitId);

			//modelBuilder.Entity<Component>()
			//	.HasMany(i => i.Files).WithOne(i => i.Component).HasForeignKey(i => i.ParentId);

			modelBuilder.Entity<Component>()
				.HasMany(i => i.LLPData).WithOne(i => i.Component).HasForeignKey(i => i.ComponentId);

			modelBuilder.Entity<Component>()
				.HasMany(i => i.CategoriesRecords).WithOne(i => i.Component).HasForeignKey(i => i.ParentId);

			modelBuilder.Entity<Component>()
				.HasMany(i => i.Kits).WithOne(i => i.Component).HasForeignKey(i => i.ParentId);

			modelBuilder.Entity<Component>()
				.HasMany(i => i.ActualStateRecords).WithOne(i => i.Component).HasForeignKey(i => i.ComponentId);

			modelBuilder.Entity<Component>()
				.HasMany(i => i.TransferRecords).WithOne(i => i.Component).HasForeignKey(i => i.ParentID);

			modelBuilder.Entity<Component>()
				.HasMany(i => i.ComponentDirectives).WithOne(i => i.Component).HasForeignKey(i => i.ComponentId);

			modelBuilder.Entity<Component>()
				.HasMany(i => i.ChangeLLPCategoryRecords).WithOne(i => i.Component).HasForeignKey(i => i.ParentId);

			#endregion

			#region DamageDocument

			//modelBuilder.Entity<DamageDocument>()
			//	.HasMany(i => i.Files).WithOne(i => i.DamageDocument).HasForeignKey(i => i.ParentId);

			modelBuilder.Entity<DamageDocument>()
				.HasMany(i => i.DamageSectors).WithOne(i => i.DamageDocument).HasForeignKey(i => i.DamageDocumentId);

			#endregion

			#region Directive

			modelBuilder.Entity<Directive>()
				.HasOne(i => i.ATAChapter)
				.WithMany(i => i.Directives)
				.HasForeignKey(i => i.ATAChapterId);

			modelBuilder.Entity<Directive>()
				.HasOne(i => i.DeferredCategory)
				.WithMany(i => i.Directives)
				.HasForeignKey(i => i.DeferredCategoryId);

			modelBuilder.Entity<Directive>()
				.HasOne(i => i.BaseComponent)
				.WithMany(i => i.Directives)
				.HasForeignKey(i => i.ComponentId);

			//modelBuilder.Entity<Directive>()
			//	.HasMany(i => i.Files).WithOne(i => i.Directive).HasForeignKey(i => i.ParentId);

			modelBuilder.Entity<Directive>()
				.HasMany(i => i.DamageDocs).WithOne(i => i.Directive).HasForeignKey(i => i.DirectiveId);

			modelBuilder.Entity<Directive>()
				.HasMany(i => i.PerformanceRecords).WithOne(i => i.Directive).HasForeignKey(i => i.ParentID);

			modelBuilder.Entity<Directive>()
				.HasMany(i => i.CategoriesRecords).WithOne(i => i.Directive).HasForeignKey(i => i.ParentId);

			modelBuilder.Entity<Directive>()
				.HasMany(i => i.Kits).WithOne(i => i.Directive).HasForeignKey(i => i.ParentId);

			#endregion

			#region DirectiveRecord

			//modelBuilder.Entity<DirectiveRecord>()
			//	.HasMany(i => i.Files).WithOne(i => i.DirectiveRecord).HasForeignKey(i => i.ParentId);
			//modelBuilder.Entity<DirectiveRecord>()
			//	.HasMany(i => i.FilesForMaintenanceCheckRecord).WithOne(i => i.MaintenanceCheckRecord).HasForeignKey(i => i.ParentId);

			#endregion

			#region Discrepancy

			modelBuilder.Entity<Discrepancy>()
				.HasOne(i => i.ATAChapter)
				.WithMany(i => i.Discrepancys)
				.HasForeignKey(i => i.ATAChapterID);

			modelBuilder.Entity<Discrepancy>()
				.HasOne(i => i.Auth)
				.WithMany(i => i.Discrepancys)
				.HasForeignKey(i => i.AuthId);

			#endregion

			#region Document

			modelBuilder.Entity<Document>()
				.HasOne(i => i.DocumentSubType)
				.WithMany(i => i.Documents)
				.HasForeignKey(i => i.SubTypeId);

			modelBuilder.Entity<Document>()
				.HasOne(i => i.Supplier)
				.WithMany(i => i.Documents)
				.HasForeignKey(i => i.SupplierId);

			modelBuilder.Entity<Document>()
				.HasOne(i => i.ResponsibleOccupation)
				.WithMany(i => i.Documents)
				.HasForeignKey(i => i.ResponsibleOccupationId);

			modelBuilder.Entity<Document>()
				.HasOne(i => i.Nomenсlature)
				.WithMany(i => i.Documents)
				.HasForeignKey(i => i.NomenсlatureId);

			modelBuilder.Entity<Document>()
				.HasOne(i => i.ServiceType)
				.WithMany(i => i.Documents)
				.HasForeignKey(i => i.ServiceTypeId);

			modelBuilder.Entity<Document>()
				.HasOne(i => i.Department)
				.WithMany(i => i.Documents)
				.HasForeignKey(i => i.DepartmentId);

			modelBuilder.Entity<Document>()
				.HasOne(i => i.Location)
				.WithMany(i => i.Documents)
				.HasForeignKey(i => i.LocationId);

			#endregion

			#region Event

			modelBuilder.Entity<Event>()
				.HasOne(i => i.EventType)
				.WithMany(i => i.Events)
				.HasForeignKey(i => i.EventTypeId);

			modelBuilder.Entity<Event>()
				.HasOne(i => i.EventCategory)
				.WithMany(i => i.Events)
				.HasForeignKey(i => i.EventCategoryId);

			modelBuilder.Entity<Event>()
				.HasOne(i => i.EventClass)
				.WithMany(i => i.Events)
				.HasForeignKey(i => i.EventClassId);

			modelBuilder.Entity<Event>()
				.HasMany(i => i.EventConditions).WithOne(i => i.Event).HasForeignKey(i => i.ParentId);

			#endregion

			#region EventTypeRiskLevelChangeRecord

			modelBuilder.Entity<EventTypeRiskLevelChangeRecord>()
				.HasOne(i => i.EventCategory)
				.WithMany(i => i.ChangeRecords)
				.HasForeignKey(i => i.EventCategoryId);


			modelBuilder.Entity<EventTypeRiskLevelChangeRecord>()
				.HasOne(i => i.EventClass)
				.WithMany(i => i.ChangeRecords)
				.HasForeignKey(i => i.EventClassId);


			modelBuilder.Entity<EventTypeRiskLevelChangeRecord>()
				.HasOne(i => i.ParentEventType)
				.WithMany(i => i.ChangeRecords)
				.HasForeignKey(i => i.ParentId);

			#endregion

			#region FlightCrewRecord

			modelBuilder.Entity<FlightCrewRecord>()
				.HasOne(i => i.Specialist)
				.WithMany(i => i.FlightCrewRecords)
				.HasForeignKey(i => i.SpecialistID);

			modelBuilder.Entity<FlightCrewRecord>()
				.HasOne(i => i.Specialization)
				.WithMany(i => i.FlightCrewRecords)
				.HasForeignKey(i => i.SpecializationID);

			#endregion

			#region FlightNumberAircraftModelRelation

			modelBuilder.Entity<FlightNumberAircraftModelRelation>()
				.HasOne(i => i.FlightNumber)
				.WithMany(i => i.FlightNumberAircraftModelRelations)
				.HasForeignKey(i => i.FlightNumberId);

			modelBuilder.Entity<FlightNumberAircraftModelRelation>()
				.HasOne(i => i.AircraftModel)
				.WithMany(i => i.FlightNumberAircraftModelRelations)
				.HasForeignKey(i => i.AircraftModelId);

			#endregion

			#region FlightNumberAirportRelation

			modelBuilder.Entity<FlightNumberAirportRelation>()
				.HasOne(i => i.FlightNumber)
				.WithMany(i => i.AirportRelations)
				.HasForeignKey(i => i.FlightNumberId);

			modelBuilder.Entity<FlightNumberAirportRelation>()
				.HasOne(i => i.Airport)
				.WithMany(i => i.AirportRelations)
				.HasForeignKey(i => i.AirportId);

			#endregion

			#region FlightNumberCrewRecord

			modelBuilder.Entity<FlightNumberCrewRecord>()
				.HasOne(i => i.FlightNumber)
				.WithMany(i => i.FlightNumberCrewRecords)
				.HasForeignKey(i => i.FlightNumberId);

			modelBuilder.Entity<FlightNumberCrewRecord>()
				.HasOne(i => i.Specialization)
				.WithMany(i => i.FlightNumberCrewRecords)
				.HasForeignKey(i => i.SpecializationId);

			#endregion

			#region FlightNumber

			modelBuilder.Entity<FlightNumber>()
				.HasOne(i => i.StationFrom)
				.WithMany(i => i.From)
				.HasForeignKey(i => i.StationFromId);

			modelBuilder.Entity<FlightNumber>()
				.HasOne(i => i.StationTo)
				.WithMany(i => i.To)
				.HasForeignKey(i => i.StationToId);

			modelBuilder.Entity<FlightNumber>()
				.HasOne(i => i.MinLevel)
				.WithMany(i => i.FlightNumbers)
				.HasForeignKey(i => i.MinLevelId);

			modelBuilder.Entity<FlightNumber>()
				.HasOne(i => i.FlightNo)
				.WithMany(i => i.FlightNumbers)
				.HasForeignKey(i => i.FlightNoId);

			#endregion

			#region FlightPassengerRecord

			modelBuilder.Entity<FlightPassengerRecord>()
				.HasOne(i => i.PassengerCategory)
				.WithMany(i => i.FlightPassengerRecords)
				.HasForeignKey(i => i.PassengerCategoryId);

			#endregion

			#region FlightPlanOpsRecords

			modelBuilder.Entity<FlightPlanOpsRecords>()
				.HasOne(i => i.ParentFlightPlanOps)
				.WithMany(i => i.FlightPlanOpsRecords)
				.HasForeignKey(i => i.FlightPlanOpsId);

			modelBuilder.Entity<FlightPlanOpsRecords>()
				.HasOne(i => i.DelayReason)
				.WithMany(i => i.DelayFlightPlanOpsRecords)
				.HasForeignKey(i => i.DelayReasonId);

			modelBuilder.Entity<FlightPlanOpsRecords>()
				.HasOne(i => i.Reason)
				.WithMany(i => i.ReasonFlightPlanOpsRecords)
				.HasForeignKey(i => i.ReasonId);

			modelBuilder.Entity<FlightPlanOpsRecords>()
				.HasOne(i => i.CancelReason)
				.WithMany(i => i.CancelFlightPlanOpsRecords)
				.HasForeignKey(i => i.CancelReasonId);

			#endregion

			#region FlightTrack

			modelBuilder.Entity<FlightTrack>()
				.HasOne(i => i.TripName)
				.WithMany(i => i.FlightTracks)
				.HasForeignKey(i => i.TripNameId);

			modelBuilder.Entity<FlightTrack>()
				.HasOne(i => i.Supplier)
				.WithMany(i => i.FlightTracks)
				.HasForeignKey(i => i.SupplierID);

			modelBuilder.Entity<FlightTrack>()
				.HasMany(i => i.FlightTripRecord).WithOne(i => i.FlightTrack).HasForeignKey(i => i.FlightTripId);

			#endregion

			#region InitialOrder

			modelBuilder.Entity<InitialOrder>()
				.HasOne(i => i.Supplier)
				.WithMany(i => i.InitialOrders)
				.HasForeignKey(i => i.CarrierId);

			modelBuilder.Entity<InitialOrder>()
				.HasOne(i => i.ApprovedBy)
				.WithMany(i => i.Approveds)
				.HasForeignKey(i => i.ApprovedById);

			modelBuilder.Entity<InitialOrder>()
				.HasOne(i => i.PublishedBy)
				.WithMany(i => i.Publisheds)
				.HasForeignKey(i => i.PublishedById);

			modelBuilder.Entity<InitialOrder>()
				.HasOne(i => i.ClosedBy)
				.WithMany(i => i.Closeds)
				.HasForeignKey(i => i.ClosedById);


			//modelBuilder.Entity<InitialOrder>()
			//	.HasMany(i => i.Files).WithOne(i => i.InitialOrder).HasForeignKey(i => i.ParentId);
			modelBuilder.Entity<InitialOrder>()
				.HasMany(i => i.PackageRecords).WithOne(i => i.InitialOrder).HasForeignKey(i => i.ParentPackageId);

			#endregion

			#region InitialOrderRecord

			modelBuilder.Entity<InitialOrderRecord>()
				.HasOne(i => i.DeferredCategory)
				.WithMany(i => i.InitialOrderRecords)
				.HasForeignKey(i => i.DefferedCategory);

			#endregion

			#region ItemFileLink

			modelBuilder.Entity<ItemFileLink>()
				.HasOne(i => i.File)
				.WithMany(i => i.ItemFileLink)
				.HasForeignKey(i => i.FileId);

			#endregion

			#region JobCard

			modelBuilder.Entity<JobCard>()
				.HasOne(i => i.PreparedBy)
				.WithMany(i => i.PreparedJobCards)
				.HasForeignKey(i => i.PreparedById);

			modelBuilder.Entity<JobCard>()
				.HasOne(i => i.CheckedBy)
				.WithMany(i => i.CheckedJobCards)
				.HasForeignKey(i => i.CheckedById);

			modelBuilder.Entity<JobCard>()
				.HasOne(i => i.ApprovedBy)
				.WithMany(i => i.ApprovedJobCards)
				.HasForeignKey(i => i.ApprovedById);

			modelBuilder.Entity<JobCard>()
				.HasOne(i => i.AtaChapter)
				.WithMany(i => i.JobCards)
				.HasForeignKey(i => i.AtaChapterId);


			modelBuilder.Entity<JobCard>()
				.HasOne(i => i.Qualification)
				.WithMany(i => i.JobCards)
				.HasForeignKey(i => i.QualificationId);

			modelBuilder.Entity<JobCard>()
				.HasMany(i => i.Kits).WithOne(i => i.JobCard).HasForeignKey(i => i.ParentId);

			modelBuilder.Entity<JobCard>()
				.HasMany(i => i.JobCardTasks).WithOne(i => i.JobCard).HasForeignKey(i => i.JobCardId);

			#endregion

			#region KitSuppliersRelation

			modelBuilder.Entity<KitSuppliersRelation>()
				.HasOne(i => i.Supplier)
				.WithMany(i => i.KitSuppliersRelations)
				.HasForeignKey(i => i.SupplierId);

			#endregion

			#region MaintenanceCheck

			modelBuilder.Entity<MaintenanceCheck>()
				.HasOne(i => i.CheckType)
				.WithMany(i => i.MaintenanceChecks)
				.HasForeignKey(i => i.CheckTypeId);

			modelBuilder.Entity<MaintenanceCheck>()
				.HasMany(i => i.PerformanceRecords).WithOne(i => i.MaintenanceCheck).HasForeignKey(i => i.ParentID);
			modelBuilder.Entity<MaintenanceCheck>()
				.HasMany(i => i.CategoriesRecords).WithOne(i => i.MaintenanceCheck).HasForeignKey(i => i.ParentId);
			modelBuilder.Entity<MaintenanceCheck>()
				.HasMany(i => i.Kits).WithOne(i => i.MaintenanceCheck).HasForeignKey(i => i.ParentId);
			modelBuilder.Entity<MaintenanceCheck>()
				.HasMany(i => i.BindMpds).WithOne(i => i.MaintenanceCheck).HasForeignKey(i => i.MaintenanceCheckId);

			#endregion

			#region MaintenanceDirective

			modelBuilder.Entity<MaintenanceDirective>()
				.HasOne(i => i.ATAChapter)
				.WithMany(i => i.MaintenanceDirectives)
				.HasForeignKey(i => i.ATAChapterId);


			modelBuilder.Entity<MaintenanceDirective>()
				.HasOne(i => i.BaseComponent)
				.WithMany(i => i.MaintenanceDirectives)
				.HasForeignKey(i => i.ComponentId);


			modelBuilder.Entity<MaintenanceDirective>()
				.HasOne(i => i.JobCard)
				.WithMany(i => i.MaintenanceDirectives)
				.HasForeignKey(i => i.JobCardId);

			//modelBuilder.Entity<MaintenanceDirective>()
			//	.HasMany(i => i.Files).WithOne(i => i.MaintenanceDirective).HasForeignKey(i => i.ParentId);
			modelBuilder.Entity<MaintenanceDirective>()
				.HasMany(i => i.PerformanceRecords).WithOne(i => i.MaintenanceDirective).HasForeignKey(i => i.ParentID);
			modelBuilder.Entity<MaintenanceDirective>()
				.HasMany(i => i.CategoriesRecords).WithOne(i => i.MaintenanceDirective).HasForeignKey(i => i.ParentId);
			modelBuilder.Entity<MaintenanceDirective>()
				.HasMany(i => i.Kits).WithOne(i => i.MaintenanceDirective).HasForeignKey(i => i.ParentId);


			#endregion

			#region ModuleRecord

			modelBuilder.Entity<ModuleRecord>()
				.HasOne(i => i.AircraftWorkerCategory)
				.WithMany(i => i.ModuleRecords)
				.HasForeignKey(i => i.AircraftWorkerCategoryId);

			modelBuilder.Entity<ModuleRecord>()
				.HasOne(i => i.KnowledgeModule)
				.WithMany(i => i.ModuleRecords)
				.HasForeignKey(i => i.KnowledgeModuleId);

			#endregion

			#region MTOPCheck

			modelBuilder.Entity<MTOPCheck>()
				.HasOne(i => i.CheckType)
				.WithMany(i => i.MtopChecks)
				.HasForeignKey(i => i.CheckTypeId);

			modelBuilder.Entity<MTOPCheck>()
				.HasMany(i => i.PerformanceRecords).WithOne(i => i.MtopCheck).HasForeignKey(i => i.ParentId);

			#endregion

			#region ProcedureDocumentReference

			modelBuilder.Entity<ProcedureDocumentReference>()
				.HasOne(i => i.Document)
				.WithMany(i => i.ProcedureDocumentReferences)
				.HasForeignKey(i => i.DocumentId);

			#endregion

			#region Procedure

			modelBuilder.Entity<Procedure>()
				.HasOne(i => i.JobCard)
				.WithMany(i => i.Procedure)
				.HasForeignKey(i => i.JobCardId);

			//modelBuilder.Entity<Procedure>()
			//	.HasMany(i => i.Files).WithOne(i => i.Procedure).HasForeignKey(i => i.ParentId);
			modelBuilder.Entity<Procedure>()
				.HasMany(i => i.PerformanceRecords).WithOne(i => i.Procedure).HasForeignKey(i => i.ParentID);
			modelBuilder.Entity<Procedure>()
				.HasMany(i => i.Kits).WithOne(i => i.Procedure).HasForeignKey(i => i.ParentId);
			modelBuilder.Entity<Procedure>()
				.HasMany(i => i.DocumentReferences).WithOne(i => i.Procedure).HasForeignKey(i => i.ProcedureId);

			#endregion

			#region PurchaseOrder

			modelBuilder.Entity<PurchaseOrder>()
				.HasOne(i => i.Supplier)
				.WithMany(i => i.PurchaseOrders)
				.HasForeignKey(i => i.SupplierId);

			//modelBuilder.Entity<PurchaseOrder>()
			//	.HasMany(i => i.Files).WithOne(i => i.PurchaseOrder).HasForeignKey(i => i.ParentId);

			#endregion

			#region PurchaseRequestRecord

			modelBuilder.Entity<PurchaseRequestRecord>()
				.HasOne(i => i.Supplier)
				.WithMany(i => i.PurchaseRequestRecords)
				.HasForeignKey(i => i.SupplierId);

			//modelBuilder.Entity<PurchaseRequestRecord>()
			//	.HasMany(i => i.Files).WithOne(i => i.PurchaseRequestRecord).HasForeignKey(i => i.ParentId);

			#endregion

			#region RequestForQuotation

			modelBuilder.Entity<RequestForQuotation>()
				.HasOne(i => i.Supplier)
				.WithMany(i => i.Quotations)
				.HasForeignKey(i => i.CarrierId);

			modelBuilder.Entity<RequestForQuotation>()
				.HasOne(i => i.ApprovedBy)
				.WithMany(i => i.QuotationApproveds)
				.HasForeignKey(i => i.ApprovedById);

			modelBuilder.Entity<RequestForQuotation>()
				.HasOne(i => i.PublishedBy)
				.WithMany(i => i.QuotationPublisheds)
				.HasForeignKey(i => i.PublishedById);

			modelBuilder.Entity<RequestForQuotation>()
				.HasOne(i => i.ClosedBy)
				.WithMany(i => i.QuotationCloseds)
				.HasForeignKey(i => i.ClosedById);

			modelBuilder.Entity<RequestForQuotation>()
				.HasOne(i => i.ToSupplier)
				.WithMany(i => i.RequestForQuotations)
				.HasForeignKey(i => i.ToSupplierId);

			//modelBuilder.Entity<RequestForQuotation>()
			//	.HasMany(i => i.Files).WithOne(i => i.RequestForQuotation).HasForeignKey(i => i.ParentId);
			modelBuilder.Entity<RequestForQuotation>()
				.HasMany(i => i.PackageRecords).WithOne(i => i.RequestForQuotation).HasForeignKey(i => i.ParentPackageId);

			#endregion

			#region RequestForQuotationRecord

			modelBuilder.Entity<RequestForQuotationRecord>()
				.HasOne(i => i.ToSupplier)
				.WithMany(i => i.RequestForQuotationRecords)
				.HasForeignKey(i => i.ToSupplierId);

			modelBuilder.Entity<RequestForQuotationRecord>()
				.HasOne(i => i.DefferedCategory)
				.WithMany(i => i.RequestForQuotationRecords)
				.HasForeignKey(i => i.DefferedCategoryId);

			#endregion

			#region Request

			modelBuilder.Entity<Request>()
				.HasOne(i => i.PreparedBy)
				.WithMany(i => i.PreparedByRequests)
				.HasForeignKey(i => i.PreparedById);

			modelBuilder.Entity<Request>()
				.HasOne(i => i.CheckedBy)
				.WithMany(i => i.CheckedByRequests)
				.HasForeignKey(i => i.CheckedById);

			modelBuilder.Entity<Request>()
				.HasOne(i => i.ApprovedBy)
				.WithMany(i => i.ApprovedByRequests)
				.HasForeignKey(i => i.ApprovedById);

			modelBuilder.Entity<Request>()
				.HasMany(i => i.Kits).WithOne(i => i.Request).HasForeignKey(i => i.ParentId);
			modelBuilder.Entity<Request>()
				.HasMany(i => i.PackageRecords).WithOne(i => i.Request).HasForeignKey(i => i.ParentId);

			#endregion

			#region SpecialistLicense

			modelBuilder.Entity<SpecialistLicense>()
				.HasOne(i => i.AircraftType)
				.WithMany(i => i.SpecialistLicenses)
				.HasForeignKey(i => i.AircraftTypeID);

			modelBuilder.Entity<SpecialistLicense>()
				.HasMany(i => i.CaaLicense).WithOne(i => i.SpecialistLicense).HasForeignKey(i => i.SpecialistLicenseId);

			modelBuilder.Entity<SpecialistLicense>()
				.HasMany(i => i.LicenseDetails).WithOne(i => i.SpecialistLicense).HasForeignKey(i => i.SpecialistLicenseId);

			modelBuilder.Entity<SpecialistLicense>()
				.HasMany(i => i.LicenseRatings).WithOne(i => i.SpecialistLicense).HasForeignKey(i => i.SpecialistLicenseId);

			modelBuilder.Entity<SpecialistLicense>()
				.HasMany(i => i.SpecialistInstrumentRatings).WithOne(i => i.SpecialistLicense).HasForeignKey(i => i.SpecialistLicenseId);

			modelBuilder.Entity<SpecialistLicense>()
				.HasMany(i => i.LicenseRemark).WithOne(i => i.SpecialistLicense).HasForeignKey(i => i.SpecialistLicenseId);

			#endregion

			#region SpecialistLicenseRemark

			modelBuilder.Entity<SpecialistLicenseRemark>()
				.HasOne(i => i.Rights)
				.WithMany(i => i.LicenseRemarks)
				.HasForeignKey(i => i.RightsId);

			modelBuilder.Entity<SpecialistLicenseRemark>()
				.HasOne(i => i.LicenseRestriction)
				.WithMany(i => i.LicenseRemarks)
				.HasForeignKey(i => i.RestrictionId);

			#endregion

			#region Specialist

			modelBuilder.Entity<Specialist>()
				.HasOne(i => i.AGWCategory)
				.WithMany(i => i.Specialists)
				.HasForeignKey(i => i.AGWCategoryId);

			modelBuilder.Entity<Specialist>()
				.HasOne(i => i.Facility)
				.WithMany(i => i.Specialists)
				.HasForeignKey(i => i.Location);

			modelBuilder.Entity<Specialist>()
				.HasOne(i => i.Specialization)
				.WithMany(i => i.Specialists)
				.HasForeignKey(i => i.SpecializationID);


			modelBuilder.Entity<Specialist>()
				.HasMany(i => i.Licenses).WithOne(i => i.Specialist).HasForeignKey(i => i.SpecialistId);
			modelBuilder.Entity<Specialist>()
				.HasMany(i => i.SpecialistTrainings).WithOne(i => i.Specialist).HasForeignKey(i => i.SpecialistId);
			modelBuilder.Entity<Specialist>()
				.HasMany(i => i.LicenseDetails).WithOne(i => i.Specialist).HasForeignKey(i => i.SpecialistId);
			modelBuilder.Entity<Specialist>()
				.HasMany(i => i.LicenseRemark).WithOne(i => i.Specialist).HasForeignKey(i => i.SpecialistId);
			modelBuilder.Entity<Specialist>()
				.HasMany(i => i.EmployeeDocuments).WithOne(i => i.Specialist).HasForeignKey(i => i.ParentID);
			modelBuilder.Entity<Specialist>()
				.HasMany(i => i.CategoriesRecords).WithOne(i => i.Specialist).HasForeignKey(i => i.ParentId);
			//modelBuilder.Entity<Specialist>()
			//	.HasMany(i => i.Files).WithOne(i => i.SpecialistDto).HasForeignKey(i => i.ParentId);

			#endregion

			#region SpecialistTraining

			modelBuilder.Entity<SpecialistTraining>()
				.HasOne(i => i.AircraftType)
				.WithMany(i => i.SpecialistTrainings)
				.HasForeignKey(i => i.AircraftTypeID);

			modelBuilder.Entity<SpecialistTraining>()
				.HasOne(i => i.EmployeeSubject)
				.WithMany(i => i.SpecialistTrainings)
				.HasForeignKey(i => i.EmployeeSubjectID);

			modelBuilder.Entity<SpecialistTraining>()
				.HasOne(i => i.Supplier)
				.WithMany(i => i.SpecialistTrainings)
				.HasForeignKey(i => i.SupplierId);

			//modelBuilder.Entity<SpecialistTraining>()
			//	.HasMany(i => i.Files).WithOne(i => i.SpecialistTraining).HasForeignKey(i => i.ParentId);

			#endregion

			#region StockComponentInfo

			modelBuilder.Entity<StockComponentInfo>()
				.HasOne(i => i.Standart)
				.WithMany(i => i.StockComponentInfos)
				.HasForeignKey(i => i.GoodStandartId);

			modelBuilder.Entity<StockComponentInfo>()
				.HasOne(i => i.AccessoryDescription)
				.WithMany(i => i.StockComponentInfos)
				.HasForeignKey(i => i.ComponentModel);

			#endregion

			#region SupplierDocument

			//modelBuilder.Entity<SupplierDocument>()
			//	.HasMany(i => i.Files).WithOne(i => i.SupplierDocument).HasForeignKey(i => i.ParentId);

			#endregion

			#region Supplier

			modelBuilder.Entity<Supplier>()
				.HasMany(i => i.SupplierDocs).WithOne(i => i.Supplie).HasForeignKey(i => i.ParentID);

			#endregion

			#region TransferRecord

			modelBuilder.Entity<TransferRecord>()
				.HasOne(i => i.ReceivedSpecialist)
				.WithMany(i => i.RecivedSpecialist)
				.HasForeignKey(i => i.ReceivedSpecialistId);

			modelBuilder.Entity<TransferRecord>()
				.HasOne(i => i.ReleasedSpecialist)
				.WithMany(i => i.ReleasedSpecialist)
				.HasForeignKey(i => i.ReleasedSpecialistId);


			//modelBuilder.Entity<TransferRecord>()
			//	.HasMany(i => i.Files).WithOne(i => i.TransferRecord).HasForeignKey(i => i.ParentId);

			#endregion

			#region Vehicle

			modelBuilder.Entity<Vehicle>()
				.HasOne(i => i.Model)
				.WithMany(i => i.Vehicles)
				.HasForeignKey(i => i.ModelId);

			#endregion

			#region WorkOrder

			modelBuilder.Entity<WorkOrder>()
				.HasOne(i => i.PreparedBy)
				.WithMany(i => i.PreparedWorkOrders)
				.HasForeignKey(i => i.PreparedById);

			modelBuilder.Entity<WorkOrder>()
				.HasOne(i => i.CheckedBy)
				.WithMany(i => i.CheckedWorkOrders)
				.HasForeignKey(i => i.CheckedById);

			modelBuilder.Entity<WorkOrder>()
				.HasOne(i => i.ApprovedBy)
				.WithMany(i => i.ApprovedWorkOrders)
				.HasForeignKey(i => i.ApprovedById);


			modelBuilder.Entity<WorkOrder>()
				.HasMany(i => i.Kits).WithOne(i => i.WorkOrder).HasForeignKey(i => i.ParentId);

			modelBuilder.Entity<WorkOrder>()
				.HasMany(i => i.PackageRecords).WithOne(i => i.WorkOrder).HasForeignKey(i => i.ParentId);

			#endregion

			#region WorkPackage

			//modelBuilder.Entity<WorkPackage>()
			//	.HasMany(i => i.Files).WithOne(i => i.WorkPackage).HasForeignKey(i => i.ParentId);

			#endregion


			#region AccessoryDescription

			modelBuilder.Entity<AccessoryDescription>()
				.HasOne(i => i.ATAChapter)
				.WithMany(i => i.AccessoryDescriptions)
				.HasForeignKey(i => i.AtaChapterId);

			modelBuilder.Entity<AccessoryDescription>()
				.HasOne(i => i.GoodStandart)
				.WithMany(i => i.AccessoryDescriptions)
				.HasForeignKey(i => i.StandartId);

			//modelBuilder.Entity<AccessoryDescription>()
			//	.HasMany(i => i.Files).WithOne(i => i.AccessoryDescription).HasForeignKey(i => i.ParentId);

			modelBuilder.Entity<AccessoryDescription>()
				.HasMany(i => i.SupplierRelations).WithOne(i => i.AccessoryDescription).HasForeignKey(i => i.KitId);

			#endregion

			#region DamageChart

			modelBuilder.Entity<DamageChart>()
				.HasOne(i => i.AccessoryDescription)
				.WithMany(i => i.DamageCharts)
				.HasForeignKey(i => i.AircraftModelId);

			//modelBuilder.Entity<DamageChart>()
			//	.HasMany(i => i.Files).WithOne(i => i.DamageChart).HasForeignKey(i => i.ParentId);

			#endregion

			#region DefferedCategorie

			modelBuilder.Entity<DefferedCategorie>()
				.HasOne(i => i.AccessoryDescription)
				.WithMany(i => i.DefferedCategories)
				.HasForeignKey(i => i.AircraftModelId);

			#endregion

			#region LifeLimitCategorie

			modelBuilder.Entity<LifeLimitCategorie>()
				.HasOne(i => i.AccessoryDescription)
				.WithMany(i => i.LifeLimitCategories)
				.HasForeignKey(i => i.AircraftModelId);

			#endregion

			#region Location

			modelBuilder.Entity<Location>()
				.HasOne(i => i.LocationsType)
				.WithMany(i => i.Locations)
				.HasForeignKey(i => i.LocationsTypeId);

			#endregion

			#region LocationsType

			modelBuilder.Entity<LocationsType>()
				.HasOne(i => i.Department)
				.WithMany(i => i.LocationsTypes)
				.HasForeignKey(i => i.DepartmentId);

			#endregion

			#region Nomenclature

			modelBuilder.Entity<Nomenclature>()
				.HasOne(i => i.Department)
				.WithMany(i => i.Nomenclatures)
				.HasForeignKey(i => i.DepartmentId);

			#endregion

			#region NonRoutineJob

			modelBuilder.Entity<NonRoutineJob>()
				.HasOne(i => i.ATAChapter)
				.WithMany(i => i.NonRoutineJobs)
				.HasForeignKey(i => i.ATAChapterId);

			#endregion

			#region Specialization

			modelBuilder.Entity<Specialization>()
				.HasOne(a => a.Department)
				.WithMany(b => b.Specializations)
				.HasForeignKey(b => b.DepartmentId);

			#endregion

		}

		public async Task SaveAsync(BaseEntity entity)
		{
			if (entity.Id <= 0)
				Entry(entity).State = EntityState.Added;
			else
				Entry(entity).State = EntityState.Modified;

			await SaveChangesAsync();
		}
	}
}