using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("SmsEventTypes", Schema = "dbo")]
    public class SmsEventType : BaseEntity
    {
        [Column("FullName")]
        [MaxLength(128)]
        public string FullName { get; set; }

        [Column("Description")]
        [MaxLength(128)]
        public string Description { get; set; }


        #region Navigation Property

        public ICollection<Event> Events { get; set; }
        
        public ICollection<EventTypeRiskLevelChangeRecord> ChangeRecords { get; set; }

        #endregion
    }
}