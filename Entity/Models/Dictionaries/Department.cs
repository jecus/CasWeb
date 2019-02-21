using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.Dictionaries
{
    [Table("Departments", Schema = "Dictionaries")]
    public class Department : BaseEntity
    {
        [Column("Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Column("FullName")]
        [MaxLength(256)]
        public string FullName { get; set; }


        #region Navigation Property

        public ICollection<Document> Documents { get; set; }
        
        public ICollection<Specialization> Specializations { get; set; }
        
        public ICollection<Nomenclature> Nomenclatures { get; set; }

        public ICollection<LocationsType> LocationsTypes { get; set; }
        #endregion
    }
}