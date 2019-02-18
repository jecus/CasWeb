namespace BusinessLayer.Views
{
    public class SpecializationView : BaseView
    {
        private static SpecializationView _unknown;
        private DepartmentView _departmentView;

        public string FullName { get; set; }

        public string ShortName { get; set; }

        public int DepartmentId { get; set; }

        public int Level { get; set; }

        public bool KeyPersonel { get; set; }

        public DepartmentView Department
        {
            get => _departmentView ?? DepartmentView.Unknown;
            set => _departmentView = value;
        }

        public static SpecializationView Unknown
        {
            get
            {
                return _unknown ?? (_unknown = new SpecializationView
                {
                    ItemId = -1,
                    FullName = "Unknown",
                    ShortName = "UNK",
                });
            }
        }
    }
}