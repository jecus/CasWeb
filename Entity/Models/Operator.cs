using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models
{
    [Table("Operators", Schema = "dbo")]
    public class Operator
    {
        [Key]
        [Column("OperatorID")]
        public int ItemId { get; set; }

        [Column("IsDeleted")]
        public bool IsDeleted { get; set; }

        [Required]
        public string Name { get; set; }

        public string ICAOCode { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public string Email { get; set; }

        
    }
}