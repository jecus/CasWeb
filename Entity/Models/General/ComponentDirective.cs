using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Entity.Models.General
{
    [Table("ComponentDirectives", Schema = "dbo")]
    public class ComponentDirective : BaseEntity
    {
        [Column("DirectiveType")]
        public int DirectiveType { get; set; }

        [Column("Threshold")]
        [MaxLength(200)]
        public byte[] Threshold { get; set; }

        [Column("ManHours")]
        public double? ManHours { get; set; }

        [Column("Remarks")]
        public string Remarks { get; set; }

        [Column("Cost")]
        public double? Cost { get; set; }

        [Column("Highlight")]
        public int? Highlight { get; set; }

        [Column("KitRequired")]
        [MaxLength(50)]
        public string KitRequired { get; set; }

        [Column("FaaFormFileID")]
        public int? FaaFormFileID { get; set; }

        [Column("HiddenRemarks")]
        [MaxLength(128)]
        public string HiddenRemarks { get; set; }

        [Column("IsClosed")]
        public bool? IsClosed { get; set; }

        [Column("MPDTaskTypeId")]
        public int? MPDTaskTypeId { get; set; }

        [Column("NDTType")]
        public short NDTType { get; set; }

        [Column("ComponentId")]
        public int? ComponentId { get; set; }

        [Column("ZoneArea")]
        [MaxLength(256)]
        public string ZoneArea { get; set; }

        [Column("AccessDirective")]
        [MaxLength(256)]
        public string AccessDirective { get; set; }

        [Column("AAM")]
        [MaxLength(256)]
        public string AAM { get; set; }

        [Column("CMM")]
        [MaxLength(256)]
        public string CMM { get; set; }


        
        //[Child(FilterType.Equal, "ParentTypeId", 2)]
        //public ICollection<ItemFileLink> Files { get; set; }
        
        //[Child(FilterType.Equal, "ParentTypeId", 2)]
        public ICollection<DirectiveRecord> PerformanceRecords { get; set; }

        //[Child(FilterType.Equal, "ParentTypeId", 2)]
        public ICollection<CategoryRecord> CategoriesRecords { get; set; }

        //[Child(FilterType.Equal, "ParentTypeId", 2)]
        public ICollection<AccessoryRequired> Kits { get; set; }


        #region Navigation Property

        [DataMember]
        public Component Component { get; set; }

        #endregion
    }
}