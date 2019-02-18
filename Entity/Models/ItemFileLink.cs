using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models
{
	[Table("ItemsFilesLinks", Schema = "dbo")]
	public class ItemFileLink : BaseEntity
	{
		[Column("ParentId")]
		public int ParentId { get; set; }
		[Column("ParentTypeId")]
		public int ParentTypeId { get; set; }
		[Column("LinkType")]
		public short LinkType { get; set; }
		[Column("FileId")]
		public int? FileId { get; set; }
	}
}