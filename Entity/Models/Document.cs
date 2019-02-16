using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Entity.Enums;

namespace Entity.Models
{
    [Table("Documents", Schema = "dbo")]
    public class Document : BaseEntity
    {
        [Required]
        [Column("ParentID")]
        public int ParentID { get; set; }

        [Required]
        [Column("ParentTypeId")]
        public int ParentTypeId { get; set; }

        [Required]
        [Column("DocTypeId")]
        public int DocTypeId { get; set; }

        [Required]
        [Column("SubTypeId")]
        public int SubTypeId { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Required]
        [Column("IssueDateValidFrom")]
        public DateTime IssueDateValidFrom { get; set; }

        [Column("IssueValidTo")]
        public bool? IssueValidTo { get; set; }

        [Required]
        [Column("IssueDateValidTo")]
        public DateTime IssueDateValidTo { get; set; }

        [Column("IssueNotify")]
        public int? IssueNotify { get; set; }

        [Required]
        [MaxLength(128)]
        [Column("ContractNumber")]
        public string ContractNumber { get; set; }

        [Column("Revision")]
        public bool? Revision { get; set; }

        [MaxLength(128)]
        [Column("RevNumber")]
        public string RevNumber { get; set; }

        [Column("RevisionDateFrom")]
        public DateTime? RevisionDateFrom { get; set; }

        [Column("IsClosed")]
        public bool? IsClosed { get; set; }

        [Column("DepartmentId")]
        public int? DepartmentId { get; set; }

        [Column("RevisionValidTo")]
        public bool? RevisionValidTo { get; set; }

        [Column("RevisionDateValidTo")]
        public DateTime? RevisionDateValidTo { get; set; }

        [Column("RevisionNotify")]
        public int? RevisionNotify { get; set; }

        [Required]
        [Column("Aboard")]
        public bool Aboard { get; set; }

        [Required]
        [Column("Privy")]
        public bool Privy { get; set; }

        [Required]
        [MaxLength(128)]
        [Column("IssueNumber")]
        public string IssueNumber { get; set; }

        [Column("NomenсlatureId")]
        public int? NomenсlatureId { get; set; }

        [Column("ProlongationWayId")]
        public ProlongationWay ProlongationWay { get; set; }

        [Column("ServiceTypeId")]
        public int? ServiceTypeId { get; set; }

        [Required]
        [Column("ResponsibleOccupationId")]
        public int ResponsibleOccupationId { get; set; }

        [Column("Remarks")]
        public string Remarks { get; set; }

        [Required]
        [Column("LocationId")]
        public int LocationId { get; set; }

        [Required]
        [Column("SupplierId")]
        public int SupplierId { get; set; }

        [Required]
        [Column("ParentAircraftId")]
        public int? ParentAircraftId { get; set; }

        [Column("IdNumber")]
        [MaxLength(128)]
        public string IdNumber { get; set; }

        
        public virtual DocumentSubType DocumentSubType { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual Specialization ResponsibleOccupation { get; set; }

        public virtual Nomenclature Nomenсlature { get; set; }

        public virtual ServiceType ServiceType { get; set; }

        public virtual Department Department { get; set; }

        public virtual Location Location { get; set; }
    }
}