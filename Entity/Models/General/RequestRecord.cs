using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("RequestRecords", Schema = "dbo")]
    public class RequestRecord : BaseEntity
    {
        [Column("ParentId")]
        public int? ParentId { get; set; }

        [Column("DirectivesId")]
        public int? DirectivesId { get; set; }

        [Column("PackageItemTypeId")]
        public int? PackageItemTypeId { get; set; }

        #region Navigation Property

        public Request Request { get; set; }

        #endregion
    }
}