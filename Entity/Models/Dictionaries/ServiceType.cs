using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.Dictionaries
{
    [Table("ServiceTypes", Schema = "Dictionaries")]
    public class ServiceType : BaseEntity
    {
        [Column("Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Column("FullName")]
        [MaxLength(256)]
        public string FullName { get; set; }


        #region Navigation Property
        
        public ICollection<Document> Documents { get; set; }

        #endregion
    }
}