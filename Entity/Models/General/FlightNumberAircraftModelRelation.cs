using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.Dictionaries;

namespace Entity.Models.General
{
    [Table("FlightNumberAircraftModelRelations", Schema = "dbo")]
    public class FlightNumberAircraftModelRelation : BaseEntity
    {
        [Column("AircraftModelId")]
        public int? AircraftModelId { get; set; }

        [Column("FlightNumberId")]
        public int? FlightNumberId { get; set; }

        
        public AccessoryDescription AircraftModel { get; set; }

        public FlightNumber FlightNumber { get; set; }
    }
}