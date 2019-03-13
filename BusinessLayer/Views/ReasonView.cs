using System.Collections.Generic;
using Entity.Models.General;

namespace BusinessLayer.Views
{
    public class ReasonView : BaseView
    {
        public string Name { get; set; }

        public string Category { get; set; }


        #region Navigation Property


        public ICollection<AircraftFlight> AircraftFlightsDelays { get; set; }

        public ICollection<AircraftFlight> AircraftFlightsCancels { get; set; }

        public ICollection<FlightPlanOpsRecords> DelayFlightPlanOpsRecords { get; set; }

        public ICollection<FlightPlanOpsRecords> ReasonFlightPlanOpsRecords { get; set; }

        public ICollection<FlightPlanOpsRecords> CancelFlightPlanOpsRecords { get; set; }

        #endregion

        public override string ToString()
        {
            return Name;
        }
    }
}