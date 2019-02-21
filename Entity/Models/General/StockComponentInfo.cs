using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.Dictionaries;

namespace Entity.Models.General
{
    [Table("StockComponentInfos", Schema = "dbo")]
    public class StockComponentInfo : BaseEntity
    {
        [Column("StoreID")]
        public int? StoreID { get; set; }

        [Column("PartNumber")]
        [MaxLength(256)]
        public string PartNumber { get; set; }

        [Column("Amount")]
        public double Amount { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("AccessoryDescriptionId")]
        public int? AccessoryDescriptionId { get; set; }

        [Column("Measure")]
        public int? Measure { get; set; }

        [Column("GoodStandartId")]
        public int? GoodStandartId { get; set; }

        [Column("ComponentClass")]
        public int? ComponentClass { get; set; }

        [Column("ComponentModel")]
        public int? ComponentModel { get; set; }

        [Column("ComponentType")]
        public int? ComponentType { get; set; }


        public GoodStandart Standart { get; set; }

        public AccessoryDescription AccessoryDescription { get; set; }
    }
}