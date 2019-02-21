using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.Dictionaries;

namespace Entity.Models.General
{
    [Table("AircraftEquipments", Schema = "dbo")]
    public class AircraftEquipment : BaseEntity
    {
        [Column("Description")]
        [MaxLength(256)]
        public string Description { get; set; }

        [Column("AircraftId")]
        public int AircraftId { get; set; }

        [Column("AircraftOtherParameter")]
        public int? AircraftOtherParameterId { get; set; }

        [Column("AircraftEquipmetType")]
        public int AircraftEquipmetType { get; set; }


        
        public AircraftOtherParameter AircraftOtherParameter { get; set; }
    }
}