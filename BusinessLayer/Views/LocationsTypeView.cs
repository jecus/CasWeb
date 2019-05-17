namespace BusinessLayer.Views
{
    public class LocationsTypeView : BaseView 
    {
        private static LocationsTypeView _unknown;
        public string Name { get; set; }

        public string FullName { get; set; }

        public int DepartmentId { get; set; }


        public DepartmentView Department { get; set; }

        #region public static Nomenclatures Unknown

        public static LocationsTypeView Unknown
        {
            get
            {
                return _unknown ?? (_unknown = new LocationsTypeView
                {
                    Id = -1,
                    FullName = "Unknown",
                    
                });
            }
        }

        #endregion
    }
}