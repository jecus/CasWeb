using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("SpecialistsLicenseDetail", Schema = "dbo")]
    public class SpecialistLicenseDetail : BaseEntity
    {
        [Column("Description")]
        public string Description { get; set; }

        [Column("IssueDate")]
        public DateTime IssueDate { get; set; }

        [Column("SpecialistLicenseId")]
        public int SpecialistLicenseId { get; set; }

        [Column("SpecialistId")]
        public int SpecialistId { get; set; }


        #region Navigation Property

        public SpecialistLicense SpecialistLicense { get; set; }

        public Specialist Specialist { get; set; }


        #endregion
    }
}