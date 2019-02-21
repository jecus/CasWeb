using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("DamageSectors", Schema = "dbo")]
    public class DamageSector : BaseEntity
    {
        [Column("DamageChartColumn")]
        public int? DamageChartColumn { get; set; }

        [Column("DamageChartRow")]
        public int? DamageChartRow { get; set; }

        [Column("Remarks")]
        public string Remarks { get; set; }

        [Column("DamageDocumentId")]
        public int? DamageDocumentId { get; set; }


        #region Navigation Property

        public DamageDocument DamageDocument { get; set; }

        #endregion
    }
}