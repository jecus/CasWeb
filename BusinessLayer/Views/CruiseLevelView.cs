using System.Collections.Generic;
using Entity.Models.General;

namespace BusinessLayer.Views
{
    public class CruiseLevelView : BaseView
    {
        public string FullName { get; set; }

        public int? Meter { get; set; }

        public int? Feet { get; set; }

        public string IVFR { get; set; }

        public string Track { get; set; }



        #region Navigation Property

        public ICollection<AircraftFlight> AircraftFlights { get; set; }

        public ICollection<FlightNumber> FlightNumbers { get; set; }

        #endregion
    }
}