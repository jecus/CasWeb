using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.Calculated
{
	public class WpManHours
	{
		[Column("ItemId")]
		public int Id { get; set; }

		[Column("MH")]
		public double? ManHours { get; set; }
		
	}
}