using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("FlightPlanOps", Schema = "dbo")]
    public class FlightPlanOps : BaseEntity
    {
        [Column("Remarks")]
        public string Remarks { get; set; }

        [Column("DateFrom")]
        public DateTime? DateFrom { get; set; }

        [Column("DateTo")]
        public DateTime? DateTo { get; set; }


        #region Navigation Property

        public ICollection<FlightPlanOpsRecords> FlightPlanOpsRecords { get; set; }

        #endregion
    }
}