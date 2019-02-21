using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.General;

namespace Entity.Models.Dictionaries
{
    [Table("FlightNum", Schema = "Dictionaries")]
    public class FlightNum : BaseEntity
    {
        [Column("FlightNumber")]
        [MaxLength(256)]
        public string FlightNumber { get; set; }


        #region Navigation Property
        
        public ICollection<AircraftFlight> AircraftFlights { get; set; }
        
        public ICollection<FlightNumber> FlightNumbers { get; set; }

        #endregion
    }
}