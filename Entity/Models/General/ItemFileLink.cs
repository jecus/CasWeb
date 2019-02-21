using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.Dictionaries;

namespace Entity.Models.General
{
    [Table("ItemsFilesLinks", Schema = "dbo")]
    public class ItemFileLink : BaseEntity
    {
        [Column("ParentId")]
        public int ParentId { get; set; }

        [Column("ParentTypeId")]
        public int ParentTypeId { get; set; }

        [Column("LinkType")]
        public short LinkType { get; set; }

        [Column("FileId")]
        public int? FileId { get; set; }

        
        public AttachedFile File { get; set; }


        #region Navigation Property

        //public AircraftFlight AircraftFlight { get; set; }
        
        //public AccessoryDescription AccessoryDescription { get; set; }
        
        //public ATLB Atlb { get; set; }
        
        //public Audit Audit { get; set; }
        
        //public ComponentDirective ComponentDirective { get; set; }
        
        //public Component Component { get; set; }
        
        //public DamageChart DamageChart { get; set; }
        
        //public ComponentLLPCategoryChangeRecord CategoryChangeRecord { get; set; }
        
        //public DamageDocument DamageDocument { get; set; }
        
        //public Directive Directive { get; set; }
        
        //public DirectiveRecord DirectiveRecord { get; set; }
        
        //public DirectiveRecord MaintenanceCheckRecord { get; set; }
        
        //public WorkPackage WorkPackage { get; set; }
        
        //public TransferRecord TransferRecord { get; set; }
        
        //public SupplierDocument SupplierDocument { get; set; }
        
        //public SpecialistTraining SpecialistTraining { get; set; }
        
        //public Specialist SpecialistDto { get; set; }
        
        //public RequestForQuotation RequestForQuotation { get; set; }
       
        //public PurchaseRequestRecord PurchaseRequestRecord { get; set; }
        
        //public PurchaseOrder PurchaseOrder { get; set; }
        
        //public Procedure Procedure { get; set; }
        
        //public MaintenanceDirective MaintenanceDirective { get; set; }
        
        //public InitialOrder InitialOrder { get; set; }

        #endregion
    }
}