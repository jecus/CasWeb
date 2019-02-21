using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("WorkOrderRecords", Schema = "dbo")]
    public class WorkOrderRecord : BaseEntity
    {
        [Column("ParentId")]
        public int? ParentId { get; set; }

        [Column("DirectivesId")]
        public int? DirectivesId { get; set; }

        [Column("PackageItemTypeId")]
        public int? PackageItemTypeId { get; set; }


        #region Navigation Property

        public WorkOrder WorkOrder { get; set; }

        #endregion
    }
}