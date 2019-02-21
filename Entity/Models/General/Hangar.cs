using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("Hangars", Schema = "dbo")]
    public class Hangar : BaseEntity
    {
        [Column("StoreName")]
        [MaxLength(256)]
        public string StoreName { get; set; }

        [Column("Location")]
        [MaxLength(256)]
        public string Location { get; set; }

        [Column("OperatorId")]
        public int? OperatorId { get; set; }

        [Column("Remarks")]
        [MaxLength(256)]
        public string Remarks { get; set; }
    }
}