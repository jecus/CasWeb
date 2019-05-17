using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("PurchaseRequestsRecords", Schema = "dbo")]
    public class PurchaseRequestRecord : BaseEntity
    {
        [Column("ParentPackageId")]
        public int? ParentPackageId { get; set; }

        [Column("PackageItemId")]
        public int? PackageItemId { get; set; }

        [Column("PackageItemTypeId")]
        public int? PackageItemTypeId { get; set; }

        [Column("SupplierId")]
        public int? SupplierId { get; set; }

        [Column("Remarks")]
        [MaxLength(256)]
        public string Remarks { get; set; }

        [Column("Quantity")]
        public double? Quantity { get; set; }

        [Column("Measure")]
        public int? Measure { get; set; }

        [Column("Cost")]
        public double? Cost { get; set; }

        [Column("CostCondition")]
        public short? CostCondition { get; set; }

        [Column("Processed")]
        public bool? Processed { get; set; }

        
        public Supplier Supplier { get; set; }

        //[Child(FilterType.Equal, "ParentTypeId", 1860)]
        //public ICollection<ItemFileLink> Files { get; set; }
    }
}