using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.General;

namespace Entity.Models.Dictionaries
{
    [Table("LifeLimitCategories", Schema = "Dictionaries")]
    public class LifeLimitCategorie : BaseEntity
    {
        [Column("CategoryType")]
        [MaxLength(4)]
        public string CategoryType { get; set; }

        [Column("CategoryName")]
        [MaxLength(50)]
        public string CategoryName { get; set; }

        [Column("AircraftModelId")]
        public int? AircraftModelId { get; set; }

        
        public AccessoryDescription AccessoryDescription { get; set; }


        #region Navigation Property
        
        public ICollection<ComponentLLPCategoryChangeRecord> CategoryChangeRecords { get; set; }
        
        public ICollection<ComponentLLPCategoryData> CategoryDatas { get; set; }

        #endregion
    }
}