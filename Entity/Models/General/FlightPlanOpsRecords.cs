using System;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.Dictionaries;

namespace Entity.Models.General
{
    [Table("FlightPlanOpsRecords", Schema = "dbo")]
    public class FlightPlanOpsRecords : BaseEntity
    {
        [Column("FlightPlanOpsId")]
        public int? FlightPlanOpsId { get; set; }

        [Column("AircraftId")]
        public int? AircraftId { get; set; }

        [Column("AircraftExchangeId")]
        public int? AircraftExchangeId { get; set; }

        [Column("DelayReasonId")]
        public int? DelayReasonId { get; set; }

        [Column("CancelReasonId")]
        public int? CancelReasonId { get; set; }

        [Column("ReasonId")]
        public int? ReasonId { get; set; }

        [Column("FlightTrackRecordId")]
        public int? FlightTrackRecordId { get; set; }

        [Column("PeriodFrom")]
        public int? PeriodFrom { get; set; }

        [Column("PeriodTo")]
        public int? PeriodTo { get; set; }

        [Column("PlanDate")]
        public DateTime? PlanDate { get; set; }

        [Column("ParentFlightId")]
        public int? ParentFlightId { get; set; }

        [Column("Remarks")]
        public string Remarks { get; set; }

        [Column("HiddenRemarks")]
        public string HiddenRemarks { get; set; }

        [Column("IsDispatcherEdit")]
        public bool? IsDispatcherEdit { get; set; }

        [Column("IsDispatcherEditLdg")]
        public bool? IsDispatcherEditLdg { get; set; }

        [Column("StatusId")]
        public int StatusId { get; set; }


        public FlightPlanOps ParentFlightPlanOps { get; set; }
        
        public Reason DelayReason { get; set; }
        
        public Reason Reason { get; set; }

        public Reason CancelReason { get; set; }
    }
}