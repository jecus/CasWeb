using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("RequestsForQuotation", Schema = "dbo")]
    public class RequestForQuotation : BaseEntity
    {
        [Column("Title")]
        [MaxLength(256)]
        public string Title { get; set; }

        [Column("Description")]
        [MaxLength(256)]
        public string Description { get; set; }

        [Column("ParentId")]
        public int? ParentId { get; set; }

        [Column("Status")]
        public int? Status { get; set; }

        [Column("OpeningDate")]
        public DateTime? OpeningDate { get; set; }

        [Column("PublishingDate")]
        public DateTime? PublishingDate { get; set; }

        [Column("ClosingDate")]
        public DateTime? ClosingDate { get; set; }

        [Column("Author")]
        [MaxLength(256)]
        public string Author { get; set; }

        [Column("Remarks")]
        [MaxLength(256)]
        public string Remarks { get; set; }

        [Column("ParentTypeId")]
        public int? ParentTypeId { get; set; }

        [Column("ToSupplier")]
        public int? ToSupplierId { get; set; }

        [Column("RFQ")]
        [MaxLength(256)]
        public string RFQ { get; set; }

        [Column("QR")]
        [MaxLength(256)]
        public string QR { get; set; }

        [Column("PO")]
        [MaxLength(256)]
        public string PO { get; set; }

        [Column("Invoice")]
        [MaxLength(256)]
        public string Invoice { get; set; }

        [Column("ShipTo")]
        public string ShipTo { get; set; }

        [Column("PickUp")]
        public string PickUp { get; set; }

        [Column("Weight")]
        [MaxLength(256)]
        public string Weight { get; set; }

        [Column("DIMS")]
        [MaxLength(256)]
        public string DIMS { get; set; }

        [Column("TypeOfOperation")]
        public int TypeOfOperation { get; set; }

        [Column("ApprovedById")]
        public int? ApprovedById { get; set; }

        [Column("PublishedById")]
        public int? PublishedById { get; set; }

        [Column("ClosedById")]
        public int? ClosedById { get; set; }

        [Column("ShipBy")]
        public int ShipBy { get; set; }

        [Column("IncoTerm")]
        public int IncoTerm { get; set; }

        [Column("CountryId")]
        public int CountryId { get; set; }

        [Column("CarrierId")]
        public int? CarrierId { get; set; }

        
        public Supplier Supplier { get; set; }

        public Specialist ApprovedBy { get; set; }

        public Specialist PublishedBy { get; set; }

        public Specialist ClosedBy { get; set; }

        public Supplier ToSupplier { get; set; }

        //[Child(FilterType.Equal, "ParentTypeId", 1900)]
        //public ICollection<ItemFileLink> Files { get; set; }

        public ICollection<RequestForQuotationRecord> PackageRecords { get; set; }
    }
}