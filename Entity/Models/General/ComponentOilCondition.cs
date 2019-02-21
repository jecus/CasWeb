using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("OilConditions", Schema = "dbo")]
    public class ComponentOilCondition : BaseEntity
    {
        [Column("FlightId")]
        public int? FlightId { get; set; }

        [Column("OilAdded")]
        public double? OilAdded { get; set; }

        [Column("OnBoard")]
        public double? OnBoard { get; set; }

        [Column("Remain")]
        public double? Remain { get; set; }

        [Column("Spent")]
        public double? Spent { get; set; }

        [Column("RemainAfter")]
        public double? RemainAfter { get; set; }

        [Column("ComponentId")]
        public int? ComponentId { get; set; }
    }
}