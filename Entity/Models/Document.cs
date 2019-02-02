using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models
{
    [Table("Documents", Schema = "dbo")]
    public class Document : BaseEntity
    {
        [Required]
        public string Description { get; set; }
    }
}