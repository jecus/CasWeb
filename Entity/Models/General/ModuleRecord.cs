using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("ModuleRecords", Schema = "dbo")]
    public class ModuleRecord : BaseEntity
    {
        [Column("AircraftWorkerCategoryId")]
        public int? AircraftWorkerCategoryId { get; set; }

        [Column("KnowledgeModuleId")]
        public int? KnowledgeModuleId { get; set; }

        [Column("KnowledgeLevel")]
        public int? KnowledgeLevel { get; set; }

        
        public AircraftWorkerCategory AircraftWorkerCategory { get; set; }

        public KnowledgeModule KnowledgeModule { get; set; }
    }
}