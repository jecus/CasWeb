using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Entity.Models
{
	[Table("TransferRecords", Schema = "dbo")]
	public class TransferRecord : BaseEntity
	{
		[Column("ParentID")]
		public int ParentID { get; set; }

		[Column("ParentType")]
		public int? ParentType { get; set; }

		[Required]
		[Column("FromAircraftID")]
		public int FromAircraftID { get; set; }

		[Required]
		[Column("FromStoreID")]
		public int FromStoreID { get; set; }

		[Column("DestinationObjectID")]
		public int? DestinationObjectID { get; set; }

		[Column("DestinationObjectType")]
		public int? DestinationObjectType { get; set; }

		[Column("TransferDate")]
		public DateTime? TransferDate { get; set; }

		[Column("Position")]
		public string Position { get; set; }

		#region Navigation Property

		[DataMember]
		public Component Component { get; set; }

		#endregion
	}
}