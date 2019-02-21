using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.Dictionaries;

namespace Entity.Models.General
{
    [Table("JobCards", Schema = "dbo")]
    public class JobCard : BaseEntity
    {
        [Column("ParentId")]
        public int ParentId { get; set; }

        [Column("WorkArea")]
        [MaxLength(256)]
        public string WorkArea { get; set; }

        [Column("ManHours")]
        public double? ManHours { get; set; }

        [Column("Cost")]
        public double? Cost { get; set; }

        [Column("ParentTypeId")]
        public int? ParentTypeId { get; set; }

        [Column("Form")]
        [MaxLength(256)]
        public string Form { get; set; }

        [Column("FormRevision")]
        [MaxLength(256)]
        public string FormRevision { get; set; }

        [Column("FormDate")]
        public DateTime? FormDate { get; set; }

        [Column("PreparedByDate")]
        public DateTime? PreparedByDate { get; set; }

        [Column("PreparedById")]
        public int? PreparedById { get; set; }

        [Column("CheckedByDate")]
        public DateTime? CheckedByDate { get; set; }

        [Column("CheckedById")]
        public int? CheckedById { get; set; }

        [Column("ApprovedByDate")]
        public DateTime? ApprovedByDate { get; set; }

        [Column("ApprovedById")]
        public int? ApprovedById { get; set; }

        [Column("JobCardNumber")]
        [MaxLength(256)]
        public string JobCardNumber { get; set; }

        [Column("JobCardHeader")]
        public string JobCardHeader { get; set; }

        [Column("JobCardDate")]
        public DateTime? JobCardDate { get; set; }

        [Column("JobCardRevision")]
        [MaxLength(256)]
        public string JobCardRevision { get; set; }

        [Column("JobCardRevisionDate")]
        public DateTime? JobCardRevisionDate { get; set; }

        [Column("Title")]
        [MaxLength(256)]
        public string Title { get; set; }

        [Column("Description")]
        [MaxLength(256)]
        public string Description { get; set; }

        [Column("AtaChapter")]
        public int? AtaChapterId { get; set; }

        [Column("Zone")]
        [MaxLength(256)]
        public string Zone { get; set; }

        [Column("Access")]
        [MaxLength(256)]
        public string Access { get; set; }

        [Column("Station")]
        [MaxLength(256)]
        public string Station { get; set; }

        [Column("MRO")]
        [MaxLength(256)]
        public string MRO { get; set; }

        [Column("MaintenanceManualRevision")]
        [MaxLength(256)]
        public string MaintenanceManualRevision { get; set; }

        [Column("MaintenanceManualRevisionDate")]
        public DateTime? MaintenanceManualRevisionDate { get; set; }

        [Column("Qualification")]
        public int? QualificationId { get; set; }

        [Column("Man")]
        public int? Man { get; set; }

        [Column("JobCardFooter")]
        [MaxLength(256)]
        public string JobCardFooter { get; set; }

        [Column("Phase")]
        [MaxLength(256)]
        public string Phase { get; set; }

        [Column("Applicability")]
        [MaxLength(256)]
        public string Applicability { get; set; }

        [Column("RefDocType")]
        public int? RefDocType { get; set; }

        [Column("DirectiveTypeId")]
        public int? DirectiveTypeId { get; set; }

        
        public Specialist PreparedBy { get; set; }

        public Specialist CheckedBy { get; set; }

        public Specialist ApprovedBy { get; set; }

        public ATAChapter AtaChapter { get; set; }

        public AircraftWorkerCategory Qualification { get; set; }

        //[Child(FilterType.Equal, "ParentTypeId", 1450)]
        public ICollection<AccessoryRequired> Kits { get; set; }

        public ICollection<JobCardTask> JobCardTasks { get; set; }


        #region Navigation Property

        public ICollection<Procedure> Procedure { get; set; }
        
        public ICollection<MaintenanceDirective> MaintenanceDirectives { get; set; }
        
        public ICollection<JobCardTask> JobCardTask { get; set; }

        #endregion
    }
}