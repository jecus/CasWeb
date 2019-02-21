using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.Dictionaries
{
    [Table("NonRoutineJobs", Schema = "Dictionaries")]
    public class NonRoutineJob : BaseEntity
    {
        [Column("ATAChapterId")]
        public int? ATAChapterId { get; set; }

        [Column("Title")]
        [MaxLength(50)]
        public string Title { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("ManHours")]
        public double? ManHours { get; set; }

        [Column("Cost")]
        public double? Cost { get; set; }

        [Column("KitRequired")]
        [MaxLength(50)]
        public string KitRequired { get; set; }


        #region Relation

        public ATAChapter ATAChapter { get; set; }

        #endregion
    }
}