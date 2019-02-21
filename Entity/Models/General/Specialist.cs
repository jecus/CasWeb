using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.Dictionaries;

namespace Entity.Models.General
{
    [Table("Specialists", Schema = "dbo")]
    public class Specialist : BaseEntity
    {
        [Column("FirstName")]
        [MaxLength(256)]
        public string FirstName { get; set; }

        [Column("ShortName")]
        [MaxLength(256)]
        public string ShortName { get; set; }

        [Column("SpecializationID")]
        public int SpecializationID { get; set; }

        [Column("LastName")]
        [MaxLength(256)]
        public string LastName { get; set; }

        [Column("Gender")]
        public short? Gender { get; set; }

        [Column("AGWCategory")]
        public int? AGWCategoryId { get; set; }

        [Column("DateOfBirth")]
        public DateTime? DateOfBirth { get; set; }

        [Column("Nationality")]
        [MaxLength(256)]
        public string Nationality { get; set; }

        [Column("Address")]
        [MaxLength(256)]
        public string Address { get; set; }

        [Column("Photo")]
        public byte[] Photo { get; set; }

        [Column("PhoneMobile")]
        [MaxLength(256)]
        public string PhoneMobile { get; set; }

        [Column("Phone")]
        [MaxLength(256)]
        public string Phone { get; set; }

        [Column("Email")]
        [MaxLength(256)]
        public string Email { get; set; }

        [Column("Skype")]
        [MaxLength(256)]
        public string Skype { get; set; }

        [Column("Information")]
        public string Information { get; set; }

        [Column("Education")]
        public short EducationId { get; set; }

        [Column("Location")]
        public int Location { get; set; }

        [Column("Status")]
        public short Status { get; set; }

        [Column("Position")]
        public short Position { get; set; }

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

        [Column("Additional")]
        [MaxLength(256)]
        public string Additional { get; set; }

        [Column("Combination")]
        public string Combination { get; set; }

        
        public AGWCategorie AGWCategory { get; set; }

        public LocationsType Facility { get; set; }

        public Specialization Specialization { get; set; }

        public ICollection<SpecialistLicense> Licenses { get; set; }

        public ICollection<SpecialistTraining> SpecialistTrainings { get; set; }

        public ICollection<SpecialistLicenseDetail> LicenseDetails { get; set; }

        public ICollection<SpecialistLicenseRemark> LicenseRemark { get; set; }

        //[Child(FilterType.Equal, "ParentTypeId", 1310)]
        public ICollection<Document> EmployeeDocuments { get; set; }

        //[Child(FilterType.Equal, "ParentTypeId", 1310)]
        public ICollection<CategoryRecord> CategoriesRecords { get; set; }

        //[Child(FilterType.Equal, "ParentTypeId", 1310)]
        public ICollection<ItemFileLink> Files { get; set; }

        #region Navigation Property

        public ICollection<CertificateOfReleaseToService> CertificateOfReleaseToServiceB1s { get; set; }
        
        public ICollection<CertificateOfReleaseToService> CertificateOfReleaseToServiceB2s { get; set; }
       
        public ICollection<Discrepancy> Discrepancys { get; set; }
        
        public ICollection<FlightCrewRecord> FlightCrewRecords { get; set; }
        
        public ICollection<WorkOrder> PreparedWorkOrders { get; set; }
        
        public ICollection<WorkOrder> CheckedWorkOrders { get; set; }
        
        public ICollection<WorkOrder> ApprovedWorkOrders { get; set; }
        
        public ICollection<TransferRecord> ReleasedSpecialist { get; set; }
        
        public ICollection<TransferRecord> RecivedSpecialist { get; set; }
        
        public ICollection<Request> PreparedByRequests { get; set; }
       
        public ICollection<Request> CheckedByRequests { get; set; }
        
        public ICollection<Request> ApprovedByRequests { get; set; }
        
        public ICollection<JobCard> PreparedJobCards { get; set; }
        
        public ICollection<JobCard> CheckedJobCards { get; set; }
       
        public ICollection<JobCard> ApprovedJobCards { get; set; }

        public ICollection<InitialOrder> Approveds { get; set; }

        public ICollection<InitialOrder> Publisheds { get; set; }

        public ICollection<InitialOrder> Closeds { get; set; }

        public ICollection<RequestForQuotation> QuotationApproveds { get; set; }

        public ICollection<RequestForQuotation> QuotationPublisheds { get; set; }

        public ICollection<RequestForQuotation> QuotationCloseds { get; set; }

        #endregion
    }
}