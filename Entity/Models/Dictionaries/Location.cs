using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.Dictionaries
{
    [Table("Locations", Schema = "Dictionaries")]
    public class Location : BaseEntity
    {
        [Column("Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Column("FullName")]
        [MaxLength(256)]
        public string FullName { get; set; }

        [Column("LocationsTypeId")]
        public int LocationsTypeId { get; set; }

        
        public LocationsType LocationsType { get; set; }


        #region Navigation Property

        public ICollection<Component> Components { get; set; }

        public ICollection<Document> Documents { get; set; }

        #endregion
    }
}