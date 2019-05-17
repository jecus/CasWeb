﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("WorkPackages", Schema = "dbo")]
    public class WorkPackage : BaseEntity
    {
        [Column("ParentId")]
        public int? ParentId { get; set; }

        [Column("Title")]
        public string Title { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Status")]
        public int Status { get; set; }

        [Column("Author")]
        [MaxLength(256)]
        public string Author { get; set; }

        [Column("OpeningDate")]
        public DateTime OpeningDate { get; set; }

        [Column("PublishingDate")]
        public DateTime? PublishingDate { get; set; }

        [Column("ClosingDate")]
        public DateTime? ClosingDate { get; set; }

        [Column("Remarks")]
        [MaxLength(256)]
        public string Remarks { get; set; }

        [Column("PublishingRemarks")]
        [MaxLength(256)]
        public string PublishingRemarks { get; set; }

        [Column("ClosingRemarks")]
        [MaxLength(256)]
        public string ClosingRemarks { get; set; }

        [Column("OnceClosed")]
        public bool OnceClosed { get; set; }

        [Column("ReleaseCertificateNo")]
        [MaxLength(256)]
        public string ReleaseCertificateNo { get; set; }

        [Column("CheckType")]
        [MaxLength(256)]
        public string CheckType { get; set; }

        [Column("Station")]
        [MaxLength(256)]
        public string Station { get; set; }

        [Column("MaintenanceReportNo")]
        [MaxLength(256)]
        public string MaintenanceReportNo { get; set; }

        [Column("Number")]
        [MaxLength(256)]
        public string Number { get; set; }

        [Column("Revision")]
        [MaxLength(256)]
        public string Revision { get; set; }

        [Column("CreateDate")]
        public DateTime? CreateDate { get; set; }

        [Column("PublishedBy")]
        [MaxLength(256)]
        public string PublishedBy { get; set; }

        [Column("ClosedBy")]
        [MaxLength(256)]
        public string ClosedBy { get; set; }

        [Column("EmployeesRemark")]
        public string EmployeesRemark { get; set; }

        //[Child(FilterType.Equal, "ParentTypeId", 2499)]
        //public ICollection<ItemFileLink> Files { get; set; }
    }
}