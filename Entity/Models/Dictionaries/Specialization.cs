using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.General;

namespace Entity.Models.Dictionaries
{
    [Table("Specializations", Schema = "Dictionaries")]
    public class Specialization : BaseEntity
    {
        [Column("FullName")]
        [MaxLength(128)]
        public string FullName { get; set; }

        [Column("ShortName")]
        [MaxLength(128)]
        public string ShortName { get; set; }

        [Column("DepartmentId")]
        public int DepartmentId { get; set; }

        [Column("Level")]
        public int Level { get; set; }

        [Column("KeyPersonel")]
        public bool KeyPersonel { get; set; }

        

        public Department Department { get; set; }


        #region Navigation Property

        public ICollection<Document> Documents { get; set; }

        public ICollection<FlightCrewRecord> FlightCrewRecords { get; set; }
        
        public ICollection<FlightNumberCrewRecord> FlightNumberCrewRecords { get; set; }
        
        public ICollection<Specialist> Specialists { get; set; }

        #endregion
    }
}