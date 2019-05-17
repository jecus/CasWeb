using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("Supplier", Schema = "dbo")]
    public class Supplier : BaseEntity
    {
        [Column("Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Column("ShortName")]
        [MaxLength(50)]
        public string ShortName { get; set; }

        [Column("AirCode")]
        [MaxLength(256)]
        public string AirCode { get; set; }

        [Column("VendorCode")]
        [MaxLength(50)]
        public string VendorCode { get; set; }

        [Column("Phone")]
        [MaxLength(50)]
        public string Phone { get; set; }

        [Column("Fax")]
        [MaxLength(50)]
        public string Fax { get; set; }

        [Column("Address")]
        [MaxLength(200)]
        public string Address { get; set; }

        [Column("ContactPerson")]
        [MaxLength(50)]
        public string ContactPerson { get; set; }

        [Column("Email")]
        [MaxLength(50)]
        public string Email { get; set; }

        [Column("WebSite")]
        [MaxLength(50)]
        public string WebSite { get; set; }

        [Column("Products")]
        [MaxLength(200)]
        public string Products { get; set; }

        [Column("Approved")]
        public bool? Approved { get; set; }

        [Column("Remarks")]
        [MaxLength(200)]
        public string Remarks { get; set; }

        [Column("SupplierClassId")]
        public int SupplierClassId { get; set; }

        [Column("Subject")]
        public string Subject { get; set; }

        
        //[Child(FilterType.Equal, "ParentTypeId", 2048)]
        public ICollection<Document> SupplierDocs { get; set; }


        #region Navigation Property

        public ICollection<Component> Components { get; set; }
       
        public ICollection<Document> Documents { get; set; }
        
        public ICollection<FlightTrack> FlightTracks { get; set; }
        
        public ICollection<SpecialistTraining> SpecialistTrainings { get; set; }
        
        public ICollection<RequestForQuotationRecord> RequestForQuotationRecords { get; set; }
        
        public ICollection<PurchaseRequestRecord> PurchaseRequestRecords { get; set; }
        
        public ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        
        public ICollection<KitSuppliersRelation> KitSuppliersRelations { get; set; }
		

        #endregion
    }
}