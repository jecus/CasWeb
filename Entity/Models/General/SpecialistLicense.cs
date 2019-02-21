using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.Dictionaries;

namespace Entity.Models.General
{
    [Table("SpecialistsLicense", Schema = "dbo")]
    public class SpecialistLicense : BaseEntity
    {
        [Column("Confirmation")]
        public bool Confirmation { get; set; }

        [Column("LicenseTypeID")]
        public int LicenseTypeID { get; set; }

        [Column("AircraftTypeID")]
        public int AircraftTypeID { get; set; }

        [Column("SpecialistId")]
        public int SpecialistId { get; set; }

        [Column("Notify")]
        [MaxLength(21)]
        public byte[] Notify { get; set; }

        [Column("IssueDate")]
        public DateTime? IssueDate { get; set; }

        [Column("ValidToDate")]
        public DateTime? ValidToDate { get; set; }

        
        public AccessoryDescription AircraftType { get; set; }

        public ICollection<SpecialistCAA> CaaLicense { get; set; }

        public ICollection<SpecialistLicenseDetail> LicenseDetails { get; set; }

        public ICollection<SpecialistLicenseRating> LicenseRatings { get; set; }

        public ICollection<SpecialistInstrumentRating> SpecialistInstrumentRatings { get; set; }

        public ICollection<SpecialistLicenseRemark> LicenseRemark { get; set; }


        #region Navigation Property

        public Specialist Specialist { get; set; }

        #endregion
    }
}