using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.Dictionaries;

namespace Entity.Models.General
{
    [Table("KitSuppliers", Schema = "dbo")]
    public class KitSuppliersRelation : BaseEntity
    {
        [Column("KitId")]
        public int KitId { get; set; }

        [Column("SupplierId")]
        public int? SupplierId { get; set; }

        [Column("ParentTypeId")]
        public int? ParentTypeId { get; set; }

        [Column("CostNew")]
        public double? CostNew { get; set; }

        [Column("CostOverhaul")]
        public double? CostOverhaul { get; set; }

        [Column("CostServiceable")]
        public double? CostServiceable { get; set; }

        
        public Supplier Supplier { get; set; }


        #region Navigation Property
        
        public Component Component { get; set; }

        public AccessoryDescription AccessoryDescription { get; set; }

        #endregion
    }
}