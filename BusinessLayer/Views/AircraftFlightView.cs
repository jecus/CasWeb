using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BusinessLayer.Dictionaties;
using Entity.Models.Dictionaries;

namespace BusinessLayer.Views
{
    public class AircraftFlightView : BaseView
    {
        private AirportCodeView _stationFroms;
        private FlightNumView _flightNumber;
        private AirportCodeView _stationTos;

        public AircraftFlightView()
        {
            FlightDate = DateTime.Now;
        }
        
        public int ATLBID { get; set; }

        public int? AircraftId { get; set; }

        public string FlightNo { get; set; }

        public string Remarks { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("FlightDate")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime FlightDate { get; set; }

        public string StationFrom { get; set; }

        public string StationTo { get; set; }

        public short? DelayTime { get; set; }

        public int? DelayReasonId { get; set; }

        public int OutTime { get; set; }
        #region public TimeSpan TimespanOutTime
        /// <summary>
        /// Время посадки воздушного судна
        /// </summary>
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"{0:hh\:mm}")]
        public TimeSpan TimespanOutTime => new TimeSpan(OutTime / 60, OutTime - (OutTime / 60) * 60, 0);

        #endregion

        public int InTime { get; set; }
        #region public TimeSpan TimespanInTime
        /// <summary>
        /// Время посадки воздушного судна
        /// </summary>
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"{0:hh\:mm}")]
        public TimeSpan TimespanInTime => new TimeSpan(InTime / 60, InTime - (InTime / 60) * 60, 0);

        #endregion

        public int TakeOffTime { get; set; }

        #region public TimeSpan TimespanTakeOffTime
        /// <summary>
        /// Время посадки воздушного судна
        /// </summary>
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"{0:hh\:mm}")]
        public TimeSpan TimespanTakeOffTime => new TimeSpan(TakeOffTime / 60, TakeOffTime - (TakeOffTime / 60) * 60, 0);

        #endregion
        
        public int LDGTime { get; set; }
        
        #region public TimeSpan TimespanLDGTime
        /// <summary>
        /// Время посадки воздушного судна
        /// </summary>
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"{0:hh\:mm}")]
        public TimeSpan TimespanLDGTime => new TimeSpan(LDGTime / 60, LDGTime - (LDGTime / 60) * 60, 0);
        #endregion

        public int NightTime { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"{0:hh\:mm}")]
        public TimeSpan TimeSpanNightTime => FlightDate.Date.AddMinutes(NightTime).TimeOfDay;

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

        public FlightType FlightType { get; set; }

        public int? LevelId { get; set; }

        public int? Distance { get; set; }

        public Measure DistanceMeasure { get; set; }

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


        public FlightNumView FlightNumber
        {
            get => _flightNumber ?? FlightNumView.Unknown; 
            set => _flightNumber = value;
        }

        public CruiseLevelView Level { get; set; }

        public AirportCodeView StationFroms
        {
            get => _stationFroms ?? AirportCodeView.Unknown;
            set => _stationFroms = value;
        }

        public AirportCodeView StationTos
        {
            get => _stationTos ?? AirportCodeView.Unknown;
            set => _stationTos = value;
        }
        public ReasonView DelayReason { get; set; }

        public ReasonView CancelReason { get; set; }

        public string Route { get; set; }
        public string Times { get; set; }

        #region public TimeSpan BlockTime
        /// <summary>
        /// Время полета ВС по Out-In
        /// </summary>
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"{0:hh\:mm}")]
        public TimeSpan BlockTime
        {
            get
            {
                int blockTime = InTime - OutTime;
                if (blockTime < 0) blockTime += 24 * 60;
                return new TimeSpan(blockTime / 60, blockTime - (blockTime / 60) * 60, 0);
            }
        }

        #endregion

        #region public TimeSpan FlightTime
        /// <summary>
        /// Время полета ВС по Takeoff-LDG
        /// </summary>
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"{0:hh\:mm}")]
        public TimeSpan FlightTime
        {
            get
            {
                int flightTime = LDGTime - TakeOffTime;
                if (flightTime < 0) flightTime += 24 * 60;

                return new TimeSpan(flightTime / 60, flightTime - (flightTime / 60) * 60, 0);
            }
        }
        #endregion
    }
}