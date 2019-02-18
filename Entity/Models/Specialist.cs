using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Entity.Enums;

namespace Entity.Models
{
    [Table("Specialists", Schema = "dbo")]
    public class Specialist : BaseEntity
    {
        [MaxLength(256)]
        [Column("FirstName")]
        public string FirstName { get; set; }

        [MaxLength(256)]
        [Column("ShortName")]
        public string ShortName { get; set; }

        [Column("SpecializationID")]
        public int SpecializationID { get; set; }

        [MaxLength(256)]
        [Column("LastName")]
        public string LastName { get; set; }

        [Column("Gender")]
        public short? Gender { get; set; }

        [Column("AGWCategory")]
        public int? AGWCategoryId { get; set; }

        [Column("DateOfBirth")]
        public DateTime? DateOfBirth { get; set; }

        [MaxLength(256)]
        [Column("Nationality")]
        public string Nationality { get; set; }

        [MaxLength(256)]
        [Column("Address")]
        public string Address { get; set; }

        [Column("Photo")]
        public byte[] Photo { get; set; }

        [MaxLength(256)]
        [Column("PhoneMobile")]
        public string PhoneMobile { get; set; }

        [MaxLength(256)]
        [Column("Phone")]
        public string Phone { get; set; }

        [MaxLength(256)]
        [Column("Email")]
        public string Email { get; set; }

        [MaxLength(256)]
        [Column("Skype")]
        public string Skype { get; set; }

        [Column("Information")]
        public string Information { get; set; }

        [Column("Education")]
        public short EducationId { get; set; }

        [Column("Location")]
        public int Location { get; set; }

        [Column("Status")]
        public SpecialistStatus Status { get; set; }

        [Column("Position")]
        public SpecialistPosition Position { get; set; }

        [Column("Sign")]
        public byte[] Sign { get; set; }

        [Column("FamilyStatus")]
        public short FamilyStatusId { get; set; }

        [Column("Citizenship")]
        public short Citizenship { get; set; }

        [Column("PersonnelCategoryId")]
        public int PersonnelCategoryId { get; set; }

        [Column("ClassNumber")]
        public int ClassNumber { get; set; }

        [Column("ClassIssueDate")]
        public DateTime? ClassIssueDate { get; set; }

        [Column("GradeNumber")]
        public int GradeNumber { get; set; }

        [Column("GradeIssueDate")]
        public DateTime? GradeIssueDate { get; set; }

        [MaxLength(256)]
        [Column("Additional")]
        public string Additional { get; set; }

        [Column("Combination")]
        public string Combination { get; set; }

        
        public virtual AGWCategorie AGWCategory { get; set; }

        public virtual LocationsType Facility { get; set; }

        public virtual Specialization Specialization { get; set; }
    }
}