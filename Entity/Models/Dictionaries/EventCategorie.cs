using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.General;

namespace Entity.Models.Dictionaries
{
    [Table("EventCategories", Schema = "Dictionaries")]
    public class EventCategorie : BaseEntity
    {
        [Column("Weight")]
        public int? Weight { get; set; }

        [Column("MinCompareOp")]
        public int? MinCompareOp { get; set; }

        [Column("EventCountMinPeriod")]
        public int? EventCountMinPeriod { get; set; }

        [Column("MinReportPeriod")]
        [MaxLength(21)]
        public byte[] MinReportPeriod { get; set; }

        [Column("MaxCompareOp")]
        public int? MaxCompareOp { get; set; }

        [Column("EventCountMaxPeriod")]
        public int? EventCountMaxPeriod { get; set; }

        [Column("MaxReportPeriod")]
        [MaxLength(21)]
        public byte[] MaxReportPeriod { get; set; }


        #region Navigation Property

        public ICollection<Event> Events { get; set; }
        
        public ICollection<EventTypeRiskLevelChangeRecord> ChangeRecords { get; set; }

        #endregion
    }
}