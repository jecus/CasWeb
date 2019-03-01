using Entity.Models.Dictionaries;

namespace BusinessLayer.Views
{
    public class LocationView : BaseView
    {
        private static LocationView _unknown;
        private LocationsTypeView _locationsType;
        public string Name { get; set; }

        public string FullName { get; set; }

        public int? LocationsTypeId { get; set; }

        public LocationsTypeView LocationsType
        {
            get => _locationsType ?? LocationsTypeView.Unknown;
            set => _locationsType = value;
        }

        #region public static Nomenclatures Unknown

        public static LocationView Unknown
        {
            get
            {
                return _unknown ?? (_unknown = new LocationView
                {
                    Id = -1,
                    FullName = "Unknown",
                    Name = "UNK"
                });
            }
        }

        #endregion
    }
}