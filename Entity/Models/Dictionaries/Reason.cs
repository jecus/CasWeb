using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.General;

namespace Entity.Models.Dictionaries
{
    [Table("Reasons", Schema = "Dictionaries")]
    public class Reason : BaseEntity
    {
        [Column("Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Column("Category")]
        [MaxLength(50)]
        public string Category { get; set; }


        #region Navigation Property

        
        public ICollection<AircraftFlight> AircraftFlightsDelays { get; set; }
        
        public ICollection<AircraftFlight> AircraftFlightsCancels { get; set; }
        
        public ICollection<FlightPlanOpsRecords> DelayFlightPlanOpsRecords { get; set; }
        
        public ICollection<FlightPlanOpsRecords> ReasonFlightPlanOpsRecords { get; set; }
        
        public ICollection<FlightPlanOpsRecords> CancelFlightPlanOpsRecords { get; set; }

        #endregion
    }
}