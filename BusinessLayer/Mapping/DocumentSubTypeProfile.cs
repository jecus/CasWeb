using AutoMapper;
using BusinessLayer.Views;
using Entity.Models;
using Entity.Models.Dictionaries;

namespace BusinessLayer.Mapping
{
    public class DocumentSubTypeProfile : Profile
    {
        public DocumentSubTypeProfile()
        {
            CreateMap<DocumentSubTypeView, DocumentSubType>()
                .ForMember(dst => dst.ItemId, src => src.MapFrom(x => x.ItemId))
                .ForMember(dst => dst.IsDeleted, src => src.MapFrom(x => x.IsDeleted))
                .ForMember(dst => dst.DocumentTypeId, src => src.MapFrom(x => x.DocumentTypeId))
                .ForMember(dst => dst.Name, src => src.MapFrom(x => x.Name));
        }
    }
}