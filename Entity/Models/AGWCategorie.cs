using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models
{
    [Table("AGWCategories", Schema = "Dictionaries")]
    public class AGWCategorie : BaseEntity
    {
        [MaxLength(128)]
        [Column("FullName")]
        public string FullName { get; set; }

        [Column("Gender")]
        public short? Gender { get; set; }

        [Column("MinAge")]
        public int? MinAge { get; set; }

        [Column("MaxAge")]
        public int? MaxAge { get; set; }

        [Column("WeightSummer")]
        public int? WeightSummer { get; set; }

        [Column("WeightWinter")]
        public int? WeightWinter { get; set; }

        public ICollection<Specialist> Specialists { get; set; }
    }
}