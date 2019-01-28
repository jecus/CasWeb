namespace Entity
{
	public interface IBaseEntity
	{
		int ItemId { get; set; }
		bool IsDeleted { get; set; }
	}
}