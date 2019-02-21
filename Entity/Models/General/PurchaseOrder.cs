using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("PurchaseOrders", Schema = "dbo")]
    public class PurchaseOrder : BaseEntity
    {
        [Column("Title")]
        [MaxLength(256)]
        public string Title { get; set; }

        [Column("Description")]
        [MaxLength(256)]
        public string Description { get; set; }

        [Column("ParentID")]
        public int? ParentID { get; set; }

        [Column("ParentQuotationId")]
        public int? ParentQuotationId { get; set; }

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

        [Column("SupplierId")]
        public int? SupplierId { get; set; }

        
        public Supplier Supplier { get; set; }

        //[Child(FilterType.Equal, "ParentTypeId", 1860)]
        //public ICollection<ItemFileLink> Files { get; set; }
    }
}