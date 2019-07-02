using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Dictionaties;
using Entity.Models.Dictionaries;
using Entity.Models.General;
using Newtonsoft.Json;

namespace BusinessLayer.Views
{
    public class ComponentView : BaseView
    {
	    private List<ItemFileLink> _files;
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

        public double QuantityIn { get; set; }

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

        public double Cost { get; set; }

        public double? CostServiceable { get; set; }

        public double? CostOverhaul { get; set; }

        public int? Measure { get; set; }

        public double Quantity { get; set; }
        public string QuantityInString => (IsComponent ? 1.ToString() : $"{QuantityIn:0.##} ") + $" {MeasureView}(s)";

        public bool IsComponent
        {
	        get
	        {
		        return GoodsClass.IsNodeOrSubNodeOf(GoodsClass.ComponentsAndParts) || 
		        GoodsClass.IsNodeOrSubNodeOf(GoodsClass.ProductionAuxiliaryEquipment);
			}
        }

        public double ManHours { get; set; }

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

        public IProductView Model { get; set; }

        public DateTime? FromSupplierReciveDate { get; set; }

        public ATAChapterView ATAChapter { get; set; }
        public string ATAChapterString => Model != null ? Model.AtaChapter?.ToString() : ATAChapter?.ToString();

        public LocationView Location { get; set; }

        public SupplierView FromSupplier { get; set; }

        public List<TransferRecordView> TransferRecords { get; set; }

        public StoreView ParentStore { get; set; }

        public GoodsClass GoodsClass
        {
	        get
	        {
				return Type.HasValue ? GoodsClass.GetItemById(Type.Value) : GoodsClass.Unknown;
	        }
        }

		[JsonIgnore]
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

        public Measure MeasureView
        {
	        get
	        {
		        return Measure.HasValue
			        ? Dictionaties.Measure.GetItemById(Measure.Value)
			        : Dictionaties.Measure.Unknown;
	        }
        }

        public int ShippingFileId { get; set;}
        public int CRSFileId { get; set; }

		public double Current { get; set; }
		public double ShouldBeOnStock { get; set; }
		public string ShouldBeOnStockString => ShouldBeOnStock > 0 ? "Yes" : "No";
		public string ReferenceProduct => Model?.Reference;
		public string AltPartNumberProduct => Model?.AltPartNumber;
		public string StandardProduct => Model?.StandardString;
		public string ModelProduct => Model?.Model;

		public List<ItemFileLink> Files
		{
			get => _files ?? (_files = new List<ItemFileLink>());
			set => _files = value;
		}
    }
}