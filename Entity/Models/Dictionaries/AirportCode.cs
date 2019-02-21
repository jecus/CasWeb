using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.General;

namespace Entity.Models.Dictionaries
{
    [Table("AirportsCodes", Schema = "Dictionaries")]
    public class AirportCode : BaseEntity
    {
        [Column("Iata")]
        [MaxLength(256)]
        public string Iata { get; set; }

        [Column("Icao")]
        [MaxLength(256)]
        public string Icao { get; set; }

        [Column("FullName")]
        [MaxLength(256)]
        public string FullName { get; set; }

        [Column("City")]
        [MaxLength(256)]
        public string City { get; set; }

        [Column("Country")]
        [MaxLength(256)]
        public string Country { get; set; }

        [Column("Iso")]
        [MaxLength(256)]
        public string Iso { get; set; }


        #region Navigation Property
        
        public ICollection<FlightNumber> From { get; set; }
        
        public ICollection<FlightNumber> To { get; set; }
        
        public ICollection<AircraftFlight> AircraftFlightsFrom { get; set; }
        
        public ICollection<AircraftFlight> AircraftFlightsTo { get; set; }
        
        public ICollection<FlightNumberAirportRelation> AirportRelations { get; set; }

        #endregion
    }
}