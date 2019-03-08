using System;
using Entity.Models.Dictionaries;

namespace BusinessLayer.Views
{
    public class AircraftFlightView : BaseView
    {
        public int ATLBID { get; set; }

        public int? AircraftId { get; set; }

        public string FlightNo { get; set; }

        public string Remarks { get; set; }

        public DateTime? FlightDate { get; set; }

        public string StationFrom { get; set; }

        public string StationTo { get; set; }

        public short? DelayTime { get; set; }

        public int? DelayReasonId { get; set; }

        public int? OutTime { get; set; }

        public int? InTime { get; set; }

        public int? TakeOffTime { get; set; }

        public int? LDGTime { get; set; }

        public int? NightTime { get; set; }

        public int? CRSID { get; set; }

        public int? FileID { get; set; }

        public string Tanks { get; set; }

        public string Fluids { get; set; }

        public string EnginesGeneralCondition { get; set; }

        public int? Highlight { get; set; }

        public bool Correct { get; set; }

        public string Reference { get; set; }

        public int Cycles { get; set; }

        public string PageNo { get; set; }

        public short? FlightType { get; set; }

        public int? LevelId { get; set; }

        public int? Distance { get; set; }

        public int? DistanceMeasure { get; set; }

        public double? TakeOffWeight { get; set; }

        public double? AlignmentBefore { get; set; }

        public double? AlignmentAfter { get; set; }

        public FlightCategory? FlightCategory { get; set; }

        public AtlbRecordType AtlbRecordType { get; set; }

        public FlightAircraftCode? FlightAircraftCode { get; set; }
        
        public int? CancelReasonId { get; set; }
        
        public int? StationFromId { get; set; }

        public int? StationToId { get; set; }

        public int FlightNumberId { get; set; }


        public FlightNum FlightNumber { get; set; }

        public CruiseLevel Level { get; set; }

        public AirportCode StationFroms { get; set; }

        public AirportCode StationTos { get; set; }

        public Reason DelayReason { get; set; }

        public Reason CancelReason { get; set; }
    }
}