using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models
{
	public class ItemIdModel
	{
		[Column("ItemId")]
		public int Id { get; set; }
	}
}