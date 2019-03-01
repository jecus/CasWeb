using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.Dictionaries;

namespace Entity.Models.General
{
    [Table("Kits", Schema = "dbo")]
    public class AccessoryRequired : BaseEntity
    {
        [Column("ParentId")]
        public int? ParentId { get; set; }

        [Column("ParentTypeId")]
        public int? ParentTypeId { get; set; }

        [Column("IsNonRoutineKit")]
        public bool? IsNonRoutineKit { get; set; }

        [Column("AircraftModelId")]
        public int? AircraftModelId { get; set; }

        [Column("PartNumber")]
        [MaxLength(100)]
        public string PartNumber { get; set; }

        [Column("Description")]
        [MaxLength(200)]
        public string Description { get; set; }

        [Column("Manufacturer")]
        [MaxLength(100)]
        public string Manufacturer { get; set; }

        [Column("Measure")]
        public int? Measure { get; set; }

        [Column("Quantity")]
        public double? Quantity { get; set; }

        [Column("CostNew")]
        public double? CostNew { get; set; }

        [Column("CostServiceable")]
        public double? CostServiceable { get; set; }

        [Column("CostOverhaul")]
        public double? CostOverhaul { get; set; }

        [Column("Remarks")]
        public string Remarks { get; set; }

        [Column("AccessoryDescriptionId")]
        public int? AccessoryDescriptionId { get; set; }

        [Column("GoodStandartId")]
        public int? GoodStandartId { get; set; }

        
        public AccessoryDescription Product { get; set; }

        public GoodStandart Standart { get; set; }

        #region Navigation Property

        public ComponentDirective ComponentDirective { get; set; }
        
        public Component Component { get; set; }
        
        public Directive Directive { get; set; }
        
        public WorkOrder WorkOrder { get; set; }
       
        public Request Request { get; set; }
        
        public Procedure Procedure { get; set; }
        
        public MaintenanceDirective MaintenanceDirective { get; set; }
        
        public MaintenanceCheck MaintenanceCheck { get; set; }
        
        public JobCard JobCard { get; set; }


        #endregion
    }
}