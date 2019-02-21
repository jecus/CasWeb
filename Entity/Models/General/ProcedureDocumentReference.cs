using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models.General
{
    [Table("ProcedureDocumentReferences", Schema = "dbo")]
    public class ProcedureDocumentReference : BaseEntity
    {
        [Column("ProcedureId")]
        public int? ProcedureId { get; set; }

        [Column("DocumentId")]
        public int? DocumentId { get; set; }

        
        
        public Document Document { get; set; }

        //[DataMember]
        //[Include]
        //public ProcedureDTO Procedure { get; set; }

        #region Navigation Property

        //[DataMember]
        //public ProcedureDTO ProcedureDto { get; set; }

        #endregion
    }
}