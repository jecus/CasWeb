namespace BusinessLayer.Views
{
	public class BaseView : IBaseView
	{
		public int ItemId { get; set; }
		public bool IsDeleted { get; set; }
	}
}