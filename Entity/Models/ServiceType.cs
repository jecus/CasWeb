using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models
{
    [Table("ServiceTypes", Schema = "Dictionaries")]
    public class ServiceType : BaseEntity
    {
        [Required]
        [Column("Name")]
        public string Name { get; set; }

        [MaxLength(256)]
        [Column("FullName")]
        public string FullName { get; set; }

        public ICollection<Document> Documents { get; set; }
    }
}