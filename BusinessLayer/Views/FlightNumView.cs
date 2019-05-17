namespace BusinessLayer.Views
{
    public class FlightNumView : BaseView
    {
        private static FlightNumView _unknown;

        public string FlightNumber { get; set; }

        public static FlightNumView Unknown
        {
            get
            {
                return _unknown ?? (_unknown = new FlightNumView()
                {
                    FlightNumber = "N/A"
                });
            }
        }

        public override string ToString()
        {
            return FlightNumber;
        }
    }
}