using System;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.Dictionaries;

namespace Entity.Models.General
{
    [Table("FlightPassengerRecords", Schema = "dbo")]
    public class FlightPassengerRecord : BaseEntity
    {
        [Column("FlightId")]
        public int? FlightId { get; set; }

        [Column("PassengerCategory")]
        public int? PassengerCategoryId { get; set; }

        [Column("CountEconomy")]
        public short? CountEconomy { get; set; }

        [Column("CountBusiness")]
        public short? CountBusiness { get; set; }

        [Column("CountFirst")]
        public short? CountFirst { get; set; }

        [Column("RecordDate")]
        public DateTime? RecordDate { get; set; }

        
        public AGWCategorie PassengerCategory { get; set; }
    }
}