namespace BusinessLayer.Views
{
    public class DepartmentView : BaseView
    {
        private static DepartmentView _unknown;
        public string Name { get; set; }

        public string FullName { get; set; }

        #region public static DepartmentView Unknown

        public static DepartmentView Unknown
        {
            get
            {
                return _unknown ?? (_unknown = new DepartmentView
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