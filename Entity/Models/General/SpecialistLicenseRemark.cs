using System;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.Dictionaries;

namespace Entity.Models.General
{
    [Table("SpecialistsLicenseRemark", Schema = "dbo")]
    public class SpecialistLicenseRemark : BaseEntity
    {
        [Column("IssueDate")]
        public DateTime IssueDate { get; set; }

        [Column("RightsId")]
        public int? RightsId { get; set; }

        [Column("RestrictionId")]
        public int? RestrictionId { get; set; }

        [Column("SpecialistLicenseId")]
        public int? SpecialistLicenseId { get; set; }

        [Column("SpecialistId")]
        public int? SpecialistId { get; set; }

        
        public LicenseRemarkRight Rights { get; set; }

        public Restriction LicenseRestriction { get; set; }


        #region Navigation Property

        public SpecialistLicense SpecialistLicense { get; set; }

        public Specialist Specialist { get; set; }

        #endregion
    }
}