using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("SupplierDocuments", Schema = "dbo")]
    public class SupplierDocument : BaseEntity
    {
        [Column("SupplierId")]
        public int? SupplierId { get; set; }

        [Column("Name")]
        [MaxLength(200)]
        public string Name { get; set; }

        [Column("DocumentType")]
        [MaxLength(200)]
        public string DocumentType { get; set; }

        [Column("FileId")]
        public int? FileId { get; set; }


       
        //[Child(FilterType.Equal, "ParentTypeId", 2050)]
        //public ICollection<ItemFileLink> Files { get; set; }
    }
}