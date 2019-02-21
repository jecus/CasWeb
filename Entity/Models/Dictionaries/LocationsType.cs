using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.Dictionaries
{
    [Table("LocationsType", Schema = "Dictionaries")]
    public class LocationsType : BaseEntity
    {
        [Column("Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Column("FullName")]
        [MaxLength(256)]
        public string FullName { get; set; }

        [Column("DepartmentId")]
        public int DepartmentId { get; set; }

        
        public Department Department { get; set; }


        #region Navigation Property

        public ICollection<Location> Locations { get; set; }
        
        public ICollection<Specialist> Specialists { get; set; }

        #endregion
    }
}