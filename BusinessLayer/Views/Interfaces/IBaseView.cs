namespace BusinessLayer.Views
{
	public interface IBaseView
	{
		int ItemId { get; set; }
		bool IsDeleted { get; set; }
	}
}