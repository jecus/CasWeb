namespace BusinessLayer.Views
{
	public class NonRoutineJobView : BaseView
	{
		public int? ATAChapterId { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public double? ManHours { get; set; }

		public double? Cost { get; set; }

		public string KitRequired { get; set; }


		public ATAChapterView ATAChapter { get; set; }
	}
}