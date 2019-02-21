using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.Dictionaries;

namespace Entity.Models.General
{
    [Table("FlightNumberAirportRelations", Schema = "dbo")]
    public class FlightNumberAirportRelation : BaseEntity
    {
        [Column("FlightNumberId")]
        public int? FlightNumberId { get; set; }

        [Column("AirportId")]
        public int? AirportId { get; set; }

        
        public FlightNumber FlightNumber { get; set; }

        public AirportCode Airport { get; set; }
    }
}