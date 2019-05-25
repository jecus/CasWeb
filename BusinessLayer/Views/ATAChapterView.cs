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


        #region public static GoodsClass Unknown = new GoodsClass(-1, "Unknown", "Unknown", "Unknown");
        /// <summary> 
        /// Неизвестный объект
        /// </summary>
        public static ATAChapterView Unknown = new ATAChapterView()
        {
			Id = -1,
			FullName = "NOT APPLICABLE",
			ShortName = "N/A"
		};
        #endregion
	}
}