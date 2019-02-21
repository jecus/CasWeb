using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.General;

namespace Entity.Models.Dictionaries
{
    [Table("TripName", Schema = "Dictionaries")]
    public class TripNames : BaseEntity
    {
        [Column("TripName")]
        [MaxLength(256)]
        public string TripName { get; set; }


        #region Navigation Property
        
        public ICollection<FlightTrack> FlightTracks { get; set; }

        #endregion
    }
}