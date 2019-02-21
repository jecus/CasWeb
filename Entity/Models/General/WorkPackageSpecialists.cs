using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("WorkPackageSpecialists", Schema = "dbo")]
    public class WorkPackageSpecialists : BaseEntity
    {
        [Column("WorkPackageId")]
        public int WorkPackageId { get; set; }

        [Column("SpecialistId")]
        public int SpecialistId { get; set; }
    }
}