namespace BusinessLayer.Views
{
    public class ServiceTypeView : BaseView
    {
        private static ServiceTypeView _unknown;

        public string Name { get; set; }

        public string FullName { get; set; }

        #region public static ServiceType Unknown

        public static ServiceTypeView Unknown
        {
            get
            {
                return _unknown ?? (_unknown = new ServiceTypeView
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