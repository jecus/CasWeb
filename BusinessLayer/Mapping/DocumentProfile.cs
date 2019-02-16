using AutoMapper;
using BusinessLayer.Views;
using Entity.Models;

namespace BusinessLayer.Mapping
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<DocumentView, Document>()
                .ForMember(dst => dst.ItemId, src => src.MapFrom(x => x.ItemId))
                .ForMember(dst => dst.IsDeleted, src => src.MapFrom(x => x.IsDeleted))
                .ForMember(dst => dst.ParentID, src => src.MapFrom(x => x.ParentID))
                .ForMember(dst => dst.ParentTypeId, src => src.MapFrom(x => x.ParentTypeId))
                .ForMember(dst => dst.DocTypeId, src => src.MapFrom(x => x.DocTypeId))
                .ForMember(dst => dst.SubTypeId, src => src.MapFrom(x => x.SubTypeId))
                .ForMember(dst => dst.Description, src => src.MapFrom(x => x.Description))
                .ForMember(dst => dst.IssueDateValidFrom, src => src.MapFrom(x => x.IssueDateValidFrom))
                .ForMember(dst => dst.IssueValidTo, src => src.MapFrom(x => x.IssueValidTo))
                .ForMember(dst => dst.IssueDateValidTo, src => src.MapFrom(x => x.IssueDateValidTo))
                .ForMember(dst => dst.IssueNotify, src => src.MapFrom(x => x.IssueNotify))
                .ForMember(dst => dst.ContractNumber, src => src.MapFrom(x => x.ContractNumber))
                .ForMember(dst => dst.Revision, src => src.MapFrom(x => x.Revision))
                .ForMember(dst => dst.RevNumber, src => src.MapFrom(x => x.RevNumber))
                .ForMember(dst => dst.RevisionDateFrom, src => src.MapFrom(x => x.RevisionDateFrom))
                .ForMember(dst => dst.IsClosed, src => src.MapFrom(x => x.IsClosed))
                .ForMember(dst => dst.DepartmentId, src => src.MapFrom(x => x.DepartmentId))
                .ForMember(dst => dst.RevisionValidTo, src => src.MapFrom(x => x.RevisionValidTo))
                .ForMember(dst => dst.RevisionDateValidTo, src => src.MapFrom(x => x.RevisionDateValidTo))
                .ForMember(dst => dst.RevisionNotify, src => src.MapFrom(x => x.RevisionNotify))
                .ForMember(dst => dst.Aboard, src => src.MapFrom(x => x.Aboard))
                .ForMember(dst => dst.Privy, src => src.MapFrom(x => x.Privy))
                .ForMember(dst => dst.IssueNumber, src => src.MapFrom(x => x.IssueNumber))
                .ForMember(dst => dst.NomenсlatureId, src => src.MapFrom(x => x.NomenсlatureId))
                .ForMember(dst => dst.ProlongationWay, src => src.MapFrom(x => x.ProlongationWay))
                .ForMember(dst => dst.ServiceTypeId, src => src.MapFrom(x => x.ServiceTypeId))
                .ForMember(dst => dst.ResponsibleOccupationId, src => src.MapFrom(x => x.ResponsibleOccupationId))
                .ForMember(dst => dst.Remarks, src => src.MapFrom(x => x.Remarks))
                .ForMember(dst => dst.LocationId, src => src.MapFrom(x => x.LocationId))
                .ForMember(dst => dst.SupplierId, src => src.MapFrom(x => x.SupplierId))
                .ForMember(dst => dst.ParentAircraftId, src => src.MapFrom(x => x.ParentAircraftId))
                .ForMember(dst => dst.IdNumber, src => src.MapFrom(x => x.IdNumber));
        }
    }
}