using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Entity.Models
{
    [Table("LocationsType", Schema = "Dictionaries")]
    public class LocationsType : BaseEntity
    {
        [MaxLength(50)]
        [Column("Name")]
        public string Name { get; set; }

        [MaxLength(256)]
        [Column("FullName")]
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