using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.Dictionaries
{
    [Table("SchedulePeriods", Schema = "Dictionaries")]
    public class SchedulePeriod : BaseEntity
    {
        [Column("Schedule")]
        public int Schedule { get; set; }

        [Column("DateFrom")]
        public DateTime? DateFrom { get; set; }

        [Column("DateTo")]
        public DateTime? DateTo { get; set; }
    }
}