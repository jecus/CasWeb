using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.General;

namespace Entity.Models.Dictionaries
{
    [Table("Restriction", Schema = "Dictionaries")]
    public class Restriction : BaseEntity
    {
        [Column("Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Column("FullName")]
        [MaxLength(256)]
        public string FullName { get; set; }

        #region Navigation Property

        public ICollection<SpecialistLicenseRemark> LicenseRemarks { get; set; }

        #endregion
    }
}