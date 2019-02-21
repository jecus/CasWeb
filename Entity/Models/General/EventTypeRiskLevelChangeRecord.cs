using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.Dictionaries;

namespace Entity.Models.General
{
    [Table("EventTypeRiskLevelChangeRecords", Schema = "dbo")]
    public class EventTypeRiskLevelChangeRecord : BaseEntity
    {
        [Column("EventCategoryId")]
        public int? EventCategoryId { get; set; }

        [Column("EventClassId")]
        public int? EventClassId { get; set; }

        [Column("IncidentTypeId")]
        public int? IncidentTypeId { get; set; }

        [Column("RecordDate")]
        public DateTime? RecordDate { get; set; }

        [Column("Remarks")]
        [MaxLength(128)]
        public string Remarks { get; set; }

        [Column("ParentId")]
        public int? ParentId { get; set; }

        
        public EventCategorie EventCategory { get; set; }
        
        public EventClass EventClass { get; set; }

        public SmsEventType ParentEventType { get; set; }
    }
}