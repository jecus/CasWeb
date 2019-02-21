using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("SpecialistsInstrumentRating", Schema = "dbo")]
    public class SpecialistInstrumentRating : BaseEntity
    {
        [Column("IssueDate")]
        public DateTime IssueDate { get; set; }

        [Column("SpecialistLicenseId")]
        public int SpecialistLicenseId { get; set; }

        [Column("IcaoId")]
        public int IcaoId { get; set; }

        [Column("MC")]
        public int MC { get; set; }

        [Column("MV")]
        public int MV { get; set; }

        [Column("RVR")]
        public int RVR { get; set; }

        [Column("TORVR")]
        public int TORVR { get; set; }

        #region Navigation Property

        public SpecialistLicense SpecialistLicense { get; set; }

        #endregion
    }
}