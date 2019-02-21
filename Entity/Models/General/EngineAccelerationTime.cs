using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("EngineAccelerationTime", Schema = "dbo")]
    public class EngineAccelerationTime : BaseEntity
    {
        [Column("FlightId")]
        public int? FlightId { get; set; }

        [Column("EngineId")]
        public int? EngineId { get; set; }

        [Column("AccelerationTime")]
        public int? AccelerationTime { get; set; }

        [Column("RecordDate")]
        public DateTime? RecordDate { get; set; }

        [Column("AccelerationTimeAir")]
        public int? AccelerationTimeAir { get; set; }
    }
}