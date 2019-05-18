using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.General;

namespace Entity.Models.Dictionaries
{
    [Table("AccessoryDescriptions", Schema = "Dictionaries")]
    public class AccessoryDescription : BaseEntity
    {
        [Column("Description")]
        public string Description { get; set; }

        [Column("PartNumber")]
        [MaxLength(256)]
        public string PartNumber { get; set; }

        [Column("Standart")]
        public int? StandartId { get; set; }

        [Column("Manufacturer")]
        [MaxLength(256)]
        public string Manufacturer { get; set; }

        [Column("CostNew")]
        public double? CostNew { get; set; }

        [Column("CostOverhaul")]
        public double? CostOverhaul { get; set; }

        [Column("CostServiceable")]
        public double? CostServiceable { get; set; }

        [Column("Measure")]
        public int? Measure { get; set; }

        [Column("Remarks")]
        public string Remarks { get; set; }

        [Column("DefaultProduct")]
        [MaxLength(256)]
        public string DefaultProduct { get; set; }

        [Column("ModelingObjectTypeId")]
        public int ModelingObjectTypeId { get; set; }

        [Column("ModelingObjectSubTypeId")]
        public int? ModelingObjectSubTypeId { get; set; }

        [Column("Model")]
        [MaxLength(256)]
        public string Model { get; set; }

        [Column("SubModel")]
        [MaxLength(256)]
        public string SubModel { get; set; }

        [Column("FullName")]
        [MaxLength(256)]
        public string FullName { get; set; }

        [Column("ShortName")]
        [MaxLength(256)]
        public string ShortName { get; set; }

        [Column("Designer")]
        [MaxLength(256)]
        public string Designer { get; set; }

        [Column("Code")]
        [MaxLength(256)]
        public string Code { get; set; }

        [Column("AtaChapter")]
        public int? AtaChapterId { get; set; }

        [Column("ComponentClass")]
        public short? ComponentClass { get; set; }

        [Column("ComponentModel")]
        public int? ComponentModel { get; set; }

        [Column("ComponentType")]
        public int? ComponentType { get; set; }

        [Column("IsDangerous")]
        public bool IsDangerous { get; set; }

        [Column("DescRus")]
        public string DescRus { get; set; }

        [Column("HTS")]
        public string HTS { get; set; }

        [Column("Reference")]
        [MaxLength(128)]
        public string Reference { get; set; }

        [Column("AltPartNumber")]
        [MaxLength(256)]
		public string AltPartNumber { get; set; }

		[Column("IsEffectivity")]
		public string IsEffectivity { get; set; }

		public ATAChapter ATAChapter { get; set; }

        
        public GoodStandart GoodStandart { get; set; }

        
        //[Child(FilterType.Equal, "ParentTypeId", 1005)]
        //public ICollection<ItemFileLink> Files { get; set; }

        //[Child(FilterType.Equal, "ParentTypeId", 1005)]
        public ICollection<KitSuppliersRelation> SupplierRelations { get; set; }

        #region Navigation Property

        
        public ICollection<DamageChart> DamageCharts { get; set; }
        
        public ICollection<LifeLimitCategorie> LifeLimitCategories { get; set; }
        
        public ICollection<DefferedCategorie> DefferedCategories { get; set; }
        
        public ICollection<AccessoryRequired> AccessoryRequireds { get; set; }
        
        public ICollection<Aircraft> Aircrafts { get; set; }
        
        public ICollection<Component> Components { get; set; }
        
        public ICollection<Vehicle> Vehicles { get; set; }
        
        public ICollection<StockComponentInfo> StockComponentInfos { get; set; }
        
        public ICollection<SpecialistTraining> SpecialistTrainings { get; set; }
        
        public ICollection<SpecialistLicense> SpecialistLicenses { get; set; }
        
        public ICollection<FlightNumberAircraftModelRelation> FlightNumberAircraftModelRelations { get; set; }
        
        public ICollection<CategoryRecord> CategoryRecords { get; set; }

        #endregion
    }
}
