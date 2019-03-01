namespace Entity
{
	public interface IBaseEntity
	{
		int Id { get; set; }
		bool IsDeleted { get; set; }
	}
}