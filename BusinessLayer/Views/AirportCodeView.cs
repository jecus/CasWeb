using System.Collections.Generic;
using Entity.Models.General;

namespace BusinessLayer.Views
{
    public class AirportCodeView : BaseView
    {
        private static AirportCodeView _unknown;

        public string Iata { get; set; }

        public string Icao { get; set; }

        public string FullName { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Iso { get; set; }


        public static AirportCodeView Unknown
        {
            get
            {
                return _unknown ?? (_unknown = new AirportCodeView()
                {
                    Id = -1,
                    FullName = "Unknown",
                    Iata = "UNK"
                });
            }
        }

        #region Navigation Property

        public ICollection<FlightNumber> From { get; set; }

        public ICollection<FlightNumber> To { get; set; }

        public ICollection<AircraftFlight> AircraftFlightsFrom { get; set; }

        public ICollection<AircraftFlight> AircraftFlightsTo { get; set; }

        public ICollection<FlightNumberAirportRelation> AirportRelations { get; set; }

        #endregion
    }
}