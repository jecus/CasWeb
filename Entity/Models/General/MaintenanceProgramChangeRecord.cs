﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("MaintenanceProgramChangeRecords", Schema = "dbo")]
    public class MaintenanceProgramChangeRecord : BaseEntity
    {
        [Column("ParentAircraftId")]
        public int? ParentAircraftId { get; set; }

        [Column("MSG")]
        public short? MSG { get; set; }

        [Column("MaintenanceCheckRecordId")]
        public int? MaintenanceCheckRecordId { get; set; }

        [Column("CalculatedPerformanceSource")]
        [MaxLength(21)]
        public byte[] CalculatedPerformanceSource { get; set; }

        [Column("PerformanceNum")]
        public int? PerformanceNum { get; set; }

        [Column("RecordDate")]
        public DateTime? RecordDate { get; set; }

        [Column("OnLifelength")]
        [MaxLength(21)]
        public byte[] OnLifelength { get; set; }

        [Column("Remarks")]
        [MaxLength(256)]
        public string Remarks { get; set; }



        #region Navigation Property

        public Aircraft ParentAircraft { get; set; }

        #endregion
    }
}