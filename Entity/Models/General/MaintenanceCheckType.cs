using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("Cas3MaintenanceCheckType", Schema = "dbo")]
    public class MaintenanceCheckType : BaseEntity
    {
        [Column("Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Column("Priority")]
        public int? Priority { get; set; }

        [Column("ShortName")]
        [MaxLength(50)]
        public string ShortName { get; set; }


        #region Navigation Property

        public ICollection<MTOPCheck> MtopChecks { get; set; }
        
        public ICollection<MaintenanceCheck> MaintenanceChecks { get; set; }

        #endregion
    }
}