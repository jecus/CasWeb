using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("Requests", Schema = "dbo")]
    public class Request : BaseEntity
    {
        [Column("PreparedByDate")]
        public DateTime? PreparedByDate { get; set; }

        [Column("PreparedById")]
        public int? PreparedById { get; set; }

        [Column("CheckedByDate")]
        public DateTime? CheckedByDate { get; set; }

        [Column("CheckedById")]
        public int? CheckedById { get; set; }

        [Column("ApprovedByDate")]
        public DateTime? ApprovedByDate { get; set; }

        [Column("ApprovedById")]
        public int? ApprovedById { get; set; }

        [Column("RequestdHeader")]
        [MaxLength(256)]
        public string RequestdHeader { get; set; }

        [Column("RequestFooter")]
        [MaxLength(256)]
        public string RequestFooter { get; set; }

        [Column("Number")]
        [MaxLength(256)]
        public string Number { get; set; }

        [Column("Title")]
        [MaxLength(256)]
        public string Title { get; set; }

        [Column("Description")]
        [MaxLength(256)]
        public string Description { get; set; }

        [Column("ParentId")]
        public int? ParentId { get; set; }

        [Column("Status")]
        public short? Status { get; set; }

        [Column("CreateDate")]
        public DateTime? CreateDate { get; set; }

        [Column("OpeningDate")]
        public DateTime? OpeningDate { get; set; }

        [Column("PublishingDate")]
        public DateTime? PublishingDate { get; set; }

        [Column("ClosingDate")]
        public DateTime? ClosingDate { get; set; }

        [Column("FileId")]
        public int? FileId { get; set; }

        [Column("PublishedBy")]
        [MaxLength(256)]
        public string PublishedBy { get; set; }

        [Column("ClosedBy")]
        [MaxLength(256)]
        public string ClosedBy { get; set; }

        [Column("Remarks")]
        [MaxLength(256)]
        public string Remarks { get; set; }

        [Column("PublishingRemarks")]
        [MaxLength(256)]
        public string PublishingRemarks { get; set; }

        [Column("ClosingRemarks")]
        [MaxLength(256)]
        public string ClosingRemarks { get; set; }

        
        public Specialist PreparedBy { get; set; }

        public Specialist CheckedBy { get; set; }

        public Specialist ApprovedBy { get; set; }

        //[Child(FilterType.Equal, "ParentTypeId", 1450)]
        public ICollection<AccessoryRequired> Kits { get; set; }

        public ICollection<RequestRecord> PackageRecords { get; set; }
    }
}