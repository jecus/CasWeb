using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("Cas3MaintenanceCheck", Schema = "dbo")]
    public class MaintenanceCheck : BaseEntity
    {
        [Column("Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Column("Interval")]
        public byte[] Interval { get; set; }

        [Column("Notify")]
        public byte[] Notify { get; set; }

        [Column("ParentAircraft")]
        public int ParentAircraft { get; set; }

        [Column("CheckTypeId")]
        public int? CheckTypeId { get; set; }

        [Column("Cost")]
        public double? Cost { get; set; }

        [Column("ManHours")]
        public double? ManHours { get; set; }

        [Column("Schedule")]
        public bool? Schedule { get; set; }

        [Column("Resource")]
        public short Resource { get; set; }

        [Column("Grouping")]
        public bool Grouping { get; set; }

        
        public MaintenanceCheckType CheckType { get; set; }

        //[Child(FilterType.Equal, "ParentTypeId", 3)]
        public ICollection<DirectiveRecord> PerformanceRecords { get; set; }

        //[Child(FilterType.Equal, "ParentTypeId", 3)]
        public ICollection<CategoryRecord> CategoriesRecords { get; set; }

        //[Child(FilterType.Equal, "ParentTypeId", 3)]
        public ICollection<AccessoryRequired> Kits { get; set; }

        public ICollection<MaintenanceDirective> BindMpds { get; set; }
		
    }
}