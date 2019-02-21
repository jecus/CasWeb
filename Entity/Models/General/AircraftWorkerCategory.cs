using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("AircraftWorkerCategories", Schema = "dbo")]
    public class AircraftWorkerCategory : BaseEntity
    {
        [Column("Category")]
        [MaxLength(256)]
        public string Category { get; set; }


        #region Navigation Property

       
        public ICollection<ModuleRecord> ModuleRecords { get; set; }
       
        public ICollection<CategoryRecord> CategoryRecords { get; set; }
       
        public ICollection<JobCard> JobCards { get; set; }

        #endregion
    }
}