using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("KnowledgeModules", Schema = "dbo")]
    public class KnowledgeModule : BaseEntity
    {
        [Column("Number")]
        [MaxLength(256)]
        public string Number { get; set; }

        [Column("Title")]
        [MaxLength(256)]
        public string Title { get; set; }

        [Column("Description")]
        [MaxLength(2048)]
        public string Description { get; set; }

        #region Navigation Property

        public ICollection<ModuleRecord> ModuleRecords { get; set; }

        #endregion
    }
}