using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models
{
    [Table("Aircrafts", Schema = "dbo")]
    public class Aircraft : BaseEntity
    {
        [Required]
        public string RegistrationNumber { get; set; }
    }
}