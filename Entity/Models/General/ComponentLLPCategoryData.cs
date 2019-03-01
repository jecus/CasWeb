using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.Dictionaries;

namespace Entity.Models.General
{
    [Table("ComponentLLPCategoryData", Schema = "dbo")]
    public class ComponentLLPCategoryData : BaseEntity
    {
        [Column("LLPCategoryId")]
        public int? LLPCategoryId { get; set; }

        [Column("LLPLifeLength")]
        [MaxLength(50)]
        public byte[] LLPLifeLength { get; set; }

        [Column("LLPLifeLimit")]
        [MaxLength(50)]
        public byte[] LLPLifeLimit { get; set; }

        [Column("Notify")]
        [MaxLength(50)]
        public byte[] Notify { get; set; }

        [Column("ComponentId")]
        public int? ComponentId { get; set; }

        [Column("LLPLifeLengthCurrent")]
        [MaxLength(50)]
        public byte[] LLPLifeLengthCurrent { get; set; }

        [Column("LLPLifeLengthForDate")]
        [MaxLength(50)]
        public byte[] LLPLifeLengthForDate { get; set; }

        [Column("Date")]
        public DateTime? Date { get; set; }


        
        public LifeLimitCategorie ParentCategory { get; set; }

        #region Navigation Property

        public Component Component { get; set; }

        #endregion
    }
}