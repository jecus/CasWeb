using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entity.Models.General;

namespace Entity.Models.Dictionaries
{
    [Table("EmployeeSubjects", Schema = "Dictionaries")]
    public class EmployeeSubject : BaseEntity
    {
        [Column("Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Column("FullName")]
        [MaxLength(250)]
        public string FullName { get; set; }

        [Column("LicenceTypeId")]
        public int? LicenceTypeId { get; set; }

        #region Navigation Property

        public ICollection<SpecialistTraining> SpecialistTrainings { get; set; }

        #endregion
    }
}