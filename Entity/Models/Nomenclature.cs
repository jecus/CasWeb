using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models
{
    [Table("Nomenclatures", Schema = "Dictionaries")]
    public class Nomenclature : BaseEntity
    {
        [Required]
        [Column("DepartmentId")]
        public int DepartmentId { get; set; }

        [Column("Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Column("FullName")]
        [MaxLength(256)]
        public string FullName { get; set; }

        public ICollection<Document> Documents { get; set; }
    }
}