﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("Operators", Schema = "dbo")]
    public class Operator : BaseEntity
    {
        [Key]
        [Column("OperatorID")]
        public override int Id { get; set; }

        [Column("Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Column("LogoType")]
        public byte[] LogoType { get; set; }

        [Column("ICAOCode")]
        [MaxLength(50)]
        public string ICAOCode { get; set; }

        [Column("Address")]
        [MaxLength(200)]
        public string Address { get; set; }

        [Column("Phone")]
        [MaxLength(100)]
        public string Phone { get; set; }

        [Column("Fax")]
        [MaxLength(100)]
        public string Fax { get; set; }

        [Column("LogoTypeWhite")]
        public byte[] LogoTypeWhite { get; set; }

        [Column("Email")]
        [MaxLength(50)]
        public string Email { get; set; }

        [Column("LogotypeReportLarge")]
        public byte[] LogotypeReportLarge { get; set; }

        [Column("LogotypeReportVeryLarge")]
        public byte[] LogotypeReportVeryLarge { get; set; }
    }
}