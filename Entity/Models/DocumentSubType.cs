
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models
{
    [Table("DocumentSubType", Schema = "Dictionaries")]
    public class DocumentSubType : BaseEntity
    {
        [Required]
        [Column("DocumentTypeId")]
        public int DocumentTypeId { get; set; }

        [Column("Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Document> Documents { get; set; }
    }
}