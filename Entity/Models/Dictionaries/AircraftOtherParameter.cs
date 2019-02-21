using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.General;

namespace Entity.Models.Dictionaries
{
    [Table("AircraftOtherParameters", Schema = "Dictionaries")]
    public class AircraftOtherParameter : BaseEntity
    {
        [Column("Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Column("FullName")]
        [MaxLength(256)]
        public string FullName { get; set; }


        #region Navigation Property

        public ICollection<AircraftEquipment> AircraftEquipments { get; set; }

        #endregion
    }
}