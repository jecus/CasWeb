using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("JobCardTasks", Schema = "dbo")]
    public class JobCardTask : BaseEntity
    {
        [Column("JobCardId")]
		public int? JobCardId { get; set; }

        [Column("ParentTaskId")]
        public int? ParentTaskId { get; set; }

        [Column("Number")]
        [MaxLength(256)]
        public string Number { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Man")]
        public int? Man { get; set; }

		[Column("ManHours")]
        public double? ManHours { get; set; }

        [Column("Cost")]
        public double? Cost { get; set; }

		public JobCard JobCard { get; set; }

    }
}