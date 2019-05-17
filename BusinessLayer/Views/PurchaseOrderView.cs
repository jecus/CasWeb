using System;

namespace BusinessLayer.Views
{
	public class PurchaseOrderView : BaseView
	{
		public string Title { get; set; }

		public string Description { get; set; }

		public int? ParentID { get; set; }

		public int? ParentQuotationId { get; set; }

		public WorkPackageStatus? Status { get; set; }

		public DateTime? OpeningDate { get; set; }

		public DateTime? PublishingDate { get; set; }

		public DateTime? ClosingDate { get; set; }

		public string Author { get; set; }

		public string Remarks { get; set; }

		public int? ParentTypeId { get; set; }

		public int? SupplierId { get; set; }

		public int? PublishedById { get; set; }

		public int? ClosedById { get; set; }

		public string PublishedByUser { get; set; }

		public string CloseByUser { get; set; }

		public string Number { get; set; }


		//[Child(FilterType.Equal, "ParentTypeId", 1860)]
		//public ICollection<ItemFileLink> Files { get; set; }
	}
}