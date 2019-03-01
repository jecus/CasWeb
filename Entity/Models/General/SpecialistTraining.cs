using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.Dictionaries;

namespace Entity.Models.General
{
    [Table("SpecialistsTraining", Schema = "dbo")]
    public class SpecialistTraining : BaseEntity
    {
        [Column("SpecialistId")]
        public int? SpecialistId { get; set; }

        [Column("TrainingId")]
        public int? TrainingId { get; set; }

        [Column("SupplierId")]
        public int? SupplierId { get; set; }

        [Column("ManHours")]
        public double? ManHours { get; set; }

        [Column("Cost")]
        public double? Cost { get; set; }

        [Column("Remarks")]
        public string Remarks { get; set; }

        [Column("HiddenRemark")]
        public string HiddenRemark { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Threshold")]
        [MaxLength(200)]
        public byte[] Threshold { get; set; }

        [Column("IsClosed")]
        public bool? IsClosed { get; set; }

        [Column("AircraftTypeID")]
        public int? AircraftTypeID { get; set; }

        [Column("EmployeeSubjectID")]
        public int? EmployeeSubjectID { get; set; }

        
        public AccessoryDescription AircraftType { get; set; }

        public EmployeeSubject EmployeeSubject { get; set; }

        public Supplier Supplier { get; set; }

        //[Child(FilterType.Equal, "ParentTypeId", 1317)]
        //public ICollection<ItemFileLink> Files { get; set; }


        #region Navigation Property

        public Specialist Specialist { get; set; }

        #endregion
    }
}