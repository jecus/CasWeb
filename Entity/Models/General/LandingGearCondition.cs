using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("LandingGearCondition", Schema = "dbo")]
    public class LandingGearCondition : BaseEntity
    {
        [Column("FlightID")]
        public int FlightID { get; set; }

        [Column("LandingGearID")]
        public int LandingGearID { get; set; }

        [Column("TirePressure1")]
        public double? TirePressure1 { get; set; }

        [Column("TirePressure2")]
        public double? TirePressure2 { get; set; }

        [Column("RecordDate")]
        public DateTime? RecordDate { get; set; }
    }
}