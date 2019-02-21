using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("DamageDocuments", Schema = "dbo")]
    public class DamageDocument : BaseEntity
    {
        [Column("DirectiveId")]
        public int? DirectiveId { get; set; }

        [Column("DamageChartId")]
        public int? DamageChartId { get; set; }

        [Column("DamageLocation")]
        [MaxLength(256)]
        public string DamageLocation { get; set; }

        [Column("DocumentType")]
        public short? DocumentType { get; set; }

        [Column("DamageChart2DImageName")]
        [MaxLength(256)]
        public string DamageChart2DImageName { get; set; }

        
        //[Child(FilterType.Equal, "ParentTypeId", 1185)]
        public ICollection<ItemFileLink> Files { get; set; }

        public ICollection<DamageSector> DamageSectors { get; set; }
        
        public Directive Directive { get; set; }
    }
}