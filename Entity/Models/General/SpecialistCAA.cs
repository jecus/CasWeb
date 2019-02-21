using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("SpecialistsCAA", Schema = "dbo")]
    public class SpecialistCAA : BaseEntity
    {
        [Column("NumberCAA")]
        [MaxLength(25)]
        public string NumberCAA { get; set; }

        [Column("CAAId")]
        public int CAAId { get; set; }

        [Column("CAAType")]
        public int CAAType { get; set; }

        [Column("ValidTo")]
        public DateTime ValidTo { get; set; }

        [Column("SpecialistLicenseId")]
        public int SpecialistLicenseId { get; set; }

        [Column("Notify")]
        [MaxLength(21)]
        public byte[] Notify { get; set; }

        [Column("IssueDate")]
        public DateTime? IssueDate { get; set; }


        #region Navigation Property

        public SpecialistLicense SpecialistLicense { get; set; }

        #endregion
    }
}