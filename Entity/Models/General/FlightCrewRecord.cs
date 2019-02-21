using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("FlightCrews", Schema = "dbo")]
    public class FlightCrewRecord : BaseEntity
    {
        [Column("FlightID")]
        public int FlightID { get; set; }

        [Column("SpecialistID")]
        public int? SpecialistID { get; set; }

        [Column("SpecializationID")]
        public int? SpecializationID { get; set; }

        [Column("IDNo")]
        public int? IDNo { get; set; }

        [Column("Limitations")]
        public string Limitations { get; set; }

        [Column("Remarks")]
        public string Remarks { get; set; }

        
        public Specialist Specialist { get; set; }
        
        public Specialization Specialization { get; set; }
    }
}