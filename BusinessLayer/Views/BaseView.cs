namespace BusinessLayer.Views
{
	public class BaseView : IBaseView
	{
		public int Id { get; set; }
		public bool IsDeleted { get; set; }
	}
}