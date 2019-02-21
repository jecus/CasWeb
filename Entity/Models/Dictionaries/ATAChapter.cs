using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.General;

namespace Entity.Models.Dictionaries
{
    [Table("ATAChapter", Schema = "Dictionaries")]
    public class ATAChapter : BaseEntity
    {
        [Column("ShortName")]
        [MaxLength(100)]
        public string ShortName { get; set; }

        [Column("FullName")]
        [MaxLength(100)]
        public string FullName { get; set; }

        #region Navigation Property

        
        public ICollection<AccessoryDescription> AccessoryDescriptions { get; set; }
        
        public ICollection<NonRoutineJob> NonRoutineJobs { get; set; }
        
        public ICollection<Component> Components { get; set; }
        
        public ICollection<Directive> Directives { get; set; }
        
        public ICollection<Discrepancy> Discrepancys { get; set; }
        
        public ICollection<MaintenanceDirective> MaintenanceDirectives { get; set; }
        
        public ICollection<JobCard> JobCards { get; set; }

        #endregion
    }
}