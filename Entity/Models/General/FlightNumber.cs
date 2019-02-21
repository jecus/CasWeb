using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.Dictionaries;

namespace Entity.Models.General
{
    [Table("FlightNumbers", Schema = "dbo")]
    public class FlightNumber : BaseEntity
    {
        [Column("FlightNo")]
        public int FlightNoId { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Remarks")]
        public string Remarks { get; set; }

        [Column("HiddenRemarks")]
        public string HiddenRemarks { get; set; }

        [Column("MaxFuelAmount")]
        public double? MaxFuelAmount { get; set; }

        [Column("MinFuelAmount")]
        public double? MinFuelAmount { get; set; }

        [Column("MaxPayload")]
        public double? MaxPayload { get; set; }

        [Column("MaxCargoWeight")]
        public double? MaxCargoWeight { get; set; }

        [Column("MaxTakeOffWeight")]
        public double? MaxTakeOffWeight { get; set; }

        [Column("MaxLandWeight")]
        public double? MaxLandWeight { get; set; }

        [Column("FlightAircraftCode")]
        public int? FlightAircraftCode { get; set; }

        [Column("FlightType")]
        public int FlightType { get; set; }

        [Column("FlightCategory")]
        public int? FlightCategory { get; set; }

        [Column("Distance")]
        public int? Distance { get; set; }

        [Column("DistanceMeasure")]
        public int? DistanceMeasure { get; set; }

        [Column("StationFrom")]
        public int? StationFromId { get; set; }

        [Column("StationTo")]
        public int? StationToId { get; set; }

        [Column("MinLevel")]
        public int? MinLevelId { get; set; }

        [Column("MaxPassengerAmount")]
        public int? MaxPassengerAmount { get; set; }

        [Column("Threshold")]
        [MaxLength(21)]
        public byte[] Threshold { get; set; }

        [Column("IsClosed")]
        public bool? IsClosed { get; set; }


        public FlightNum FlightNo { get; set; }

        public AirportCode StationFrom { get; set; }

        public AirportCode StationTo { get; set; }

        public CruiseLevel MinLevel { get; set; }


        #region Navigation Property

        
        public ICollection<FlightNumberAircraftModelRelation> FlightNumberAircraftModelRelations { get; set; }
        
        public ICollection<FlightNumberAirportRelation> AirportRelations { get; set; }
        
        public ICollection<FlightNumberCrewRecord> FlightNumberCrewRecords { get; set; }

        #endregion
    }
}