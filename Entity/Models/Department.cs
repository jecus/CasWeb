using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models 
{
    [Table("Departments", Schema = "Dictionaries")]
    public class Department : BaseEntity
    {
        [MaxLength(50)]
        [Column("Name")]
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        [Column("FullName")]
        public string FullName { get; set; }

        public ICollection<Document> Documents { get; set; }
    }
}