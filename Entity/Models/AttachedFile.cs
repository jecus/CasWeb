using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Entity.Models
{
	[Table("Files", Schema = "dbo")]
	public class AttachedFile : BaseEntity
	{
		[Column("FileName")]
		public string FileName { get; set; }
		[Column("FileData")]
		public byte[] FileData { get; set; }
		[Column("FileSize")]
		public long? FileSize { get; set; }
		[Column("StoreInDatabase")]
		public bool StoreInDatabase { get; set; }
		[Column("FilePath")]
		public string FilePath { get; set; }
	}
}