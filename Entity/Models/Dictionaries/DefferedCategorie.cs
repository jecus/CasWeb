using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.General;

namespace Entity.Models.Dictionaries
{
    [Table("DefferedCategories", Schema = "Dictionaries")]
    public class DefferedCategorie : BaseEntity
    {
        [Column("CategoryName")]
        [MaxLength(50)]
        public string CategoryName { get; set; }

        [Column("AircraftModelId")]
        public int? AircraftModelId { get; set; }

        [Column("Threshold")]
        public byte[] Threshold { get; set; }


        public AccessoryDescription AccessoryDescription { get; set; }

        #region Navigation Property

        public ICollection<InitialOrderRecord> InitialOrderRecords { get; set; }

        public ICollection<RequestForQuotationRecord> RequestForQuotationRecords { get; set; }

        public ICollection<Directive> Directives { get; set; }

        #endregion
    }
}