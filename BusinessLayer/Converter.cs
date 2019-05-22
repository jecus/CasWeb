using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Dictionaties;
using BusinessLayer.Views;
using Entity.Enums;
using Entity.Models.Dictionaries;
using Entity.Models.General;

namespace BusinessLayer
{
    public static class Converter
    {

        #region AGWCategorie

        public static AGWCategorie ToEntity(this AGWCategorieView agwCategory)
        {
            return new AGWCategorie
            {
                Id = agwCategory.Id,
                IsDeleted = agwCategory.IsDeleted,
                FullName = agwCategory.FullName,
                Gender = agwCategory.Gender,
                MinAge = agwCategory.MinAge,
                MaxAge = agwCategory.MaxAge,
                WeightSummer = agwCategory.WeightSummer,
                WeightWinter = agwCategory.WeightWinter
            };
        }

        public static AGWCategorieView ToBlView(this AGWCategorie agwCategorie)
        {
            return new AGWCategorieView()
            {
                Id = agwCategorie.Id,
                IsDeleted = agwCategorie.IsDeleted,
                FullName = agwCategorie.FullName,
                Gender = agwCategorie.Gender,
                MinAge = agwCategorie.MinAge ?? default(int),
                MaxAge = agwCategorie.MaxAge ?? default(int),
                WeightSummer = agwCategorie.WeightSummer ?? default(int),
                WeightWinter = agwCategorie.WeightWinter ?? default(int)
            };
        }

        public static List<AGWCategorieView> ToBlView(this IEnumerable<AGWCategorie> agwCategory)
        {
            return new List<AGWCategorieView>(agwCategory.Select(i => i.ToBlView()));
        }

        public static List<AGWCategorie>ToEntity(this IEnumerable<AGWCategorieView> agwCategory)
        {
            return new List<AGWCategorie>(agwCategory.Select(i => i.ToEntity()));
        }

        #endregion

        #region Aircraft

        public static Aircraft ToEntity(this AircraftView aircraft)
        {
            return new Aircraft
            {
                Id = aircraft.Id,
                IsDeleted = aircraft.IsDeleted,
                AircraftFrameId = aircraft.AircraftFrameId,
                OperatorID = aircraft.OperatorID,
                APUFH = aircraft.APUFH,
                AircraftTypeID = aircraft.AircraftTypeID,
                ModelId = aircraft.Model?.Id,
                TypeCertificateNumber = aircraft.TypeCertificateNumber,
                ManufactureDate = aircraft.ManufactureDate,
                RegistrationNumber = aircraft.RegistrationNumber,
                SerialNumber = aircraft.SerialNumber,
                VariableNumber = aircraft.VariableNumber,
                LineNumber = aircraft.LineNumber,
                Owner = aircraft.Owner,
                BasicEmptyWeight = aircraft.BasicEmptyWeight,
                BasicEmptyWeightCargoConfig = aircraft.BasicEmptyWeightCargoConfig,
                CargoCapacityContainer = aircraft.CargoCapacityContainer,
                Cruise = aircraft.Cruise,
                CruiseFuelFlow = aircraft.CruiseFuelFlow,
                FuelCapacity = aircraft.FuelCapacity,
                MaxCruiseAltitude = aircraft.MaxCruiseAltitude,
                MaxLandingWeight = aircraft.MaxLandingWeight,
                MaxPayloadWeight = aircraft.MaxLandingWeight,
                MaxTakeOffCrossWeight = aircraft.MaxTakeOffCrossWeight,
                MaxTaxiWeight = aircraft.MaxTaxiWeight,
                MaxZeroFuelWeight = aircraft.MaxZeroFuelWeight,
                OperationalEmptyWeight = aircraft.OperationalEmptyWeight,
                CockpitSeating = aircraft.CockpitSeating,
                Galleys = aircraft.Galleys,
                Lavatory = aircraft.Lavatory,
                SeatingEconomy = (short?)aircraft.SeatingEconomy,
                SeatingBusiness = (short?)aircraft.SeatingBusiness,
                SeatingFirst = (short?)aircraft.SeatingFirst,
                Oven = aircraft.Oven,
                Boiler = aircraft.Boiler,
                AirStairDoors = aircraft.AirStairDoors,
                Tanks = aircraft.Tanks,
                AircraftAddress24Bit = aircraft.AircraftAddress24Bit,
                ELTIdHexCode = aircraft.ELTIdHexCode,
                DeliveryDate = aircraft.DeliveryDate,
                AcceptanceDate = aircraft.AcceptanceDate,
                Schedule = aircraft.Schedule,
                MSG = (short)aircraft.MSG,
                CheckNaming = aircraft.CheckNaming,
                NoiceCategory = aircraft.NoiceCategory,
                FADEC = aircraft.FADEC,
                LandingCategory = aircraft.LandingCategory,
                EFIS = aircraft.EFIS,
                Brakes = (short)aircraft.Brakes,
                Winglets = aircraft.Winglets,
                ApuUtizationPerFlightinMinutes = aircraft.ApuUtizationPerFlightinMinutes,
            };
        }

        public static AircraftView ToBlView(this Aircraft aircraft)
        {
            return new AircraftView
            {
                Id = aircraft.Id,
                AircraftFrameId = aircraft.AircraftFrameId,
                IsDeleted = aircraft.IsDeleted,
                APUFH = aircraft.APUFH,
                OperatorID = aircraft.OperatorID,
                AircraftTypeID = aircraft.AircraftTypeID,
                TypeCertificateNumber = aircraft.TypeCertificateNumber,
                ManufactureDate = aircraft.ManufactureDate,
                RegistrationNumber = aircraft.RegistrationNumber,
                SerialNumber = aircraft.SerialNumber,
                VariableNumber = aircraft.VariableNumber,
                LineNumber = aircraft.LineNumber,
                Owner = aircraft.Owner,
                BasicEmptyWeight = aircraft.BasicEmptyWeight ?? default(double),
                BasicEmptyWeightCargoConfig = aircraft.BasicEmptyWeightCargoConfig ?? default(double),
                CargoCapacityContainer = aircraft.CargoCapacityContainer,
                Cruise = aircraft.Cruise,
                CruiseFuelFlow = aircraft.CruiseFuelFlow,
                FuelCapacity = aircraft.FuelCapacity,
                MaxCruiseAltitude = aircraft.MaxCruiseAltitude,
                MaxLandingWeight = aircraft.MaxLandingWeight ?? default(double),
                MaxPayloadWeight = aircraft.MaxPayloadWeight ?? default(double),
                MaxTakeOffCrossWeight = aircraft.MaxTakeOffCrossWeight ?? default(double),
                MaxTaxiWeight = aircraft.MaxTaxiWeight ?? default(double),
                MaxZeroFuelWeight = aircraft.MaxZeroFuelWeight ?? default(double),
                OperationalEmptyWeight = aircraft.OperationalEmptyWeight ?? default(double),
                CockpitSeating = aircraft.CockpitSeating,
                Galleys = aircraft.Galleys,
                Lavatory = aircraft.Lavatory,
                SeatingEconomy = aircraft.SeatingEconomy ?? default(int),
                SeatingBusiness = aircraft.SeatingBusiness ?? default(int),
                SeatingFirst = aircraft.SeatingFirst ?? default(int),
                Oven = aircraft.Oven,
                Boiler = aircraft.Boiler,
                AirStairDoors = aircraft.AirStairDoors,
                Tanks = aircraft.Tanks ?? default(int),
                AircraftAddress24Bit = aircraft.AircraftAddress24Bit,
                ELTIdHexCode = aircraft.ELTIdHexCode,
                DeliveryDate = aircraft.DeliveryDate,
                AcceptanceDate = aircraft.AcceptanceDate,
                Schedule = aircraft.Schedule,
                MSG = (MSG)aircraft.MSG,
                CheckNaming = aircraft.CheckNaming,
                NoiceCategory = aircraft.NoiceCategory,
                FADEC = aircraft.FADEC,
                LandingCategory = aircraft.LandingCategory,
                EFIS = aircraft.EFIS,
                Brakes = (Brakes)aircraft.Brakes,
                Winglets = aircraft.Winglets,
                ApuUtizationPerFlightinMinutes = aircraft.ApuUtizationPerFlightinMinutes,
                Model = aircraft.Model?.ToBlView()
            };
            
        }

        public static List<AircraftView> ToBlView(this IEnumerable<Aircraft> aircraft)
        {
            return new List<AircraftView>(aircraft.Select(i => i.ToBlView()));
        }

        public static List<Aircraft> ToEntity(this IEnumerable<AircraftView> aircraft)
        {
            return new List<Aircraft>(aircraft.Select(i => i.ToEntity()));
        }

        #endregion

        #region Department

        public static Department ToEntity(this DepartmentView department)
        {
            return new Department
            {
                Id = department.Id,
                IsDeleted = department.IsDeleted,
                Name = department.Name,
                FullName = department.FullName
            };
        }

        public static DepartmentView ToBlView(this Department department)
        {
            return new DepartmentView()
            {
                Id = department.Id,
                IsDeleted = department.IsDeleted,
                Name = department.Name,
                FullName = department.FullName
            };
        }

        public static List<DepartmentView> ToBlView(this IEnumerable<Department> department)
        {
            return new List<DepartmentView>(department.Select(i => i.ToBlView()));
        }

        public static List<Department> ToEntity(this IEnumerable<DepartmentView> department)
        {
            return new List<Department>(department.Select(i => i.ToEntity()));
        }

        #endregion

        #region BaseComponent

        public static Component ToBaseComponentEntity(this BaseComponentView com)
        {
            return new Component
            {
                Id = com.Id,
                IsDeleted = com.IsDeleted,
                StartDate = com.StartDate,
                IsBaseComponent = com.IsBaseComponent,
                ManufactureDate = com.ManufactureDate,
                Manufacturer = com.Manufacturer,
                PartNumber = com.PartNumber,
                SerialNumber = com.SerialNumber,
                BaseComponentTypeId = com.BaseComponentTypeId,
                TransferRecords = com.TransferRecords.ToEntity(),
                Model = com.Model?.ToEntity()
            };
        }

        public static BaseComponentView ToBaseComponentView(this Component com)
        {
            return new BaseComponentView()
            {
                Id = com.Id,
                IsDeleted = com.IsDeleted,
                StartDate = com.StartDate,
                IsBaseComponent = com.IsBaseComponent,
                ManufactureDate = com.ManufactureDate,
                Manufacturer = com.Manufacturer,
                PartNumber = com.PartNumber,
                SerialNumber = com.SerialNumber,
                BaseComponentTypeId = com.BaseComponentTypeId,
                TransferRecords = com.TransferRecords?.ToBlView(),
                Model = com.Model?.ToBlView()
            };
        }

        public static List<BaseComponentView> ToBaseComponentView(this IEnumerable<Component> com)
        {
            return new List<BaseComponentView>(com.Select(i => i.ToBaseComponentView()));
        }

        public static List<Component> ToBaseComponentEntity(this IEnumerable<BaseComponentView> com)
        {
            return new List<Component>(com.Select(i => i.ToBaseComponentEntity()));
        }

        #endregion

        #region Document

        public static Document ToEntity(this DocumentView document)
        {
            return new Document
            {
                Id = document.Id,
                IsDeleted = document.IsDeleted,
                ParentID = document.ParentID,
                ParentTypeId = document.ParentTypeId,
                DocTypeId = document.DocTypeId,
                SubTypeId = document.DocumentSubType?.Id ?? -1,
                Description = document.Description,
                IssueDateValidFrom = document.IssueDateValidFrom,
                IssueValidTo = document.IssueValidTo,
                IssueDateValidTo = document.IssueDateValidTo,
                IssueNotify = document.IssueNotify,
                ContractNumber = document.ContractNumber,
                Revision = document.Revision,
                RevNumber = document.RevNumber,
                RevisionDateFrom = document.RevisionDateFrom,
                IsClosed = document.IsClosed,
                DepartmentId = document.Department?.Id,
                RevisionValidTo = document.RevisionValidTo,
                RevisionDateValidTo = document.RevisionDateValidTo,
                RevisionNotify = document.RevisionNotify,
                Aboard = document.Aboard,
                Privy = document.Privy,
                IssueNumber = document.IssueNumber,
                NomenсlatureId = document.Nomenсlature?.Id,
                ProlongationWay = (int?) document.ProlongationWay,
                ServiceTypeId = document.ServiceType?.Id,
                ResponsibleOccupationId = document.ResponsibleOccupation?.Id ?? -1,
                Remarks = document.Remarks,
                LocationId = document.Location?.Id ?? -1,
                SupplierId = document.Supplier?.Id ?? -1,
                ParentAircraftId = document.ParentAircraftId,
                IdNumber = document.IdNumber,

            };
        }

        public static DocumentView ToBlView(this Document document)
        {
            var doc = new DocumentView()
            {
                Id = document.Id,
                IsDeleted = document.IsDeleted,
                ParentID = document.ParentID,
                ParentTypeId = document.ParentTypeId,
                DocTypeId = document.DocTypeId,
				SubTypeId = document.SubTypeId ?? -1,
                DocumentSubType = document.DocumentSubType?.ToBlView(),
                Description = document.Description,
                IssueDateValidFrom = document.IssueDateValidFrom,
                IssueValidTo = document.IssueValidTo ?? default(bool),
                IssueDateValidTo = document.IssueDateValidTo,
                IssueNotify = document.IssueNotify ?? default(int),
                ContractNumber = document.ContractNumber,
                Revision = document.Revision ?? default(bool),
                RevNumber = document.RevNumber,
                RevisionDateFrom = document.RevisionDateFrom,
                IsClosed = document.IsClosed ?? default(bool),
                RevisionValidTo = document.RevisionValidTo ?? default(bool),
                RevisionDateValidTo = document.RevisionDateValidTo,
                RevisionNotify = document.RevisionNotify ?? default(int),
                ProlongationWay = document.ProlongationWay != null ? (ProlongationWay)document.ProlongationWay : ProlongationWay.Unknown,
                Aboard = document.Aboard,
                Privy = document.Privy,
                IssueNumber = document.IssueNumber,
                Remarks = document.Remarks,
                ParentAircraftId = document.ParentAircraftId ?? default(int),
                IdNumber = document.IdNumber,
                Supplier = document.Supplier?.ToBlView(),
                ResponsibleOccupation = document.ResponsibleOccupation?.ToBlView(),
                Nomenсlature = document.Nomenсlature?.ToBlView(),
                ServiceType = document.ServiceType?.ToBlView(),
                Location = document.Location?.ToBlView()

            };
            var department = document.Department?.ToBlView();
            if (department != null)
                doc.Department = department.IsDeleted ? DepartmentView.Unknown : department;
            else doc.Department = DepartmentView.Unknown;

            return doc;
        }

        public static List<DocumentView> ToBlView(this IEnumerable<Document> document)
        {
            return new List<DocumentView>(document.Select(i => i.ToBlView()));
        }

        public static List<Document> ToEntity(this IEnumerable<DocumentView> document)
        {
            return new List<Document>(document.Select(i => i.ToEntity()));
        }

        #endregion

        #region DocumentSubType

        public static DocumentSubType ToEntity(this DocumentSubTypeView documentsubtype)
        {
            return new DocumentSubType
            {
                Id = documentsubtype.Id,
                IsDeleted = documentsubtype.IsDeleted,
                Name = documentsubtype.Name,
                DocumentTypeId = documentsubtype.DocumentTypeId,
            };
        }

        public static DocumentSubTypeView ToBlView(this DocumentSubType documentsubtype)
        {
            return new DocumentSubTypeView()
            {
                Id = documentsubtype.Id,
                IsDeleted = documentsubtype.IsDeleted,
                Name = documentsubtype.Name,
                DocumentTypeId = documentsubtype.DocumentTypeId
            };
        }

        public static List<DocumentSubTypeView> ToBlView(this IEnumerable<DocumentSubType> document)
        {
            return new List<DocumentSubTypeView>(document.Select(i => i.ToBlView()));
        }

        public static List<DocumentSubType> ToEntity(this IEnumerable<DocumentSubTypeView> document)
        {
            return new List<DocumentSubType>(document.Select(i => i.ToEntity()));
        }

        #endregion

        #region Location

        public static Location ToEntity(this LocationView location)
        {
            return new Location
            {
                Id = location.Id,
                IsDeleted = location.IsDeleted,
                Name = location.Name,
                FullName = location.FullName,
                LocationsTypeId = location.LocationsTypeId
                
            };
        }

        public static LocationView ToBlView(this Location location)
        {
            return new LocationView()
            {
                Id = location.Id,
                IsDeleted = location.IsDeleted,
                Name = location.Name,
                FullName = location.FullName,
                LocationsTypeId = location.LocationsTypeId,
                LocationsType = location.LocationsType?.ToBlView(),
            };
        }

        public static List<LocationView> ToBlView(this IEnumerable<Location> location)
        {
            return new List<LocationView>(location.Select(i => i.ToBlView()));
        }

        public static List<Location> ToEntity(this IEnumerable<LocationView> location)
        {
            return new List<Location>(location.Select(i => i.ToEntity()));
        }

        #endregion

        #region LocationsType

        public static LocationsType ToEntity(this LocationsTypeView locationsType)
        {
            return new LocationsType
            {
                Id = locationsType.Id,
                IsDeleted = locationsType.IsDeleted,
                FullName = locationsType.FullName,
                Name = locationsType.Name,
            };

        }

        public static LocationsTypeView ToBlView(this LocationsType locationsType)
        {
            return new LocationsTypeView()
            {
                Id = locationsType.Id,
                IsDeleted = locationsType.IsDeleted,
                FullName = locationsType.FullName,
                Name = locationsType.Name,
                DepartmentId = locationsType.Department?.Id ?? -1
            };
        }

        public static List<LocationsTypeView> ToBlView(this IEnumerable<LocationsType> locationsType)
        {
            return new List<LocationsTypeView>(locationsType.Select(i => i.ToBlView()));
        }

        public static List<LocationsType> ToEntity(this IEnumerable<LocationsTypeView> locationsType)
        {
            return new List<LocationsType>(locationsType.Select(i => i.ToEntity()));
        }

		#endregion

		#region AircraftModelView

		public static AircraftModel ToEntity(this AircraftModelView acc)
        {
            return new AircraftModel()
            {
                Id = acc.Id,
                IsDeleted = acc.IsDeleted,
                ShortName = acc.ShortName,
                FullName = acc.FullName
            };
        }

        public static AircraftModelView ToBlView(this AircraftModel acc)
        {
            return new AircraftModelView()
            {
                Id = acc.Id,
                IsDeleted = acc.IsDeleted,
                ShortName = acc.ShortName,
                FullName = acc.FullName
            };
        }

        public static List<AircraftModelView> ToBlView(this IEnumerable<AircraftModel> models)
        {
            return new List<AircraftModelView>(models.Select(i => i.ToBlView()));
        }

        public static List<AircraftModel> ToEntity(this IEnumerable<AircraftModelView> models)
        {
            return new List<AircraftModel>(models.Select(i => i.ToEntity()));
        }

		#endregion

		#region ComponentModelView

		public static ComponentModel ToEntity(this ComponentModelView componentModel)
		{
			return new ComponentModel()
			{
				Id = componentModel.Id,
				IsDeleted = componentModel.IsDeleted,
				Model = componentModel.Model,
				PartNumber = componentModel.PartNumber,
				AltPartNumber = componentModel.AltPartNumber,
				AtaChapterId = componentModel.AtaChapter.Id,
				Description = componentModel.Description,
				Manufacturer = componentModel.Manufacturer,
				CostNew = componentModel.CostNew,
				CostOverhaul = componentModel.CostOverhaul,
				CostServiceable = componentModel.CostServiceable,
				Measure = componentModel.Measure,
				Remarks = componentModel.Remarks,
				SubModel = componentModel.SubModel,
				FullName = componentModel.FullName,
				ShortName = componentModel.ShortName,
				Designer = componentModel.Designer,
				Code = componentModel.Code,
				DescRus = componentModel.DescRus,
				IsEffectivity = componentModel.IsEffectivity,
				HTS = componentModel.HTS,
				ComponentClass = (short)(componentModel.ComponentClass?.ItemId ?? -1),
				IsDangerous = componentModel.IsDangerous
			};
		}

		public static ComponentModelView ToBlView(this ComponentModel componentModel)
		{
			return new ComponentModelView()
			{
				Id = componentModel.Id,
				IsDeleted = componentModel.IsDeleted,
				Model = componentModel.Model,
				PartNumber = componentModel.PartNumber,
				AltPartNumber = componentModel.AltPartNumber,
				Description = componentModel.Description,
				Manufacturer = componentModel.Manufacturer,
				CostNew = componentModel.CostNew,
				CostOverhaul = componentModel.CostOverhaul,
				CostServiceable = componentModel.CostServiceable,
				Measure = componentModel.Measure,
				Remarks = componentModel.Remarks,
				SubModel = componentModel.SubModel,
				FullName = componentModel.FullName,
				ShortName = componentModel.ShortName,
				Designer = componentModel.Designer,
				Code = componentModel.Code,
				DescRus = componentModel.DescRus,
				IsEffectivity = componentModel.IsEffectivity,
				HTS = componentModel.HTS,
				ComponentClass = componentModel.ComponentClass.HasValue ? GoodsClass.GetItemById(componentModel.ComponentClass.Value) : GoodsClass.Unknown,
				IsDangerous = componentModel.IsDangerous,
				AtaChapter = componentModel.ATAChapter?.ToBlView()
			};
		}

		public static List<ComponentModelView> ToBlView(this IEnumerable<ComponentModel> models)
		{
			return new List<ComponentModelView>(models.Select(i => i.ToBlView()));
		}

		public static List<ComponentModel> ToEntity(this IEnumerable<ComponentModelView> models)
		{
			return new List<ComponentModel>(models.Select(i => i.ToEntity()));
		}

		#endregion

		#region Product

		public static Product ToEntity(this ProductView componentModel)
		{
			return new Product()
			{
				Id = componentModel.Id,
				IsDeleted = componentModel.IsDeleted,
				Model = componentModel.Model,
				PartNumber = componentModel.PartNumber,
				AltPartNumber = componentModel.AltPartNumber,
				AtaChapterId = componentModel.AtaChapter.Id,
				Description = componentModel.Description,
				Manufacturer = componentModel.Manufacturer,
				CostNew = componentModel.CostNew,
				CostOverhaul = componentModel.CostOverhaul,
				CostServiceable = componentModel.CostServiceable,
				Measure = componentModel.Measure,
				Remarks = componentModel.Remarks,
				SubModel = componentModel.SubModel,
				FullName = componentModel.FullName,
				ShortName = componentModel.ShortName,
				Designer = componentModel.Designer,
				Code = componentModel.Code,
				DescRus = componentModel.DescRus,
				IsEffectivity = componentModel.IsEffectivity,
				HTS = componentModel.HTS,
				ComponentClass = (short)(componentModel.ComponentClass?.ItemId ?? -1),
				IsDangerous = componentModel.IsDangerous
			};
		}

		public static ProductView ToBlView(this Product componentModel)
		{
			return new ProductView()
			{
				Id = componentModel.Id,
				IsDeleted = componentModel.IsDeleted,
				Model = componentModel.Model,
				PartNumber = componentModel.PartNumber,
				AltPartNumber = componentModel.AltPartNumber,
				Description = componentModel.Description,
				Manufacturer = componentModel.Manufacturer,
				CostNew = componentModel.CostNew,
				CostOverhaul = componentModel.CostOverhaul,
				CostServiceable = componentModel.CostServiceable,
				Measure = componentModel.Measure,
				Remarks = componentModel.Remarks,
				SubModel = componentModel.SubModel,
				FullName = componentModel.FullName,
				ShortName = componentModel.ShortName,
				Designer = componentModel.Designer,
				Code = componentModel.Code,
				DescRus = componentModel.DescRus,
				IsEffectivity = componentModel.IsEffectivity,
				HTS = componentModel.HTS,
				ComponentClass = componentModel.ComponentClass.HasValue ? GoodsClass.GetItemById(componentModel.ComponentClass.Value) : GoodsClass.Unknown,
				IsDangerous = componentModel.IsDangerous,
				AtaChapter = componentModel.ATAChapter?.ToBlView()
			};
		}

		public static List<ProductView> ToBlView(this IEnumerable<Product> models)
		{
			return new List<ProductView>(models.Select(i => i.ToBlView()));
		}

		public static List<Product> ToEntity(this IEnumerable<ProductView> models)
		{
			return new List<Product>(models.Select(i => i.ToEntity()));
		}

		#endregion

		#region Nomenclature

		public static Nomenclature ToEntity(this NomenclatureView nomenclature)
        {
            return new Nomenclature
            {
                Id = nomenclature.Id,
                IsDeleted = nomenclature.IsDeleted,
                Name = nomenclature.Name,
                FullName = nomenclature.FullName,
				DepartmentId = nomenclature?.Department.Id
            };
        }

        public static NomenclatureView ToBlView(this Nomenclature nomenclature)
        {
            return new NomenclatureView()
            {
                Id = nomenclature.Id,
                IsDeleted = nomenclature.IsDeleted,
                Name = nomenclature.Name,
                FullName = nomenclature.FullName,
				Department = nomenclature?.Department.ToBlView() ?? DepartmentView.Unknown
            };
        }

        public static List<NomenclatureView> ToBlView(this IEnumerable<Nomenclature> nomenclature)
        {
            return new List<NomenclatureView>(nomenclature.Select(i => i.ToBlView()));
        }

        public static List<Nomenclature> ToEntity(this IEnumerable<NomenclatureView> nomenclature)
        {
            return new List<Nomenclature>(nomenclature.Select(i => i.ToEntity()));
        }

        #endregion

        #region Operator

        public static Operator ToEntity(this OperatorView oper)
        {
            return new Operator
            {
                Id = oper.ItemId,
                IsDeleted = oper.IsDeleted,
                Name = oper.Name,
                LogoType = oper.LogoType,
                ICAOCode = oper.ICAOCode,
                Address = oper.Address,
                Phone = oper.Phone,
                Fax = oper.Fax,
                LogoTypeWhite = oper.LogoTypeWhite,
                Email = oper.Email,
                LogotypeReportLarge = oper.LogotypeReportLarge,
                LogotypeReportVeryLarge = oper.LogotypeReportVeryLarge
            };
        }

        public static OperatorView ToBlView(this Operator oper)
        {
            return new OperatorView()
            {
                ItemId = oper.Id,
                IsDeleted = oper.IsDeleted,
                Name = oper.Name,
                LogoType = oper.LogoType,
                ICAOCode = oper.ICAOCode,
                Address = oper.Address,
                Phone = oper.Phone,
                Fax = oper.Fax,
                LogoTypeWhite = oper.LogoTypeWhite,
                Email = oper.Email,
                LogotypeReportLarge = oper.LogotypeReportLarge,
                LogotypeReportVeryLarge = oper.LogotypeReportVeryLarge
            };
        }

        public static List<OperatorView> ToBlView(this IEnumerable<Operator> oper)
        {
            return new List<OperatorView>(oper.Select(i => i.ToBlView()));
        }

        public static List<Operator> ToEntity(this IEnumerable<OperatorView> oper)
        {
            return new List<Operator>(oper.Select(i => i.ToEntity()));
        }

        #endregion

        #region ServiceType

        public static ServiceType ToEntity(this ServiceTypeView servicetype)
        {
            return new ServiceType
            {
                Id = servicetype.Id,
                IsDeleted = servicetype.IsDeleted,
                Name = servicetype.Name,
                FullName = servicetype.FullName
            };
        }

        public static ServiceTypeView ToBlView(this ServiceType servicetype)
        {
            return new ServiceTypeView()
            {
                Id = servicetype.Id,
                IsDeleted = servicetype.IsDeleted,
                Name = servicetype.Name,
                FullName = servicetype.FullName
            };
        }

        public static List<ServiceTypeView> ToBlView(this IEnumerable<ServiceType> servicetype)
        {
            return new List<ServiceTypeView>(servicetype.Select(i => i.ToBlView()));
        }

        public static List<ServiceType> ToEntity(this IEnumerable<ServiceTypeView> servicetype)
        {
            return new List<ServiceType>(servicetype.Select(i => i.ToEntity()));
        }

        #endregion

        #region Specialist

        public static Specialist ToEntity(this SpecialistView specialist)
        {
            return new Specialist
            {
                Id = specialist.Id,
                IsDeleted = specialist.IsDeleted,
                FirstName = specialist.FirstName,
                ShortName = specialist.ShortName,
                SpecializationID = specialist.Specialization?.Id ?? -1,
                LastName = specialist.LastName,
                Gender = (short?) specialist.Gender,
                AGWCategoryId = specialist.AGWCategory?.Id,
                DateOfBirth = specialist.DateOfBirth,
                Nationality = specialist.Nationality,
                Address = specialist.Address,
                Photo = specialist.Photo,
                PhoneMobile = specialist.PhoneMobile,
                Phone = specialist.Phone,
                Email = specialist.Email,
                Skype = specialist.Skype,
                Information = specialist.Information,
                EducationId = (short) (specialist.Education?.ItemId ?? -1),
                Location = (short) (specialist.Facility?.Id ?? -1),
                Status = (short) specialist.Status,
                Position = (short) specialist.Position,
                Sign = specialist.Sign,
                FamilyStatusId = (short) (specialist.FamilyStatus?.ItemId ?? -1),
                Citizenship = (short) specialist.Citizenship,
                PersonnelCategoryId = specialist.PersonnelCategoryId,
                ClassNumber = specialist.ClassNumber,
                ClassIssueDate = specialist.ClassIssueDate,
                GradeNumber = specialist.GradeNumber,
                GradeIssueDate = specialist.GradeIssueDate,
                Additional = specialist.Additional,
                Combination = specialist.Combination,
				Specialization = specialist.Specialization.ToEntity()
            };
        }

        public static SpecialistView ToBlView(this Specialist specialist)
        {
            return new SpecialistView()
            {
                Id = specialist.Id,
                IsDeleted = specialist.IsDeleted,
                FirstName = specialist.FirstName,
                LastName = specialist.LastName,
                ShortName = specialist.ShortName,
                Gender = specialist.Gender.HasValue ? (Gender) specialist.Gender.Value : Gender.NotApplicable,
                DateOfBirth = specialist.DateOfBirth,
                Nationality = specialist.Nationality,
                Address = specialist.Address,
                Photo = specialist.Photo,
                PhoneMobile = specialist.PhoneMobile,
                Phone = specialist.Phone,
                Email = specialist.Email,
                Skype = specialist.Skype,
                Information = specialist.Information,
                EducationId = specialist.EducationId,
                Status = (SpecialistStatus) specialist.Status,
                Position = (SpecialistPosition) specialist.Position,
                Sign = specialist.Sign,
                FamilyStatusId = specialist.FamilyStatusId,
                Citizenship = specialist.Citizenship,
                PersonnelCategoryId = specialist.PersonnelCategoryId,
                ClassNumber = specialist.ClassNumber,
                ClassIssueDate = specialist.ClassIssueDate,
                GradeNumber = specialist.GradeNumber,
                GradeIssueDate = specialist.GradeIssueDate,
                Additional = specialist.Additional,
                Combination = specialist.Combination ?? "",
                Specialization = specialist.Specialization?.ToBlView(),
                
            };

        }

        public static List<SpecialistView> ToBlView(this IEnumerable<Specialist> specialist)
        {
            return new List<SpecialistView>(specialist.Select(i => i.ToBlView()));
        }

        public static List<Specialist> ToEntity(this IEnumerable<SpecialistView> specialist)
        {
            return new List<Specialist>(specialist.Select(i => i.ToEntity()));
        }

        #endregion

        #region Specialization

        public static Specialization ToEntity(this SpecializationView specialization)
        {
            return new Specialization
            {
                Id = specialization.Id,
                IsDeleted = specialization.IsDeleted,
                ShortName = specialization.ShortName,
                FullName = specialization.FullName,
                DepartmentId = specialization.Department?.Id ?? -1,
                Level = specialization.Level,
                KeyPersonel = specialization.KeyPersonel,
            };
        }

        public static SpecializationView ToBlView(this Specialization specialization)
        {
            return new SpecializationView()
            {
                Id = specialization.Id,
                IsDeleted = specialization.IsDeleted,
                ShortName = specialization.ShortName,
                FullName = specialization.FullName,
                Level = specialization.Level,
                KeyPersonel = specialization.KeyPersonel
            };
        }

        public static List<SpecializationView> ToBlView(this IEnumerable<Specialization> specialization)
        {
            return new List<SpecializationView>(specialization.Select(i => i.ToBlView()));
        }

        public static List<Specialization> ToEntity(this IEnumerable<SpecializationView> specialization)
        {
            return new List<Specialization>(specialization.Select(i => i.ToEntity()));
        }

        #endregion

        #region Store

        public static Store ToEntity(this StoreView store)
        {
            return new Store
            {
                Id = store.Id,
                IsDeleted = store.IsDeleted,
                StoreName = store.StoreName
            };
        }

        public static StoreView ToBlView(this Store store)
        {
            return new StoreView()
            {
                Id = store.Id,
                IsDeleted = store.IsDeleted,
                StoreName = store.StoreName
            };
        }

        public static List<StoreView> ToBlView(this IEnumerable<Store> stores)
        {
            return new List<StoreView>(stores.Select(i => i.ToBlView()));
        }

        public static List<Store> ToEntity(this IEnumerable<StoreView> stores)
        {
            return new List<Store>(stores.Select(i => i.ToEntity()));
        }

        #endregion

        #region Supplier

        public static Supplier ToEntity(this SupplierView supplier)
        {
            return new Supplier
            {
                Id = supplier.Id,
                IsDeleted = supplier.IsDeleted,
                Name = supplier.Name,
                ShortName = supplier.ShortName,
                AirCode = supplier.AirCode,
                VendorCode = supplier.VendorCode,
                Phone = supplier.Phone,
                Fax = supplier.Fax,
                Address = supplier.Address,
                ContactPerson = supplier.ContactPerson,
                Email = supplier.Email,
                WebSite = supplier.WebSite,
                Products = supplier.Products,
                Approved = supplier.Approved,
                Remarks = supplier.Remarks,
                SupplierClassId = supplier.SupplierClassId,
                Subject = supplier.Subject,
                
            };
        }

        public static SupplierView ToBlView(this Supplier supplier)
        {

            return new SupplierView()
            {
                Id = supplier.Id,
                IsDeleted = supplier.IsDeleted,
                Name = supplier.Name,
                ShortName = supplier.ShortName,
                AirCode = supplier.AirCode,
                VendorCode = supplier.VendorCode,
                Phone = supplier.Phone,
                Fax = supplier.Fax,
                Address = supplier.Address,
                ContactPerson = supplier.ContactPerson,
                Email = supplier.Email,
                WebSite = supplier.WebSite,
                Products = supplier.Products,
                Approved = supplier.Approved ?? default(bool),
                Remarks = supplier.Remarks,
                SupplierClassId = supplier.SupplierClassId,
                Subject = supplier.Subject
            };
        }

        public static List<SupplierView> ToBlView(this IEnumerable<Supplier> supplier)
        {
            return new List<SupplierView>(supplier.Select(i => i.ToBlView()));
        }

        public static List<Supplier> ToEntity(this IEnumerable<SupplierView> supplier)
        {
            return new List<Supplier>(supplier.Select(i => i.ToEntity()));
        }

        #endregion

        #region TransferRecords

        public static TransferRecord ToEntity(this TransferRecordView transrec)
        {
            return new TransferRecord
            {
                Id = transrec.Id,
                IsDeleted = transrec.IsDeleted,
                ParentID = transrec.ParentID,
                ParentType = transrec.ParentType,
                FromAircraftID = transrec.FromAircraftID,
                FromStoreID = transrec.FromStoreID,
                DestinationObjectID = transrec.DestinationObjectID,
                DestinationObjectType = transrec.DestinationObjectType,
                TransferDate = transrec.TransferDate,
                Position = transrec.Position,
                
            };
        }

        public static TransferRecordView ToBlView(this TransferRecord transrec)
        {
            return new TransferRecordView()
            {

                Id = transrec.Id,
                IsDeleted = transrec.IsDeleted,
                ParentID = transrec.ParentID,
                ParentType = transrec.ParentType,
                FromAircraftID = transrec.FromAircraftID,
                FromStoreID = transrec.FromStoreID,
                DestinationObjectID = transrec.DestinationObjectID,
                DestinationObjectType = transrec.DestinationObjectType,
                TransferDate = transrec.TransferDate,
                Position = transrec.Position,
                State = transrec.State
            };
        }

        public static List<TransferRecordView> ToBlView(this IEnumerable<TransferRecord> transrec)
        {
            return new List<TransferRecordView>(transrec.Select(i => i.ToBlView()));
        }

        public static List<TransferRecord> ToEntity(this IEnumerable<TransferRecordView> transrec)
        {
            return new List<TransferRecord>(transrec.Select(i => i.ToEntity()));
        }

        #endregion

        #region User

        public static User ToEntity(this UserView user)
        {
            return new User
            {
                Id = user.Id,
                IsDeleted = user.IsDeleted,
                Login = user.Login,
                Name = user.Name,
                Password = user.Password,
                Surname = user.Surname
            };
        }

        public static UserView ToBlView(this User user)
        {
            return new UserView()
            {
                Id = user.Id,
                IsDeleted = user.IsDeleted,
                Login = user.Login,
                Name = user.Name,
                Password = user.Password,
                Surname = user.Surname
            };
        }

        public static List<UserView> ToBlView(this IEnumerable<User> user)
        {
            return new List<UserView>(user.Select(i => i.ToBlView()));
        }

        public static List<User> ToEntity(this IEnumerable<UserView> user)
        {
            return new List<User>(user.Select(i => i.ToEntity()));
        }

        #endregion

        #region Component

        public static Component ToEntity(this ComponentView comp)

        {
            return new Component
            {
                Id = comp.Id,
                IsDeleted = comp.IsDeleted,
                StartDate = comp.StartDate,
                ATAChapterId = comp.ATAChapter?.Id,
                PartNumber = comp.PartNumber,
                Description = comp.Description,
                SerialNumber = comp.SerialNumber,
                BatchNumber = comp.BatchNumber,
                IdNumber = comp.IdNumber,
                MaintenanceType = comp.MaintenanceType,
                Remarks = comp.Remarks,
                Manufacturer = comp.Manufacturer,
                ManufactureDate = comp.ManufactureDate,
                DeliveryDate = comp.DeliveryDate,
                Lifelength = comp.Lifelength,
                LLPMark = comp.LLPMark,
                LLPCategories = comp.LLPCategories,
                LandingGear = (short)comp.LandingGear,
                AvionicsInventory = (short)comp.AvionicsInventory,
                ALTPN = comp.ALTPN,
                MTOGW = comp.MTOGW,

                HushKit = comp.HushKit,
                Cost = comp.Cost,
                CostServiceable = comp.CostServiceable,
                CostOverhaul = comp.CostOverhaul,
                Measure = comp.Measure,

                Quantity = comp.Quantity,
                ManHours = comp.ManHours,
                Warranty = comp.Warranty,
                WarrantyNotify = comp.WarrantyNotify,
                Serviceable = comp.Serviceable,
                ShelfLife = comp.ShelfLife,
                ExpirationDate = comp.ExpirationDate,
                NotificationDate = comp.NotificationDate,

                Highlight = comp.Highlight,
                MPDItem = comp.MPDItem,
                HiddenRemarks = comp.HiddenRemarks,
                Supplier = comp.Supplier,
                LifeLimit = comp.LifeLimit,

                LifeLimitNotify = comp.LifeLimitNotify,
                KitRequired = comp.KitRequired,

                StartLifelength = comp.StartLifelength,
                Code = comp.Code,

                Status = (short?)comp.Status,
                IsBaseComponent = comp.IsBaseComponent,

                LocationId = comp.Location?.Id ?? -1,

                Incoming = comp.Incoming,

                Discrepancy = comp.Discrepancy,
                IsPool = comp.IsPool,
                IsDangerous = comp.IsDangerous,

                QuantityInput = comp.QuantityIn,
                FromSupplierId = comp.FromSupplier?.Id ?? -1,
                FromSupplierReciveDate = comp.FromSupplierReciveDate,
                
            };
        }


        public static ComponentView ToBlView(this Component comp)
        {
            return new ComponentView()
            {
                Id = comp.Id,

                IsDeleted = comp.IsDeleted,
                StartDate = comp.StartDate ,

                ATAChapter = comp.ATAChapter,
                PartNumber = comp.PartNumber,
                Description = comp.Description,
                SerialNumber = comp.SerialNumber,
                BatchNumber = comp.BatchNumber,

                IdNumber = comp.IdNumber,
                MaintenanceType = comp.MaintenanceType,
                Remarks = comp.Remarks,
                Manufacturer = comp.Manufacturer,

                ManufactureDate = comp.ManufactureDate,
                DeliveryDate = comp.DeliveryDate,
                Lifelength = comp.Lifelength,
                LLPMark = comp.LLPMark,
                LLPCategories = comp.LLPCategories,
                LandingGear = (LandingGearMarkType)comp.LandingGear,
                AvionicsInventory = comp.AvionicsInventory,
                ALTPN = comp.ALTPN,
                MTOGW = comp.MTOGW,
                HushKit = comp.HushKit,
                Cost = comp.Cost ?? default(double),
                CostServiceable = comp.CostServiceable ?? default(double),
                CostOverhaul = comp.CostOverhaul ?? default(double),
                Measure = comp.Measure ?? default(int),
                Quantity = comp.Quantity,
                ManHours = comp.ManHours ?? default(double),
                Warranty = comp.Warranty,
                WarrantyNotify = comp.WarrantyNotify,
                Serviceable = comp.Serviceable ?? default(bool),
                ShelfLife = comp.ShelfLife,
                ExpirationDate = comp.ExpirationDate,
                NotificationDate = comp.NotificationDate,
                Highlight = comp.Highlight,

                MPDItem = comp.MPDItem,
                HiddenRemarks = comp.HiddenRemarks,

                LifeLimit = comp.LifeLimit,
                LifeLimitNotify = comp.LifeLimitNotify,
                KitRequired = comp.KitRequired,
				Type = comp.Type,
                StartLifelength = comp.StartLifelength,
                Code = comp.Code,
                Status = (ComponentStatus?)comp.Status,
                IsBaseComponent = comp.IsBaseComponent,
                Location = comp.Location?.ToBlView()  ?? LocationView.Unknown,

                Incoming = comp.Incoming,
                Discrepancy = comp.Discrepancy,
                IsPool = comp.IsPool,
                IsDangerous = comp.IsDangerous,
                QuantityIn = comp.QuantityIn,
                FromSupplier = comp.FromSupplier?.ToBlView() ?? SupplierView.Unknown,
                TransferRecords = comp.TransferRecords?.ToBlView(),
                FromSupplierReciveDate = comp.FromSupplierReciveDate
            };
           
        }


        public static List<ComponentView> ToBlView(this IEnumerable<Component> comp)
        {
            return new List<ComponentView>(comp.Select(i => i.ToBlView()));
        }

        public static List<Component> ToEntity(this IEnumerable<ComponentView> comp)
        {
            return new List<Component>(comp.Select(i => i.ToEntity()));
        }
        #endregion

        #region ComponentDirective

        public static ComponentDirective ToEntity(this ComponentDirectiveView comdir)
        {
            return new ComponentDirective

            {
                Id = comdir.Id,
                IsDeleted = comdir.IsDeleted,
                DirectiveType = comdir.DirectiveType,
                Threshold = comdir.Threshold,
                ManHours = comdir.ManHours,
                Remarks = comdir.Remarks,
                Cost = comdir.Cost,
                Highlight = comdir.Highlight,
                KitRequired = comdir.KitRequired,
                HiddenRemarks = comdir.HiddenRemarks,
                IsClosed = comdir.IsClosed,
                MPDTaskTypeId = comdir.MPDTaskTypeId,
                NDTType = (short)comdir.NDTType,
                ComponentId = comdir.ComponentId,
                ZoneArea = comdir.ZoneArea,
                AccessDirective = comdir.AccessDirective,
                AAM = comdir.AAM,
                CMM = comdir.CMM,
                
            };
        }


        public static ComponentDirectiveView ToBlView(this ComponentDirective comdir)
        {
            return new ComponentDirectiveView()
            {
                Id = comdir.Id,
                IsDeleted = comdir.IsDeleted,
                DirectiveType = comdir.DirectiveType,

                //TODO:Разобраться почему private set
                //Threshold = new ComponentDirectiveThreshold(comdirdto.Threshold),

                ManHours = comdir.ManHours ?? default(double),
                Remarks = comdir.Remarks,
                Cost = comdir.Cost ?? default(double),
                Highlight = comdir.Highlight,
                KitRequired = comdir.KitRequired,
                HiddenRemarks = comdir.HiddenRemarks,
                IsClosed = comdir.IsClosed ?? default(bool),
                MPDTaskTypeId = comdir.MPDTaskTypeId ?? default(int),
                NDTType = comdir.NDTType,
                ComponentId = comdir.ComponentId,
                ZoneArea = comdir.ZoneArea,
                AccessDirective = comdir.AccessDirective,
                AAM = comdir.AAM,
                CMM = comdir.CMM
            };

        }

        public static List<ComponentDirectiveView> ToBlView(this IEnumerable<ComponentDirective> comdir)
        {
            return new List<ComponentDirectiveView>(comdir.Select(i => i.ToBlView()));
        }

        public static List<ComponentDirective> ToEntity(this IEnumerable<ComponentDirectiveView> comdir)
        {
            return new List<ComponentDirective>(comdir.Select(i => i.ToEntity()));
        }

        #endregion

        #region ATLB

        public static ATLB ToEntity(this ATLBView atl)

        {
            return new ATLB
            {
                Id = atl.Id,
                IsDeleted = atl.IsDeleted,

                AircraftID = atl.AircraftID,
                ATLBNo = atl.ATLBNo,
                StartPageNo = atl.StartPageNo,
                OpeningDate = atl.OpeningDate,
                Remarks = atl.Remarks,
                Revision = atl.Revision,
                PageFlightCount = atl.PageFlightCount,
                AtlbStatus = (int)atl.AtlbStatus,

            };

        }


        public static ATLBView ToBlView(this ATLB atl)
        {

            return new ATLBView()
            {
                Id = atl.Id,
                IsDeleted = atl.IsDeleted,

                AircraftID = atl.AircraftID ?? default(int),
                ATLBNo = atl.ATLBNo,
                StartPageNo = atl.StartPageNo ?? default(int),
                OpeningDate = atl.OpeningDate,

                Remarks = atl.Remarks,

                Revision = atl.Revision,
                PageFlightCount = atl.PageFlightCount ?? default(int),
                AtlbStatus = (AtlbStatus)atl.AtlbStatus
            };

        }

        public static List<ATLBView> ToBlView(this IEnumerable<ATLB> atl)
        {
            return new List<ATLBView>(atl.Select(i => i.ToBlView()));
        }

        public static List<ATLB> ToEntity(this IEnumerable<ATLBView> atl)
        {
            return new List<ATLB>(atl.Select(i => i.ToEntity()));
        }

        #endregion

        #region AircraftFlight

        public static AircraftFlight ToEntity(this AircraftFlightView arcf)
        {

            return new AircraftFlight
            {
                Id = arcf.Id,
                IsDeleted = arcf.IsDeleted,
                ATLBID = arcf.ATLBID,
                AircraftId = arcf.AircraftId,
                FlightNo = arcf.FlightNo,
                Remarks = arcf.Remarks,
                FlightDate = arcf.FlightDate,
                StationFrom = arcf.StationFrom,
                StationTo = arcf.StationTo,

                DelayTime = arcf.DelayTime,

                DelayReasonId = arcf.DelayReason?.Id,
                OutTime = arcf.OutTime,
                InTime = arcf.InTime,
                TakeOffTime = arcf.TakeOffTime,
                LDGTime = arcf.LDGTime,
                NightTime = arcf.NightTime,

                CRSID = arcf.CRSID,
                Tanks = arcf.Tanks,
                Fluids = arcf.Fluids,
                EnginesGeneralCondition = arcf.EnginesGeneralCondition,
                Correct = arcf.Correct,
                Reference = arcf.Reference,

                Cycles = arcf.Cycles,
                PageNo = arcf.PageNo,

                FlightType = (short?)arcf.FlightType?.ItemId,
                LevelId = arcf.Level?.Id,
                Distance = arcf.Distance,

                DistanceMeasure = arcf.DistanceMeasure?.ItemId,
                TakeOffWeight = arcf.TakeOffWeight,

                AlignmentBefore = arcf.AlignmentBefore,
                AlignmentAfter = arcf.AlignmentAfter,
                FlightCategory = (short?)arcf.FlightCategory,
                AtlbRecordType = (short)arcf.AtlbRecordType,
                FlightAircraftCode = (short?)arcf.FlightAircraftCode,
                CancelReasonId = arcf.CancelReason?.Id,
                StationFromId = arcf.StationFromId,
                StationToId = arcf.StationToId,
                FlightNumberId = arcf.FlightNumber?.Id ?? -1,
                
            };
        }

        public static AircraftFlightView ToBlView(this AircraftFlight arcf)
        {
            return new AircraftFlightView()
                {
                Id = arcf.Id,
                IsDeleted = arcf.IsDeleted,
                ATLBID = arcf.ATLBID,
                AircraftId = arcf.AircraftId ?? default(int),

                FlightNo = arcf.FlightNo,
                Remarks = arcf.Remarks,
                FlightDate = arcf.FlightDate ?? DateTimeExtend.GetCASMinDateTime(),
                StationFrom = arcf.StationFrom,
                StationTo = arcf.StationTo,
                DelayTime = arcf.DelayTime ?? default(short),
                DelayReason = arcf.DelayReason?.ToBlView(),

                OutTime = arcf.OutTime ?? default(int),
                InTime = arcf.InTime ?? default(int),
                TakeOffTime = arcf.TakeOffTime ?? default(int),
                LDGTime = arcf.LDGTime ?? default(int),
                NightTime = arcf.NightTime ?? default(int),

                CRSID = arcf.CRSID ?? default(int),
                Tanks = arcf.Tanks,
                Fluids = arcf.Fluids,
                EnginesGeneralCondition = arcf.EnginesGeneralCondition,
                Correct = arcf.Correct,

                Reference = arcf.Reference,

                Cycles = arcf.Cycles,
                PageNo = arcf.PageNo,
                FlightType = arcf.FlightType.HasValue ? FlightType.GetItemById(arcf.FlightType.Value) : FlightType.UNK,
                Level = arcf.Level?.ToBlView(),
                Distance = arcf.Distance ?? default(int),
                DistanceMeasure = arcf.DistanceMeasure.HasValue ? Measure.GetItemById(arcf.DistanceMeasure.Value) : Measure.Unknown,
                TakeOffWeight = arcf.TakeOffWeight ?? default(double),
                AlignmentBefore = arcf.AlignmentBefore ?? default(double),
                AlignmentAfter = arcf.AlignmentAfter ?? default(double),
                FlightCategory = arcf.FlightCategory.HasValue ? (FlightCategory)arcf.FlightCategory.Value : FlightCategory.Unknown,
                AtlbRecordType = (AtlbRecordType)arcf.AtlbRecordType,
                FlightAircraftCode = arcf.FlightAircraftCode.HasValue ? (FlightAircraftCode)arcf.FlightAircraftCode.Value : FlightAircraftCode.Unknown,
                CancelReason = arcf.CancelReason?.ToBlView(),
                StationFroms = arcf.StationFroms?.ToBlView(),
                StationTos = arcf.StationTos?.ToBlView(),
                FlightNumber = arcf.FlightNumber?.ToBlView()
            };
        }

        public static List<AircraftFlightView> ToBlView(this IEnumerable<AircraftFlight> arcf)
        {
            return new List<AircraftFlightView>(arcf.Select(i => i.ToBlView()));
        }

        public static List<AircraftFlight> ToEntity(this IEnumerable<AircraftFlightView> arcf)
        {
            return new List<AircraftFlight>(arcf.Select(i => i.ToEntity()));
        }

        #endregion

        #region Reason

        public static Reason ToEntity(this ReasonView reason)
        {
            return new Reason
            {
                Id = reason.Id,
                IsDeleted = reason.IsDeleted,
                Name = reason.Name,
                Category = reason.Category
            };
        }

        public static ReasonView ToBlView(this Reason reason)
        {
            return new ReasonView()
            {
                Id = reason.Id,
                IsDeleted = reason.IsDeleted,
                Name = reason.Name,
                Category = reason.Category
            };
        }

        public static List<ReasonView> ToBlView(this IEnumerable<Reason> reason)
        {
            return new List<ReasonView>(reason.Select(i => i.ToBlView()));
        }

        public static List<Reason> ToEntity(this IEnumerable<ReasonView> reason)
        {
            return new List<Reason>(reason.Select(i => i.ToEntity()));
        }

        #endregion

        #region CruiseLevel

        public static CruiseLevel ToEntity(this CruiseLevelView cruiseLevel)
        {
            return new CruiseLevel
            {
                Id = cruiseLevel.Id,
                IsDeleted = cruiseLevel.IsDeleted,
                FullName = cruiseLevel.FullName,
                Feet = cruiseLevel.Feet,
                IVFR = cruiseLevel.IVFR,
                Meter = cruiseLevel.Meter,
                Track = cruiseLevel.Track
            };
        }

        public static CruiseLevelView ToBlView(this CruiseLevel cruiseLevel)
        {
            return new CruiseLevelView()
            {
                Id = cruiseLevel.Id,
                IsDeleted = cruiseLevel.IsDeleted,
                FullName = cruiseLevel.FullName,
                Feet = cruiseLevel.Feet ?? default(int),
                IVFR = cruiseLevel.IVFR,
                Meter = cruiseLevel.Meter ?? default(int),
                Track = cruiseLevel.Track
            };
        }

        public static List<CruiseLevelView> ToBlView(this IEnumerable<CruiseLevel> cruiseLevel)
        {
            return new List<CruiseLevelView>(cruiseLevel.Select(i => i.ToBlView()));
        }

        public static List<CruiseLevel> ToEntity(this IEnumerable<CruiseLevelView> cruiseLevel)
        {
            return new List<CruiseLevel>(cruiseLevel.Select(i => i.ToEntity()));
        }
        #endregion

        #region AirportsCodes

        public static AirportCode ToEntity(this AirportCodeView code)
        {
            return new AirportCode
            {
                Id = code.Id,
                IsDeleted = code.IsDeleted,
                FullName = code.FullName,
                City = code.City,
                Country = code.Country,
                Iata = code.Iata,
                Icao = code.Icao,
                Iso = code.Iso
            };
        }

        public static AirportCodeView ToBlView(this AirportCode code)
        {
            return new AirportCodeView
            {
                Id = code.Id,
                IsDeleted = code.IsDeleted,
                FullName = code.FullName,
                City = code.City,
                Country = code.Country,
                Iata = code.Iata,
                Icao = code.Icao,
                Iso = code.Iso
            };
        }

        public static List<AirportCodeView> ToBlView(this IEnumerable<AirportCode> code)
        {
            return new List<AirportCodeView>(code.Select(i => i.ToBlView()));
        }

        public static List<AirportCode> ToEntity(this IEnumerable<AirportCodeView> code)
        {
            return new List<AirportCode>(code.Select(i => i.ToEntity()));
        }

        #endregion

        #region FlightNum

        public static FlightNum ToEntity(this FlightNumView flightnum)
        {
            return new FlightNum
            {
                Id = flightnum.Id,
                IsDeleted = flightnum.IsDeleted,
                FlightNumber = flightnum.FlightNumber
            };
        }

        public static FlightNumView ToBlView(this FlightNum flightnum)
        {
            return new FlightNumView()
            {
                Id = flightnum.Id,
                IsDeleted = flightnum.IsDeleted,
                FlightNumber = flightnum.FlightNumber ?? ""
            };
        }

        public static List<FlightNumView> ToBlView(this IEnumerable<FlightNum> flightnum)
        {
            return new List<FlightNumView>(flightnum.Select(i => i.ToBlView()));
        }

        public static List<FlightNum> ToEntity(this IEnumerable<FlightNumView> flightnum)
        {
            return new List<FlightNum>(flightnum.Select(i => i.ToEntity()));
        }
        #endregion

        #region Discrepancy

        public static Discrepancy ToEntity(this DiscrepancyView disc)
        {

            return new Discrepancy
            {

                Id = disc.Id,
                IsDeleted = disc.IsDeleted,
                FlightID = disc.FlightID,
                FilledBy = disc.FilledBy,
                Description = disc.Description,
                PilotRemarks = disc.PilotRemarks,
                ATAChapterID = disc.ATAChapter?.Id ?? -1,
                DirectiveId = disc.DirectiveId,
                Num = disc.Num,
                Remarks = disc.Remarks,
                EngineRemarks = disc.EngineRemarks,
                EngineShutUp = disc.EngineShutUp,
                BaseComponentId = disc.BaseComponentId,
                FDR = disc.FDR,
                AuthId = disc.Auth?.Id ?? -1,
                Messages = disc.Messages,
                WorkPackageId = disc.WorkPackageId,
                IsReliability = disc.IsReliability,
                Status = (int)disc.Status,
                IsOccurrence = disc.IsOccurrence,
                Substruction = disc.Substruction,
                TimeDelay = disc.TimeDelay,
                ConsequenceType = disc.ConsequenceType?.ItemId ?? -1,
                DeffectConfirm = disc.DeffectConfirm?.ItemId ?? -1,
                DeffeсtPhase = disc.DeffeсtPhase?.ItemId ?? -1,
                DeffeсtCategory = disc.DeffeсtCategory?.ItemId ?? -1,
                ActionType = disc.ActionType?.ItemId ?? -1,
                InterruptionType = disc.InterruptionType?.ItemId ?? -1,
                ConsequenceOps = disc.ConsequenceOps?.ItemId ?? -1,
                Occurrence = disc.Occurrence?.ItemId ?? -1,
                ConsequenceFault = disc.ConsequenceFault?.ItemId ?? -1,
                CorrectiveAction = disc.CorrectiveAction?.ToEntity()
            };
        }

        public static DiscrepancyView ToBlView(this Discrepancy disc)
        {
            return new DiscrepancyView()

            {
                Id = disc.Id,
                IsDeleted = disc.IsDeleted,
                FlightID = disc.FlightID,
                IsReliability = disc.IsReliability,
                IsOccurrence = disc.IsOccurrence,
                Substruction = disc.Substruction,
                FilledBy = disc.FilledBy,
                BaseComponentId = disc.BaseComponentId,
                Description = disc.Description,
                Remarks = disc.Remarks,
                EngineRemarks = disc.EngineRemarks,
                EngineShutUp = disc.EngineShutUp,
                FDR = disc.FDR,
                Status = (CorrectiveActionStatus)disc.Status,
                Messages = disc.Messages,
                Auth = disc.Auth?.ToBlView(),
                PilotRemarks = disc.PilotRemarks,
                ATAChapter = disc.ATAChapter?.ToBlView(),
                DirectiveId = disc.DirectiveId,
                Num = disc.Num ?? default(int),
                WorkPackageId = disc.WorkPackageId ?? default(int),
                TimeDelay = disc.TimeDelay,
                Occurrence = OccurrenceType.GetItemById(disc.Occurrence),
                DeffectConfirm = DeffectConfirm.GetItemById(disc.DeffectConfirm),
                InterruptionType = InterruptionType.GetItemById(disc.InterruptionType),
                DeffeсtPhase = DeffeсtPhase.GetItemById(disc.DeffeсtPhase),
                DeffeсtCategory = DeffeсtCategory.GetItemById(disc.DeffeсtCategory),
                ActionType = ActionType.GetItemById(disc.ActionType),
                ConsequenceOps = ConsequenceOPS.GetItemById(disc.ConsequenceOps),
                ConsequenceFault = ConsequenceFaults.GetItemById(disc.ConsequenceFault),
                ConsequenceType = IncidentType.GetItemById(disc.ConsequenceType),
                CorrectiveAction = disc.CorrectiveAction?.ToBlView(),
                ATAChapterID = disc.ATAChapterID
                

            };
            
        }

        public static List<DiscrepancyView> ToBlView(this IEnumerable<Discrepancy> disc)
        {
            return new List<DiscrepancyView>(disc.Select(i => i.ToBlView()));
        }

        public static List<Discrepancy> ToEntity(this IEnumerable<DiscrepancyView> disc)
        {
            return new List<Discrepancy>(disc.Select(i => i.ToEntity()));
        }

        #endregion

        #region AtaChapter

        public static ATAChapter ToEntity(this ATAChapterView ataChapter)
        {
            return new ATAChapter
            {
                Id = ataChapter.Id,
                IsDeleted = ataChapter.IsDeleted,
                FullName = ataChapter.FullName,
                ShortName = ataChapter.ShortName
            };
        }

        public static ATAChapterView ToBlView(this ATAChapter ataChapter)
        {
            return new ATAChapterView()
            {
                Id = ataChapter.Id,
                IsDeleted = ataChapter.IsDeleted,
                FullName = ataChapter.FullName,
                ShortName = ataChapter.ShortName
            };
        }

        public static List<ATAChapterView> ToBlView(this IEnumerable<ATAChapter> ataChapter)
        {
            return new List<ATAChapterView>(ataChapter.Select(i => i.ToBlView()));
        }

        public static List<ATAChapter> ToEntity(this IEnumerable<ATAChapterView> ataChapter)
        {
            return new List<ATAChapter>(ataChapter.Select(i => i.ToEntity()));
        }

        #endregion

        #region CorrectiveAction

        public static CorrectiveAction ToEntity(this CorrectiveActionView coract)
        {
            return new CorrectiveAction()
            {
                Id = coract.Id,
                IsDeleted = coract.IsDeleted,
                DiscrepancyID = coract.DiscrepancyID,
                Description = coract.Description,
                ShortDescription = coract.ShortDescription,
                ADDNo = coract.ADDNo,
                IsClosed = coract.IsClosed,
                PartNumberOff = coract.PartNumberOff,
                SerialNumberOff = coract.SerialNumberOff,
                PartNumberOn = coract.PartNumberOn,
                SerialNumberOn = coract.SerialNumberOn,
                CRSID = coract.CRSID

            };
        }

        public static CorrectiveActionView ToBlView(this CorrectiveAction coract)
        {
            return new CorrectiveActionView()
            {
                Id = coract.Id,
                IsDeleted = coract.IsDeleted,
                DiscrepancyID = coract.DiscrepancyID,
                Description = coract.Description,
                ShortDescription = coract.ShortDescription,
                ADDNo = coract.ADDNo,
                IsClosed = coract.IsClosed,
                PartNumberOff = coract.PartNumberOff,
                SerialNumberOff = coract.SerialNumberOff,
                PartNumberOn = coract.PartNumberOn,
                SerialNumberOn = coract.SerialNumberOn,
                CRSID = coract.CRSID,
                CertificateOfReleaseToService = coract.CertificateOfReleaseToService?.ToBlView()
            };
        }

        public static List<CorrectiveActionView> ToBlView(this IEnumerable<CorrectiveAction> coract)
        {
            return new List<CorrectiveActionView>(coract.Select(i => i.ToBlView()));
        }

        public static List<CorrectiveAction> ToEntity(this IEnumerable<CorrectiveActionView> coract)
        {
            return new List<CorrectiveAction>(coract.Select(i => i.ToEntity()));
        }

		#endregion

		#region CertificateOfReleaseToService

		public static CertificateOfReleaseToService ToEntity(this CertificateOfReleaseToServiceView corts)
        {

            return new CertificateOfReleaseToService
            {
                Id = corts.Id,
                IsDeleted = corts.IsDeleted,
                Station = corts.Station,
                RecordDate = corts.RecordDate,
                CheckPerformed = corts.CheckPerformed,
                Reference = corts.Reference,
                AuthorizationB1Id = corts.AuthorizationB1Id,
                AuthorizationB2Id = corts.AuthorizationB2Id
            };
        }


        public static CertificateOfReleaseToServiceView ToBlView(this CertificateOfReleaseToService corts)

        {
            return new CertificateOfReleaseToServiceView()
            {
                Id = corts.Id,
                IsDeleted = corts.IsDeleted,
                Station = corts.Station,
                RecordDate = corts.RecordDate ?? DateTimeExtend.GetCASMinDateTime(),
                CheckPerformed = corts.CheckPerformed,
                Reference = corts.Reference,
                AuthorizationB1Id = corts.AuthorizationB1Id,
                AuthorizationB2Id = corts.AuthorizationB2Id
            };
        }

        public static List<CertificateOfReleaseToServiceView> ToBlView(this IEnumerable<CertificateOfReleaseToService> coract)
        {
            return new List<CertificateOfReleaseToServiceView>(coract.Select(i => i.ToBlView()));
        }

        public static List<CertificateOfReleaseToService> ToEntity(this IEnumerable<CertificateOfReleaseToServiceView> coract)
        {
            return new List<CertificateOfReleaseToService>(coract.Select(i => i.ToEntity()));
        }

		#endregion

		#region InitialOrder

		public static InitialOrder ToEntity(this InitialOrderView init)
		{

			return new InitialOrder
			{
				Id = init.Id,
				IsDeleted = init.IsDeleted,
				Title = init.Title,
				PublishedById = init.PublishedById,
				ClosedById = init.ClosedById,
				Description = init.Description,
				Author = init.Author,
				ParentId = init.ParentId,
				ParentTypeId = init.ParentTypeId,
				Status = init.Status,
				OpeningDate = init.OpeningDate,
				PublishingDate = init.PublishingDate,
				ClosingDate = init.ClosingDate,
				Remarks = init.Remarks,
				PublishedByUser = init.PublishedByUser,
				CloseByUser = init.CloseByUser,
				Number = init.Number
			};
		}


		public static InitialOrderView ToBlView(this InitialOrder init)

		{
			return new InitialOrderView()
			{
				Id = init.Id,
				IsDeleted = init.IsDeleted,
				Title = init.Title,
				PublishedById = init.PublishedById,
				ClosedById = init.ClosedById,
				Description = init.Description,
				Author = init.Author,
				ParentId = init.ParentId,
				ParentTypeId = init.ParentTypeId,
				Status = init.Status,
				OpeningDate = init.OpeningDate,
				PublishingDate = init.PublishingDate,
				ClosingDate = init.ClosingDate,
				Remarks = init.Remarks,
				PublishedByUser = init.PublishedByUser,
				CloseByUser = init.CloseByUser,
				Number = init.Number
			};
		}

		public static List<InitialOrderView> ToBlView(this IEnumerable<InitialOrder> init)
		{
			return new List<InitialOrderView>(init.Select(i => i.ToBlView()));
		}

		public static List<InitialOrder> ToEntity(this IEnumerable<InitialOrderView> init)
		{
			return new List<InitialOrder>(init.Select(i => i.ToEntity()));
		}

		#endregion

		#region InitialOrderRecord

		public static InitialOrderRecord ToEntity(this InitialOrderRecordView orderrec)
		{

			return new InitialOrderRecord
			{
				Id = orderrec.Id,
				IsDeleted = orderrec.IsDeleted,
				InitialReason = orderrec.InitialReason,
				Priority = orderrec.Priority,
				DestinationObjectID = orderrec.DestinationObjectID,
				DestinationObjectType = orderrec.DestinationObjectType,
				Measure = orderrec.Measure,
				Quantity = orderrec.Quantity,
				DefferedCategory = orderrec.DefferedCategory,
				EffectiveDate = orderrec.EffectiveDate,
				LifeLimit = orderrec.LifeLimit,
				LifeLimitNotify = orderrec.LifeLimitNotify,
				Processed = orderrec.Processed,
				ParentPackageId = orderrec.ParentPackageId,
				PackageItemId = orderrec.PackageItemId,
				PackageItemTypeId = orderrec.PackageItemTypeId,
				CostCondition = orderrec.CostCondition,
				ProductId = orderrec.ProductId,
				ProductType = orderrec.ProductType,
				PerfNumFromStart = orderrec.PerfNumFromStart,
				PerfNumFromRecord = orderrec.PerfNumFromRecord,
				FromRecordId = orderrec.FromRecordId,
				IsClosed = orderrec.IsClosed,
				IsSchedule = orderrec.IsSchedule,
				Remarks = orderrec.Remarks
			};
		}


		public static InitialOrderRecordView ToBlView(this InitialOrderRecord orderrec)

		{
			return new InitialOrderRecordView()
			{
				Id = orderrec.Id,
				IsDeleted = orderrec.IsDeleted,
				InitialReason = orderrec.InitialReason,
				Priority = orderrec.Priority,
				DestinationObjectID = orderrec.DestinationObjectID,
				DestinationObjectType = orderrec.DestinationObjectType,
				Measure = orderrec.Measure,
				Quantity = orderrec.Quantity,
				DefferedCategory = orderrec.DefferedCategory,
				EffectiveDate = orderrec.EffectiveDate,
				LifeLimit = orderrec.LifeLimit,
				LifeLimitNotify = orderrec.LifeLimitNotify,
				Processed = orderrec.Processed,
				ParentPackageId = orderrec.ParentPackageId,
				PackageItemId = orderrec.PackageItemId,
				PackageItemTypeId = orderrec.PackageItemTypeId,
				CostCondition = orderrec.CostCondition,
				ProductId = orderrec.ProductId,
				ProductType = orderrec.ProductType,
				PerfNumFromStart = orderrec.PerfNumFromStart,
				PerfNumFromRecord = orderrec.PerfNumFromRecord,
				FromRecordId = orderrec.FromRecordId,
				IsClosed = orderrec.IsClosed,
				IsSchedule = orderrec.IsSchedule,
				Remarks = orderrec.Remarks
			};
		}

		public static List<InitialOrderRecordView> ToBlView(this IEnumerable<InitialOrderRecord> init)
		{
			return new List<InitialOrderRecordView>(init.Select(i => i.ToBlView()));
		}

		public static List<InitialOrderRecord> ToEntity(this IEnumerable<InitialOrderRecordView> init)
		{
			return new List<InitialOrderRecord>(init.Select(i => i.ToEntity()));
		}

		#endregion

		#region RequestForQuotation

		public static RequestForQuotation ToEntity(this RequestForQuotationView quot)
		{

			return new RequestForQuotation
			{
				Id = quot.Id,
				IsDeleted = quot.IsDeleted,
				PublishedById = quot.PublishedById,
				ClosedById = quot.ClosedById,
				Title = quot.Title,
				Description = quot.Description,
				ParentId = quot.ParentId,
				Status = quot.Status,
				OpeningDate = quot.OpeningDate,
				PublishingDate = quot.PublishingDate,
				ClosingDate = quot.ClosingDate,
				Author = quot.Author,
				Remarks = quot.Remarks,
				PublishedByUser = quot.PublishedByUser,
				CloseByUser = quot.CloseByUser,
				ParentTypeId = quot.ParentTypeId,
				Number = quot.Number
			};
		}


		public static RequestForQuotationView ToBlView(this RequestForQuotation quot)

		{
			return new RequestForQuotationView()
			{
				Id = quot.Id,
				IsDeleted = quot.IsDeleted,
				PublishedById = quot.PublishedById,
				ClosedById = quot.ClosedById,
				Title = quot.Title,
				Description = quot.Description,
				ParentId = quot.ParentId,
				Status = quot.Status,
				OpeningDate = quot.OpeningDate,
				PublishingDate = quot.PublishingDate,
				ClosingDate = quot.ClosingDate,
				Author = quot.Author,
				Remarks = quot.Remarks,
				PublishedByUser = quot.PublishedByUser,
				CloseByUser = quot.CloseByUser,
				ParentTypeId = quot.ParentTypeId,
				Number = quot.Number,
			};
		}

		public static List<RequestForQuotationView> ToBlView(this IEnumerable<RequestForQuotation> init)
		{
			return new List<RequestForQuotationView>(init.Select(i => i.ToBlView()));
		}

		public static List<RequestForQuotation> ToEntity(this IEnumerable<RequestForQuotationView> init)
		{
			return new List<RequestForQuotation>(init.Select(i => i.ToEntity()));
		}

		#endregion

		#region PurchaseOrder

		public static PurchaseOrder ToEntity(this PurchaseOrderView purchase)
		{

			return new PurchaseOrder
			{
				Id = purchase.Id,
				IsDeleted = purchase.IsDeleted,
				Title = purchase.Title,
				Description = purchase.Description,
				ParentID = purchase.ParentID,
				ParentQuotationId = purchase.ParentQuotationId,
				Status = (int?) purchase.Status,
				OpeningDate = purchase.OpeningDate,
				PublishingDate = purchase.PublishingDate,
				ClosingDate = purchase.ClosingDate,
				Author = purchase.Author,
				Remarks = purchase.Remarks,
				ParentTypeId = purchase.ParentTypeId,
				SupplierId = purchase.SupplierId,
				PublishedById = purchase.PublishedById,
				ClosedById = purchase.ClosedById,
				PublishedByUser = purchase.PublishedByUser,
				CloseByUser = purchase.CloseByUser,
				Number = purchase.Number
			};
		}


		public static PurchaseOrderView ToBlView(this PurchaseOrder purchase)

		{
			return new PurchaseOrderView()
			{
				Id = purchase.Id,
				IsDeleted = purchase.IsDeleted,
				Title = purchase.Title,
				Description = purchase.Description,
				ParentID = purchase.ParentID ?? default(int),
				ParentQuotationId = purchase.ParentQuotationId ?? default(int),
				Status = purchase.Status.HasValue ? (WorkPackageStatus)purchase.Status.Value : WorkPackageStatus.All,
				OpeningDate = purchase.OpeningDate ?? DateTimeExtend.GetCASMinDateTime(),
				PublishingDate = purchase.PublishingDate ?? DateTimeExtend.GetCASMinDateTime(),
				ClosingDate = purchase.ClosingDate ?? DateTimeExtend.GetCASMinDateTime(),
				Author = purchase.Author,
				Remarks = purchase.Remarks,
				ParentTypeId = purchase.ParentTypeId,
				PublishedById = purchase.PublishedById,
				ClosedById = purchase.ClosedById,
				PublishedByUser = purchase.PublishedByUser,
				CloseByUser = purchase.CloseByUser,
				Number = purchase.Number
			};
		}

		public static List<PurchaseOrderView> ToBlView(this IEnumerable<PurchaseOrder> init)
		{
			return new List<PurchaseOrderView>(init.Select(i => i.ToBlView()));
		}

		public static List<PurchaseOrder> ToEntity(this IEnumerable<PurchaseOrderView> init)
		{
			return new List<PurchaseOrder>(init.Select(i => i.ToEntity()));
		}

		#endregion
	}
}