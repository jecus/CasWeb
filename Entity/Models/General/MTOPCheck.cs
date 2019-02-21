using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("MTOPCheck", Schema = "dbo")]
    public class MTOPCheck : BaseEntity
    {
        [Column("Name")]
        [MaxLength(150)]
        public string Name { get; set; }

        [Column("ParentAircraftId")]
        public int ParentAircraftId { get; set; }

        [Column("CheckTypeId")]
        public int CheckTypeId { get; set; }

        [Column("Thresh")]
        public byte[] Thresh { get; set; }

        [Column("Repeat")]
        public byte[] Repeat { get; set; }

        [Column("Notify")]
        public byte[] Notify { get; set; }

        [Column("IsZeroPhase")]
        public bool IsZeroPhase { get; set; }

        
        public MaintenanceCheckType CheckType { get; set; }

        public ICollection<MTOPCheckRecord> PerformanceRecords { get; set; }
    }
}