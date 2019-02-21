using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("FlightNumberCrewRecords", Schema = "dbo")]
    public class FlightNumberCrewRecord : BaseEntity
    {
        [Column("FlightNumberId")]
        public int? FlightNumberId { get; set; }

        [Column("SpecializationId")]
        public int? SpecializationId { get; set; }

        [Column("Count")]
        public int? Count { get; set; }

        
        public FlightNumber FlightNumber { get; set; }

        public Specialization Specialization { get; set; }
    }
}