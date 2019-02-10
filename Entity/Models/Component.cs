using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models
{
	[Table("Components", Schema = "dbo")]
	public class Component : BaseEntity
	{
		[Column("Model")]
		public int? ModelId { get; set; }

		[Column("Manufacturer")]
		[MaxLength(128)]
		public string Manufacturer { get; set; }

		[Column("SerialNumber")]
		[MaxLength(128)]
		public string SerialNumber { get; set; }

		[Column("PartNumber")]
		[MaxLength(128)]
		public string PartNumber { get; set; }

		[Column("ManufactureDate")]
		public DateTime? ManufactureDate { get; set; }

		[Column("StartDate")]
		public DateTime? StartDate { get; set; }

		[Required]
		[Column("IsBaseComponent")]
		public bool IsBaseComponent { get; set; }

		[Required]
		[Column("BaseComponentTypeId")]
		public int BaseComponentTypeId { get; set; }


		#region Navigation

		public ICollection<TransferRecord> TransferRecords { get; set; }
		public virtual AccessoryDescription Model { get; set; }

		#endregion

	}
}