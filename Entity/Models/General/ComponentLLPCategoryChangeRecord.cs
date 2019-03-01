using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.Dictionaries;

namespace Entity.Models.General
{
    [Table("ComponentLLPCategoryChangeRecords", Schema = "dbo")]
    public class ComponentLLPCategoryChangeRecord : BaseEntity
    {
        [Column("ParentId")]
        public int? ParentId { get; set; }

        [Column("RecordDate")]
        public DateTime? RecordDate { get; set; }

        [Column("ToCategoryId")]
        public int? ToCategoryId { get; set; }

        [Column("OnLifeLength")]
        [MaxLength(50)]
        public byte[] OnLifeLength { get; set; }

        [Column("Remarks")]
        [MaxLength(250)]
        public string Remarks { get; set; }

        
        public LifeLimitCategorie ToCategory { get; set; }

        
        //[Child(FilterType.Equal, "ParentTypeId", 1200)]
        //public ICollection<ItemFileLink> Files { get; set; }

        #region Navigation Property

        public Component Component { get; set; }

        #endregion
    }
}