namespace BusinessLayer.Views
{
    public class SpecializationView : BaseView
    {
        private static SpecializationView _unknown;
        public string FullName { get; set; }

        public string ShortName { get; set; }

        public int DepartmentId { get; set; }

        public int Level { get; set; }

        public bool KeyPersonel { get; set; }

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