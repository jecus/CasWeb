using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Entity.Models.General
{
    [Table("FlightNumberPeriods", Schema = "dbo")]
    public class FlightNumberPeriod : BaseEntity
    {
        [Column("FlightNumberId")]
        public int FlightNumberId { get; set; }

        [Column("PeriodFrom")]
        public int? PeriodFrom { get; set; }

        [Column("PeriodTo")]
        public int? PeriodTo { get; set; }

        [Column("IsMonday")]
        public bool? IsMonday { get; set; }

        [Column("IsThursday")]
        public bool? IsThursday { get; set; }

        [Column("IsWednesday")]
        public bool? IsWednesday { get; set; }

        [Column("IsTuesday")]
        public bool? IsTuesday { get; set; }

        [Column("IsFriday")]
        public bool? IsFriday { get; set; }

        [Column("IsSaturday")]
        public bool? IsSaturday { get; set; }

        [Column("IsSunday")]
        public bool? IsSunday { get; set; }

        [Column("DepartureDate")]
        public DateTime? DepartureDate { get; set; }

        [Column("ArrivalDate")]
        public DateTime? ArrivalDate { get; set; }

        [Column("Schedule")]
        public int Schedule { get; set; }
    }
}