using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("FlightTripRecords", Schema = "dbo")]
    public class FlightTrackRecord : BaseEntity
    {
        [Column("FlightTripId")]
        public int? FlightTripId { get; set; }

        [Column("FlightPeriodId")]
        public int? FlightPeriodId { get; set; }


        #region Navigation Property

        public FlightTrack FlightTrack { get; set; }

        #endregion
    }
}