using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Dictionaties;
using Entity.Enums;
using Entity.Models.Dictionaries;
using Entity.Models.General;

namespace BusinessLayer.Views
{
    public class ComponentView : BaseView
    {
	    public int ComponentCount { get; set; }

        public byte[] AverageUtilization { get; set; }

        public int? Acceleration { get; set; }

        public int? AccelerationAir { get; set; }

        public int JobCardsID { get; set; }

        public int? EOFileId { get; set; }

        public int? OldId { get; set; }

        public string Thrust { get; set; }

        public int BaseComponentTypeId { get; set; }

        public int ComponentType { get; set; }

        public int? ComponentLabel { get; set; }

        public int? QuantityIn { get; set; }

        public int? ATAChapterId { get; set; }

        public string PartNumber { get; set; }

        public string Description { get; set; }

        public string SerialNumber { get; set; }

        public string BatchNumber { get; set; }

        public string IdNumber { get; set; }

        public int MaintenanceType { get; set; }

        public string Remarks { get; set; }

        public int? ModelId { get; set; }

        public string Manufacturer { get; set; }

        public DateTime? ManufactureDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public byte[] Lifelength { get; set; }

        public bool LLPMark { get; set; }

        public bool LLPCategories { get; set; }

        public LandingGearMarkType LandingGear { get; set; }

        public short AvionicsInventory { get; set; }

        public string ALTPN { get; set; }

        public string MTOGW { get; set; }

        public string HushKit { get; set; }

        public double? Cost { get; set; }

        public double? CostServiceable { get; set; }

        public double? CostOverhaul { get; set; }

        public int? Measure { get; set; }

        public double Quantity { get; set; }

        public double? ManHours { get; set; }

        public int? FaaFormFileID { get; set; }

        public byte[] Warranty { get; set; }

        public byte[] WarrantyNotify { get; set; }

        public bool? Serviceable { get; set; }

        public int? Type { get; set; }

        public string ShelfLife { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public DateTime? NotificationDate { get; set; }

        public int? Highlight { get; set; }

        public string MPDItem { get; set; }

        public string HiddenRemarks { get; set; }

        public string Supplier { get; set; }

        public byte[] LifeLimit { get; set; }

        public byte[] LifeLimitNotify { get; set; }

        public string KitRequired { get; set; }

        public byte[] StartLifelength { get; set; }

        public DateTime? StartDate { get; set; }

        public string Code { get; set; }

        public ComponentStatus? Status { get; set; }

        public bool IsBaseComponent { get; set; }

        public int LocationId { get; set; }

        public bool Incoming { get; set; }

        public string Discrepancy { get; set; }

        public bool IsPool { get; set; }

        public bool IsDangerous { get; set; }

        public double? QuantityInput { get; set; }

        public int FromSupplierId { get; set; }

        public DateTime? FromSupplierReciveDate { get; set; }

        public ATAChapter ATAChapter { get; set; }

        public LocationView Location { get; set; }

        public SupplierView FromSupplier { get; set; }

        public List<TransferRecordView> TransferRecords { get; set; }


        public StoreView ParentStore { get; set; }

        public ComponentStorePosition State
        {
            get
            {
                if (TransferRecords.Count > 0)
                {
                    var last = TransferRecords.OrderBy(i => i.TransferDate).LastOrDefault();
                    return last.State.HasValue
                        ? ComponentStorePosition.GetItemById(last.State.Value)
                        : ComponentStorePosition.UNK;
                }
                return ComponentStorePosition.UNK;
            }

        }

        public int DocumentShippingId { get; set; }

        public int DocumentCRSId;
	}
}