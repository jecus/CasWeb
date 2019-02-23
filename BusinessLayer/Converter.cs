﻿using System.Collections.Generic;
using System.Linq;
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
                ItemId = agwCategory.ItemId,
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
                ItemId = agwCategorie.ItemId,
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
                ItemId = aircraft.ItemId,
                IsDeleted = aircraft.IsDeleted,
                AircraftFrameId = aircraft.AircraftFrameId,
                OperatorID = aircraft.OperatorID,
                APUFH = aircraft.APUFH,
                AircraftTypeID = aircraft.AircraftTypeID,
                ModelId = aircraft.Model?.ItemId,
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
                ItemId = aircraft.ItemId,
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
                ItemId = department.ItemId,
                IsDeleted = department.IsDeleted,
                Name = department.Name,
                FullName = department.FullName
            };
        }

        public static DepartmentView ToBlView(this Department department)
        {
            return new DepartmentView()
            {
                ItemId = department.ItemId,
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

        #region Component

        public static Component ToEntity(this BaseComponentView com)
        {
            return new Component
            {
                ItemId = com.ItemId,
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

        public static BaseComponentView ToBlView(this Component com)
        {
            return new BaseComponentView()
            {
                ItemId = com.ItemId,
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

        public static List<BaseComponentView> ToBlView(this IEnumerable<Component> component)
        {
            return new List<BaseComponentView>(component.Select(i => i.ToBlView()));
        }

        public static List<Component> ToEntity(this IEnumerable<BaseComponentView> component)
        {
            return new List<Component>(component.Select(i => i.ToEntity()));
        }

        #endregion

        #region Document

        public static Document ToEntity(this DocumentView document)
        {
            return new Document
            {
                ItemId = document.ItemId,
                IsDeleted = document.IsDeleted,
                ParentID = document.ParentID,
                ParentTypeId = document.ParentTypeId,
                DocTypeId = document.DocTypeId,
                SubTypeId = document.DocumentSubType?.ItemId ?? -1,
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
                DepartmentId = document.Department?.ItemId,
                RevisionValidTo = document.RevisionValidTo,
                RevisionDateValidTo = document.RevisionDateValidTo,
                RevisionNotify = document.RevisionNotify,
                Aboard = document.Aboard,
                Privy = document.Privy,
                IssueNumber = document.IssueNumber,
                NomenсlatureId = document.Nomenсlature?.ItemId,
                ProlongationWay = document.ProlongationWay,
                ServiceTypeId = document.ServiceType?.ItemId,
                ResponsibleOccupationId = document.ResponsibleOccupation?.ItemId ?? -1,
                Remarks = document.Remarks,
                LocationId = document.Location?.ItemId ?? -1,
                SupplierId = document.Supplier?.ItemId ?? -1,
                ParentAircraftId = document.ParentAircraftId,
                IdNumber = document.IdNumber,

            };
        }

        public static DocumentView ToBlView(this Document document)
        {
            var doc = new DocumentView()
            {
                ItemId = document.ItemId,
                IsDeleted = document.IsDeleted,
                ParentID = document.ParentID,
                ParentTypeId = document.ParentTypeId,
                DocTypeId = document.DocTypeId,
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
                ProlongationWay = document.ProlongationWay,
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
                ItemId = documentsubtype.ItemId,
                IsDeleted = documentsubtype.IsDeleted,
                Name = documentsubtype.Name,
                DocumentTypeId = documentsubtype.DocumentTypeId,
            };
        }

        public static DocumentSubTypeView ToBlView(this DocumentSubType documentsubtype)
        {
            return new DocumentSubTypeView()
            {
                ItemId = documentsubtype.ItemId,
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
                ItemId = location.ItemId,
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
                ItemId = location.ItemId,
                IsDeleted = location.IsDeleted,
                Name = location.Name,
                FullName = location.FullName,
                LocationsTypeId = location.LocationsTypeId
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
                ItemId = locationsType.ItemId,
                IsDeleted = locationsType.IsDeleted,
                FullName = locationsType.FullName,
                Name = locationsType.Name,
            };

        }

        public static LocationsTypeView ToBlView(this LocationsType locationsType)
        {
            return new LocationsTypeView()
            {
                ItemId = locationsType.ItemId,
                IsDeleted = locationsType.IsDeleted,
                FullName = locationsType.FullName,
                Name = locationsType.Name,
                DepartmentId = locationsType.Department?.ItemId ?? -1
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

        #region AccessoryDescription

        public static AccessoryDescription ToEntity(this ModelView acc)
        {
            return new AccessoryDescription
            {
                ItemId = acc.ItemId,
                IsDeleted = acc.IsDeleted,
                ShortName = acc.ShortName,
                FullName = acc.FullName
            };
        }

        public static ModelView ToBlView(this AccessoryDescription acc)
        {
            return new ModelView()
            {
                ItemId = acc.ItemId,
                IsDeleted = acc.IsDeleted,
                ShortName = acc.ShortName,
                FullName = acc.FullName
            };
        }

        public static List<ModelView> ToBlView(this IEnumerable<AccessoryDescription> models)
        {
            return new List<ModelView>(models.Select(i => i.ToBlView()));
        }

        public static List<AccessoryDescription> ToEntity(this IEnumerable<ModelView> models)
        {
            return new List<AccessoryDescription>(models.Select(i => i.ToEntity()));
        }

        #endregion

        #region Nomenclature

        public static Nomenclature ToEntity(this NomenclatureView nomenclature)
        {
            return new Nomenclature
            {
                ItemId = nomenclature.ItemId,
                IsDeleted = nomenclature.IsDeleted,
                Name = nomenclature.Name,
                FullName = nomenclature.FullName
            };
        }

        public static NomenclatureView ToBlView(this Nomenclature nomenclature)
        {
            return new NomenclatureView()
            {
                ItemId = nomenclature.ItemId,
                IsDeleted = nomenclature.IsDeleted,
                Name = nomenclature.Name,
                FullName = nomenclature.FullName,
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
                ItemId = oper.ItemId,
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
                ItemId = oper.ItemId,
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
                ItemId = servicetype.ItemId,
                IsDeleted = servicetype.IsDeleted,
                Name = servicetype.Name,
                FullName = servicetype.FullName
            };
        }

        public static ServiceTypeView ToBlView(this ServiceType servicetype)
        {
            return new ServiceTypeView()
            {
                ItemId = servicetype.ItemId,
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
                ItemId = specialist.ItemId,
                IsDeleted = specialist.IsDeleted,
                FirstName = specialist.FirstName,
                ShortName = specialist.ShortName,
                SpecializationID = specialist.Specialization?.ItemId ?? -1,
                LastName = specialist.LastName,
                Gender = (short?) specialist.Gender,
                AGWCategoryId = specialist.AGWCategory?.ItemId,
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
                Location = (short) (specialist.Facility?.ItemId ?? -1),
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
                ItemId = specialist.ItemId,
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
                ItemId = specialization.ItemId,
                IsDeleted = specialization.IsDeleted,
                ShortName = specialization.ShortName,
                FullName = specialization.FullName,
                DepartmentId = specialization.Department?.ItemId ?? -1,
                Level = specialization.Level,
                KeyPersonel = specialization.KeyPersonel,
            };
        }

        public static SpecializationView ToBlView(this Specialization specialization)
        {
            return new SpecializationView()
            {
                ItemId = specialization.ItemId,
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
                ItemId = store.ItemId,
                IsDeleted = store.IsDeleted,
                StoreName = store.StoreName
            };
        }

        public static StoreView ToBlView(this Store store)
        {
            return new StoreView()
            {
                ItemId = store.ItemId,
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
                ItemId = supplier.ItemId,
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
                ItemId = supplier.ItemId,
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

        #region TransferRecord

        public static TransferRecord ToEntity(this TransferRecordView transrec)
        {
            return new TransferRecord
            {
                ItemId = transrec.ItemId,
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

                ItemId = transrec.ItemId,
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
                ItemId = user.ItemId,
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
                ItemId = user.ItemId,
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
    }
}