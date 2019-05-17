﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.Dictionaries
{
    [Table("DamageCharts", Schema = "Dictionaries")]
    public class DamageChart : BaseEntity
    {
        [Column("ChartName")]
        [MaxLength(50)]
        public string ChartName { get; set; }

        [Column("AircraftModelId")]
        public int? AircraftModelId { get; set; }

        
        //[Child(FilterType.Equal, "ParentTypeId", 1180)]
        //public ICollection<ItemFileLink> Files { get; set; }


        public AccessoryDescription AccessoryDescription { get; set; }
    }
}