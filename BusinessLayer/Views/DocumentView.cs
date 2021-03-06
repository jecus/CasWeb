﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using BusinessLayer.Dictionaties;
using Entity.Enums;
using Entity.Models.General;

namespace BusinessLayer.Views
{
    public class DocumentView : BaseView
    {
        private NomenclatureView _nomenсlature;
        private DocumentSubTypeView _documentSubType;
        private SpecializationView _responsibleOccupation;
        private SupplierView _supplier;
        private ServiceTypeView _serviceType;
        private DepartmentView _department;
        private LocationView _location;
        public int? ParentID { get; set; }

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
            get { return Description.Length > 60 ? Description.Substring(0, 59).Insert(59, "...") : Description; }
        }

        [DataType(DataType.Date)]
        [DisplayName("IssueDateValidFrom")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime IssueDateValidFrom { get; set; }

        public bool? IssueValidTo { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("IssueDateValidTo")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime IssueDateValidTo { get; set; }

        public int? IssueNotify { get; set; }

        public string ContractNumber { get; set; }

        public string ShortContractNumber
        {
            get { return ContractNumber.Length > 15 ? ContractNumber.Substring(0, 14).Insert(14, "...") : ContractNumber; }
        }

        public bool? Revision { get; set; }

        public string RevNumber { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("RevisionDateFrom")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? RevisionDateFrom { get; set; }

        public bool? IsClosed { get; set; }

        public int? DepartmentId { get; set; }

        public bool? RevisionValidTo { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("RevisionDateValidTo")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? RevisionDateValidTo { get; set; }

        public string RevisionDateValidToString => RevisionDateValidTo.ToUniversalString();


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

		public ItemFileLink ItemFileLink { get; set; }
		public int FileId => ItemFileLink?.FileId ?? -1;

        public DocumentSubTypeView DocumentSubType
        {
            get => _documentSubType ?? DocumentSubTypeView.Unknown;
            set => _documentSubType = value;
        }

        public SupplierView Supplier
        {
            get => _supplier ?? SupplierView.Unknown;
            set => _supplier = value;
        }

        public SpecializationView ResponsibleOccupation
        {
            get => _responsibleOccupation ?? SpecializationView.Unknown;
            set => _responsibleOccupation = value;
        }

        public NomenclatureView Nomenсlature
        {
            get => _nomenсlature ?? NomenclatureView.Unknown;
            set => _nomenсlature = value;
        }

        public ServiceTypeView ServiceType
        {
            get => _serviceType ?? ServiceTypeView.Unknown;
            set => _serviceType = value;
        }

        public DepartmentView Department
        {
            get => _department ?? DepartmentView.Unknown;
            set => _department = value;
        }

        public LocationView Location
        {
            get => _location ?? LocationView.Unknown;
            set => _location = value;
        }
    }
}