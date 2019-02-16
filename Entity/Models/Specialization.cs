using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models
{
    [Table("Specializations", Schema = "Dictionaries")]
    public class Specialization : BaseEntity
    {
        [Column("FullName")]
        [MaxLength(128)]
        public string FullName { get; set; }

        [Column("ShortName")]
        [MaxLength(128)]
        public string ShortName { get; set; }

        [Column("DepartmentId")]
        [Required]
        public int DepartmentId { get; set; }

        [Column("Level")]
        [Required]
        public int Level { get; set; }

        [Column("KeyPersonel")]
        [Required]
        public bool KeyPersonel { get; set; }

        public ICollection<Document> Documents { get; set; }
    }
}