namespace BusinessLayer.Views
{
    public class LocationView : BaseView
    {
        private static LocationView _unknown;
        public string Name { get; set; }

        public string FullName { get; set; }

        public int LocationsTypeId { get; set; }

        #region public static Nomenclatures Unknown

        public static LocationView Unknown
        {
            get
            {
                return _unknown ?? (_unknown = new LocationView
                {
                    ItemId = -1,
                    FullName = "Unknown",
                    Name = "UNK"
                });
            }
        }

        #endregion
    }
}