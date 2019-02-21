﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.Dictionaries;

namespace Entity.Models.General
{
    [Table("Components", Schema = "dbo")]
    public class Component : BaseEntity
    {
        [Column("ComponentCount")]
        public int ComponentCount { get; set; }

        [Column("AverageUtilization")]
        [MaxLength(50)]
        public byte[] AverageUtilization { get; set; }

        [Column("Acceleration")]
        public int? Acceleration { get; set; }

        [Column("AccelerationAir")]
        public int? AccelerationAir { get; set; }

        [Column("JobCardsID")]
        public int JobCardsID { get; set; }

        [Column("EOFileId")]
        public int? EOFileId { get; set; }

        [Column("OldId")]
        public int? OldId { get; set; }

        [Column("Thrust")]
        [MaxLength(128)]
        public string Thrust { get; set; }

        [Column("BaseComponentTypeId")]
        public int BaseComponentTypeId { get; set; }

        [Column("ComponentType")]
        public int ComponentType { get; set; }

        [Column("ComponentLabel")]
        public int? ComponentLabel { get; set; }

        [Column("QuantityIn")]
        public int? QuantityIn { get; set; }

        [Column("ATAChapter")]
        public int? ATAChapterId { get; set; }

        [Column("PartNumber")]
        [MaxLength(128)]
        public string PartNumber { get; set; }

        [Column("Description")]
        [MaxLength(250)]
        public string Description { get; set; }

        [Column("SerialNumber")]
        [MaxLength(128)]
        public string SerialNumber { get; set; }

        [Column("BatchNumber")]
        [MaxLength(128)]
        public string BatchNumber { get; set; }

        [Column("IdNumber")]
        [MaxLength(128)]
        public string IdNumber { get; set; }

        [Column("MaintenanceType")]
        public int MaintenanceType { get; set; }

        [Column("Remarks")]
        public string Remarks { get; set; }

        [Column("Model")]
        public int? ModelId { get; set; }

        [Column("Manufacturer")]
        [MaxLength(128)]
        public string Manufacturer { get; set; }

        [Column("ManufactureDate")]
        public DateTime? ManufactureDate { get; set; }

        [Column("DeliveryDate")]
        public DateTime? DeliveryDate { get; set; }

        [Column("Lifelength")]
        [MaxLength(21)]
        public byte[] Lifelength { get; set; }

        [Column("LLPMark")]
        public bool LLPMark { get; set; }

        [Column("LLPCategories")]
        public bool LLPCategories { get; set; }

        [Column("LandingGear")]
        public short LandingGear { get; set; }

        [Column("AvionicsInventory")]
        public short AvionicsInventory { get; set; }

        [Column("ALTPN")]
        [MaxLength(128)]
        public string ALTPN { get; set; }

        [Column("MTOGW")]
        [MaxLength(128)]
        public string MTOGW { get; set; }

        [Column("HushKit")]
        [MaxLength(128)]
        public string HushKit { get; set; }

        [Column("Cost")]
        public double? Cost { get; set; }

        [Column("CostServiceable")]
        public double? CostServiceable { get; set; }

        [Column("CostOverhaul")]
        public double? CostOverhaul { get; set; }

        [Column("Measure")]
        public int? Measure { get; set; }

        [Column("Quantity")]
        public double Quantity { get; set; }

        [Column("ManHours")]
        public double? ManHours { get; set; }

        [Column("FaaFormFileID")]
        public int? FaaFormFileID { get; set; }

        [Column("Warranty")]
        [MaxLength(21)]
        public byte[] Warranty { get; set; }

        [Column("WarrantyNotify")]
        [MaxLength(21)]
        public byte[] WarrantyNotify { get; set; }

        [Column("Serviceable")]
        public bool? Serviceable { get; set; }

        [Column("Type")]
        public int? Type { get; set; }

        [Column("ShelfLife")]
        [MaxLength(50)]
        public string ShelfLife { get; set; }

        [Column("ExpirationDate")]
        public DateTime? ExpirationDate { get; set; }

        [Column("NotificationDate")]
        public DateTime? NotificationDate { get; set; }

        [Column("Highlight")]
        public int? Highlight { get; set; }

        [Column("MPDItem")]
        [MaxLength(50)]
        public string MPDItem { get; set; }

        [Column("HiddenRemarks")]
        public string HiddenRemarks { get; set; }

        [Column("Supplier")]
        [MaxLength(50)]
        public string Supplier { get; set; }

        [Column("LifeLimit")]
        [MaxLength(21)]
        public byte[] LifeLimit { get; set; }

        [Column("LifeLimitNotify")]
        [MaxLength(21)]
        public byte[] LifeLimitNotify { get; set; }

        [Column("KitRequired")]
        [MaxLength(50)]
        public string KitRequired { get; set; }

        [Column("StartLifelength")]
        [MaxLength(21)]
        public byte[] StartLifelength { get; set; }

        [Column("StartDate")]
        public DateTime? StartDate { get; set; }

        [Column("Code")]
        [MaxLength(256)]
        public string Code { get; set; }

        [Column("Status")]
        public short? Status { get; set; }

        [Column("IsBaseComponent")]
        public bool IsBaseComponent { get; set; }

        [Column("LocationId")]
        public int LocationId { get; set; }

        [Column("Incoming")]
        public bool Incoming { get; set; }

        [Column("Discrepancy")]
        [MaxLength(250)]
        public string Discrepancy { get; set; }

        [Column("IsPool")]
        public bool IsPool { get; set; }

        [Column("IsDangerous")]
        public bool IsDangerous { get; set; }

        [Column("QuantityInput")]
        public double? QuantityInput { get; set; }

        [Column("FromSupplierId")]
        public int FromSupplierId { get; set; }

        [Column("FromSupplierReciveDate")]
        public DateTime? FromSupplierReciveDate { get; set; }

        
        public ATAChapter ATAChapter { get; set; }

        public AccessoryDescription Model { get; set; }

        public Location Location { get; set; }

        public Supplier FromSupplier { get; set; }

        public ICollection<ComponentLLPCategoryData> LLPData { get; set; }

        
        //[Child(FilterType.Equal, "ParentTypeId", 5)]
        public ICollection<CategoryRecord> CategoriesRecords { get; set; }

       //[Child(FilterType.Equal, "ParentTypeId", new[] { 5, 6 })]
        public ICollection<KitSuppliersRelation> SupplierRelations { get; set; }
        
        //[Child(FilterType.Equal, "ParentTypeId", 5)]
        public ICollection<ItemFileLink> Files { get; set; }

        //[Child(FilterType.Equal, "ParentTypeId", new[] { 5, 6 })]
        public ICollection<AccessoryRequired> Kits { get; set; }

        public ICollection<ActualStateRecord> ActualStateRecords { get; set; }

        public ICollection<TransferRecord> TransferRecords { get; set; }

        public ICollection<ComponentDirective> ComponentDirectives { get; set; }

        public ICollection<ComponentLLPCategoryChangeRecord> ChangeLLPCategoryRecords { get; set; }


        #region Navigation

        public ICollection<Directive> Directives { get; set; }

        public ICollection<MaintenanceDirective> MaintenanceDirectives { get; set; }

        #endregion
    }
}