using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("ATLBs", Schema = "dbo")]
    public class ATLB : BaseEntity
    {
        [Column("AircraftID")]
        public int? AircraftID { get; set; }

        [Column("ATLBNo")]
        [MaxLength(128)]
        public string ATLBNo { get; set; }

        [Column("StartPageNo")]
        public int? StartPageNo { get; set; }

        [Column("OpeningDate")]
        public DateTime? OpeningDate { get; set; }

        [Column("Remarks")]
        public string Remarks { get; set; }

        [Column("Revision")]
        [MaxLength(128)]
        public string Revision { get; set; }

        [Column("PageFlightCount")]
        public int? PageFlightCount { get; set; }

        [Column("AtlbStatus")]
        public int AtlbStatus { get; set; }


        
        //[Child(FilterType.Equal, "ParentTypeId", 1040)]
        //public ICollection<ItemFileLink> Files { get; set; }
    }
}