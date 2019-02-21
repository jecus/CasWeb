using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Enums;
using Entity.Models.General;

namespace Entity.Models.Dictionaries
{
    [Table("AGWCategories", Schema = "Dictionaries")]
    public class AGWCategorie : BaseEntity
    {
        [Column("FullName")]
        [MaxLength(128)]
        public string FullName { get; set; }

        [Column("Gender")]
        public Gender Gender { get; set; }

        [Column("MinAge")]
        public int? MinAge { get; set; }

        [Column("MaxAge")]
        public int? MaxAge { get; set; }

        [Column("WeightSummer")]
        public int? WeightSummer { get; set; }

        [Column("WeightWinter")]
        public int? WeightWinter { get; set; }

        #region Navigation Property

        
        public ICollection<FlightPassengerRecord> FlightPassengerRecords { get; set; }
        
        public ICollection<Specialist> Specialists { get; set; }

        #endregion
    }
}