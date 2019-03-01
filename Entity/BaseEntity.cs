using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
	public class BaseEntity : IBaseEntity
	{
		[Key]
		[Column("ItemId")]
		public virtual int Id { get; set; }

		[Column("IsDeleted")]
		public bool IsDeleted { get; set; }
	}
}