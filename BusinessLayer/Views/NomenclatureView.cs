namespace BusinessLayer.Views
{
    public class NomenclatureView : BaseView
    {
        private static NomenclatureView _unknown;

        public int DepartmentId { get; set; }

		public DepartmentView Department { get; set; }

        public string Name { get; set; }

        public string FullName { get; set; }

        #region public static Nomenclatures Unknown

        public static NomenclatureView Unknown
        {
            get
            {
                return _unknown ?? (_unknown = new NomenclatureView
                {
                    Id = -1,
                    FullName = "Unknown",
                    Name = "UNK",
                });
            }
        }

        #endregion

        public override string ToString()
        {
            return FullName;
        }
    }
}