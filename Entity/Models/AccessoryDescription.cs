using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models
{
	[Table("AccessoryDescriptions", Schema = "Dictionaries")]
	public class AccessoryDescription : BaseEntity
	{
		[Column("FullName")]
		[MaxLength(256)]
		public string FullName { get; set; }

		[Column("ShortName")]
		[MaxLength(256)]
		public string ShortName { get; set; }


		#region Navigation

		public ICollection<Aircraft> Aircrafts { get; set; }

		#endregion
	}
}