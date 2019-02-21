using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("MTOPCheckRecords", Schema = "dbo")]
    public class MTOPCheckRecord : BaseEntity
    {
        [Column("CheckName")]
        [MaxLength(150)]
        public string CheckName { get; set; }

        [Column("Remarks")]
        public string Remarks { get; set; }

        [Column("RecordDate")]
        public DateTime? RecordDate { get; set; }

        [Column("GroupName")]
        public int? GroupName { get; set; }

        [Column("ParentId")]
        public int? ParentId { get; set; }

        [Column("IsControlPoint")]
        public bool IsControlPoint { get; set; }

        [Column("CalculatedPerformanceSource")]
        public byte[] CalculatedPerformanceSource { get; set; }

        [Column("AverageUtilization")]
        [MaxLength(50)]
        public byte[] AverageUtilization { get; set; }


        #region Navigation Property

        public MTOPCheck MtopCheck { get; set; }

        #endregion
    }
}