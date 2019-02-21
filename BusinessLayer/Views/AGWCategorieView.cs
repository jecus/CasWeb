using Entity.Enums;

namespace BusinessLayer.Views
{
    public class AGWCategorieView : BaseView
    {
        public string FullName { get; set; }

        public Gender Gender { get; set; }

        public int? MinAge { get; set; }

        public int? MaxAge { get; set; }

        public int? WeightSummer { get; set; }

        public int? WeightWinter { get; set; }
    }
}