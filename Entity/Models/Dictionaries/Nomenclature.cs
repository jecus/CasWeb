using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.General;

namespace Entity.Models.Dictionaries
{
    [Table("Nomenclatures", Schema = "Dictionaries")]
    public class Nomenclature : BaseEntity
    {
        [Column("DepartmentId")]
        public int? DepartmentId { get; set; }

        [Column("Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Column("FullName")]
        [MaxLength(256)]
        public string FullName { get; set; }

        
        public Department Department { get; set; }

        #region Navigation Property

        public ICollection<Document> Documents { get; set; }

        #endregion
    }
}