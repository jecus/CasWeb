using System;

namespace BusinessLayer.Views
{
	public class InitialOrderRecordView : BaseView
	{
		public int? InitialReason { get; set; }

		public int Priority { get; set; }

		public int? DestinationObjectID { get; set; }

		public int? DestinationObjectType { get; set; }

		public int? Measure { get; set; }

		public double? Quantity { get; set; }

		public int? DefferedCategory { get; set; }

		public DateTime? EffectiveDate { get; set; }

		public byte[] LifeLimit { get; set; }

		public byte[] LifeLimitNotify { get; set; }

		public bool? Processed { get; set; }

		public int? ParentPackageId { get; set; }

		public int? PackageItemId { get; set; }

		public int? PackageItemTypeId { get; set; }

		public short? CostCondition { get; set; }

		public int? ProductId { get; set; }

		public int? ProductType { get; set; }

		public int? PerfNumFromStart { get; set; }

		public int? PerfNumFromRecord { get; set; }

		public int? FromRecordId { get; set; }

		public bool? IsClosed { get; set; }
		
		public bool? IsSchedule { get; set; }

		public string Remarks { get; set; }

		
		//public DefferedCategorie DeferredCategory { get; set; }

		#region Navigation Property

		public InitialOrderView InitialOrder { get; set; }

		#endregion
	}
}