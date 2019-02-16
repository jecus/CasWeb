using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models
{
    [Table("Supplier", Schema = "dbo")]
    public class Supplier : BaseEntity
    {
        [Column("Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Column("ShortName")]
        [MaxLength(50)]
        public string ShortName { get; set; }

        [Column("AirCode")]
        [MaxLength(256)]
        public string AirCode { get; set; }

        [Column("VendorCode")]
        [MaxLength(50)]
        public string VendorCode { get; set; }

        [Column("Phone")]
        [MaxLength(50)]
        public string Phone { get; set; }

        [Column("Fax")]
        [MaxLength(50)]
        public string Fax { get; set; }

        [Column("Address")]
        [MaxLength(200)]
        public string Address { get; set; }

        [Column("ContactPerson")]
        [MaxLength(50)]
        public string ContactPerson { get; set; }

        [Column("Email")]
        [MaxLength(50)]
        public string Email { get; set; }

        [Column("WebSite")]
        [MaxLength(50)]
        public string WebSite { get; set; }

        [Column("Products")]
        [MaxLength(200)]
        public string Products { get; set; }

        [Column("Approved")]
        public bool? Approved { get; set; }

        [Column("Remarks")]
        [MaxLength(200)]
        public string Remarks { get; set; }

        [Required]
        [Column("SupplierClassId")]
        public int SupplierClassId { get; set; }

        [Column("Subject")]
        public string Subject { get; set; }

        public ICollection<Document> Documents { get; set; }
    }
}