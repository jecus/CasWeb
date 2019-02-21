using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.General;

namespace Entity.Models.Dictionaries
{
    [Table("CruiseLevels", Schema = "Dictionaries")]
    public class CruiseLevel : BaseEntity
    {
        [Column("FullName")]
        [MaxLength(128)]
        public string FullName { get; set; }

        [Column("Meter")]
        public int? Meter { get; set; }

        [Column("Feet")]
        public int? Feet { get; set; }

        [Column("IVFR")]
        [MaxLength(128)]
        public string IVFR { get; set; }

        [Column("Track")]
        [MaxLength(128)]
        public string Track { get; set; }



        #region Navigation Property

        public ICollection<AircraftFlight> AircraftFlights { get; set; }
        
        public ICollection<FlightNumber> FlightNumbers { get; set; }

        #endregion
    }
}