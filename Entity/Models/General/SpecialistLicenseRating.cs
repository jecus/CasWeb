using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("SpecialistsLicenseRating", Schema = "dbo")]
    public class SpecialistLicenseRating : BaseEntity
    {
        [Column("IssueDate")]
        public DateTime IssueDate { get; set; }

        [Column("SpecialistLicenseId")]
        public int SpecialistLicenseId { get; set; }

        [Column("RightsId")]
        public int RightsId { get; set; }

        [Column("FunctionId")]
        public int FunctionId { get; set; }


        #region Navigation Property

        public SpecialistLicense SpecialistLicense { get; set; }

        #endregion
    }
}