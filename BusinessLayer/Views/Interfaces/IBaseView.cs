namespace BusinessLayer.Views
{
	public interface IBaseView
	{
		int Id { get; set; }
		bool IsDeleted { get; set; }
	}
}