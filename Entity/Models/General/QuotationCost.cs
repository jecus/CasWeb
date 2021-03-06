﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("QuotationCost", Schema = "dbo")]
    public class QuotationCost : BaseEntity
    {
        [Column("CostNew")]
        public double CostNew { get; set; }

        [Column("ProductId")]
        public int ProductId { get; set; }

        [Column("SupplierId")]
        public int SupplierId { get; set; }

        [Column("QuotationId")]
        public int QuotationId { get; set; }

        [Column("CostServisible")]
        public double CostServisible { get; set; }

        [Column("CostOverhaul")]
        public double CostOverhaul { get; set; }

        [Column("CurrencyId")]
        public int CurrencyId { get; set; }
    }
}