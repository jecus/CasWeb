using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.Dictionaries;

namespace Entity.Models.General
{
    [Table("CategoryRecords", Schema = "dbo")]
    public class CategoryRecord : BaseEntity
    {
        [Column("EmployeeId")]
        public int? EmployeeId { get; set; }

        [Column("AircraftWorkerCategoryId")]
        public int? AircraftWorkerCategoryId { get; set; }

        [Column("AircraftTypeId")]
        public int? AircraftTypeId { get; set; }

        [Column("ParentId")]
        public int? ParentId { get; set; }

        [Column("ParentTypeId")]
        public int? ParentTypeId { get; set; }


        public AccessoryDescription AircraftModel { get; set; }

        public AircraftWorkerCategory AircraftWorkerCategory { get; set; }



        #region Navigation Property

        public ComponentDirective ComponentDirective { get; set; }
        
        public Component Component { get; set; }
        
        public Directive Directive { get; set; }
        
        public Specialist Specialist { get; set; }
        
        public MaintenanceDirective MaintenanceDirective { get; set; }
        
        public MaintenanceCheck MaintenanceCheck { get; set; }

        #endregion
    }
}