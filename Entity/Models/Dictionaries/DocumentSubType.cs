using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.Dictionaries
{
    [Table("DocumentSubType", Schema = "Dictionaries")]
    public class DocumentSubType : BaseEntity
    {
        [Column("DocumentTypeId")]
        public int DocumentTypeId { get; set; }

        [Column("Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        #region Navigation Property

        public ICollection<Document> Documents { get; set; }

        #endregion
    }
}