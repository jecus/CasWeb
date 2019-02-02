using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models
{
    [Table("Stores", Schema = "dbo")]
    public class Store : BaseEntity
    {
        [Required]
        public string StoreName { get; set; }
    }
}