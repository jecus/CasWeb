﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("EventConditions", Schema = "dbo")]
    public class EventCondition : BaseEntity
    {
        [Column("EventConditionTypeId")]
        public int? EventConditionTypeId { get; set; }

        [Column("ValueId")]
        public int? ValueId { get; set; }

        [Column("ParentId")]
        public int? ParentId { get; set; }

        [Column("ParentTypeId")]
        public int? ParentTypeId { get; set; }


        #region Navigation Property

        public Event Event { get; set; }

        #endregion
    }
}