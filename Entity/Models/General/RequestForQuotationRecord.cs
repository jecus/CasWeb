using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.Dictionaries;

namespace Entity.Models.General
{
    [Table("RequestForQuotationRecords", Schema = "dbo")]
    public class RequestForQuotationRecord : BaseEntity
    {
        [Column("ParentPackageId")]
        public int? ParentPackageId { get; set; }

        [Column("PackageItemId")]
        public int PackageItemId { get; set; }

        [Column("CostCondition")]
        public short CostCondition { get; set; }

        [Column("Processed")]
        public bool Processed { get; set; }

        [Column("PackageItemTypeId")]
        public int? PackageItemTypeId { get; set; }

        [Column("Quantity")]
        public double? Quantity { get; set; }

        [Column("Measure")]
        public int? Measure { get; set; }

        [Column("CostNew")]
        public double? CostNew { get; set; }

        [Column("CostOverhaul")]
        public double? CostOverhaul { get; set; }

        [Column("CostServiceable")]
        public double? CostServiceable { get; set; }

        [Column("ToSupplier")]
        public int? ToSupplierId { get; set; }

        [Column("Priority")]
        public int Priority { get; set; }

        [Column("DefferedCategory")]
        public int? DefferedCategoryId { get; set; }

        [Column("DestinationObjectId")]
        public int DestinationObjectId { get; set; }

        [Column("DestinationObjectType")]
        public int DestinationObjectType { get; set; }

        [Column("InitialReason")]
        public int InitialReason { get; set; }

        
        public DefferedCategorie DefferedCategory { get; set; }

        public Supplier ToSupplier { get; set; }


        #region Navigation Property

        public RequestForQuotation RequestForQuotation { get; set; }

        #endregion
    }
}