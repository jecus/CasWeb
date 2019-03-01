using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.Dictionaries;

namespace Entity.Models.General
{
    [Table("FlightTrips", Schema = "dbo")]
    public class FlightTrack : BaseEntity
    {
        [Column("Remarks")]
        [MaxLength(256)]
        public string Remarks { get; set; }

        [Column("DayOfWeek")]
        public int? DayOfWeek { get; set; }

        [Column("TripName")]
        public int? TripNameId { get; set; }

        [Column("SupplierID")]
        public int? SupplierID { get; set; }

        
        public TripNames TripName { get; set; }

        public Supplier Supplier { get; set; }

        public ICollection<FlightTrackRecord> FlightTripRecord { get; set; }
    }
}