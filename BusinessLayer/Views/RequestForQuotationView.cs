using System;
using System.Collections.Generic;
using Entity.Models.General;

namespace BusinessLayer.Views
{
	public class RequestForQuotationView : BaseView
	{
		public string Title { get; set; }

		public string Description { get; set; }

		public int? ParentId { get; set; }

		public int? Status { get; set; }

		public DateTime? OpeningDate { get; set; }

		public DateTime? PublishingDate { get; set; }

		public DateTime? ClosingDate { get; set; }

		public string Author { get; set; }

		public string Remarks { get; set; }

		public int? ParentTypeId { get; set; }

		public int? ToSupplierId { get; set; }

		public int? PublishedById { get; set; }

		public int? ClosedById { get; set; }

		public string PublishedByUser { get; set; }

		public string CloseByUser { get; set; }

		public string Number { get; set; }


		//public ICollection<ItemFileLink> Files { get; set; }

		public ICollection<RequestForQuotationRecord> PackageRecords { get; set; }
	}
}