using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models
{
    [Table("Locations", Schema = "Dictionaries")]
    public class Location : BaseEntity
    {
        [MaxLength(50)]
        [Column("Name")]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        [Column("FullName")]
        public string FullName { get; set; }

        [Column("LocationsTypeId")]
        public int LocationsTypeId { get; set; }

        public ICollection<Document> Documents { get; set; }

        public virtual LocationsType Locations { get; set; }
    }
}