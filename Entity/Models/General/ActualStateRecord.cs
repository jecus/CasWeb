using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("ActualStateRecords", Schema = "dbo")]
    public class ActualStateRecord : BaseEntity
    {
        [Column("FlightRegimeId")]
        public int FlightRegimeId { get; set; }

        [Column("Remarks")]
        public string Remarks { get; set; }

        [Column("OnLifelength")]
        public byte[] OnLifelength { get; set; }

        [Column("RecordDate")]
        public DateTime? RecordDate { get; set; }

        [Column("WorkRegimeTypeId")]
        public int? WorkRegimeTypeId { get; set; }

        [Column("ComponentId")]
        public int ComponentId { get; set; }


        #region Navigation Property

        public Component Component { get; set; }

        #endregion
    }
}