using System;
using BusinessLayer.Dictionaties;
using Entity.Enums;
using Entity.Models;

namespace BusinessLayer.Views
{
    public class DocumentView : BaseView
    {
        public int ParentID { get; set; }

        public int ParentTypeId { get; set; }

        public int DocTypeId { get; set; }

        public DocumentType DocumentType
        {
            get
            {
                return DocumentType.GetDocumentTypeById(DocTypeId);
            }
        }

        public int SubTypeId { get; set; }

        public string Description { get; set; }

        public string ShortDescription
        {
            get { return Description.Length > 30 ? Description.Substring(0, 29).Insert(29, "...") : Description; }
        }

        public DateTime IssueDateValidFrom { get; set; }

        public bool? IssueValidTo { get; set; }

        public DateTime IssueDateValidTo { get; set; }

        public int? IssueNotify { get; set; }

        public string ContractNumber { get; set; }

        public bool? Revision { get; set; }

        public string RevNumber { get; set; }

        public DateTime? RevisionDateFrom { get; set; }

        public bool? IsClosed { get; set; }

        public int? DepartmentId { get; set; }

        public bool? RevisionValidTo { get; set; }

        public DateTime? RevisionDateValidTo { get; set; }

        public int? RevisionNotify { get; set; }

        public bool Aboard { get; set; }

        public bool Privy { get; set; }

        public string IssueNumber { get; set; }

        public int? NomenсlatureId { get; set; }

        public ProlongationWay ProlongationWay { get; set; }

        public int? ServiceTypeId { get; set; }

        public int ResponsibleOccupationId { get; set; }

        public string Remarks { get; set; }

        public int LocationId { get; set; }

        public int SupplierId { get; set; }

        public int? ParentAircraftId { get; set; }

        public string IdNumber { get; set; }

        public DocumentSubTypeView DocumentSubType { get; set; }
        public SupplierView Supplier { get; set; }
        public SpecializationView ResponsibleOccupation { get; set; }
        public NomenclatureView Nomenсlature { get; set; }
        public ServiceTypeView ServiceType { get; set; }
        public DepartmentView Department { get; set; }
        public LocationView Location { get; set; }
    }
}