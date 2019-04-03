namespace BusinessLayer.Views
{
    public class ATAChapterView : BaseView
    {
        public string ShortName { get; set; }

        public string FullName { get; set; }

        public override string ToString()
        {
            return ShortName + " " + FullName;
        }
    }
}