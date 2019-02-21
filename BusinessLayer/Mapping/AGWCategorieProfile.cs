using AutoMapper;
using BusinessLayer.Views;
using Entity.Models;
using Entity.Models.Dictionaries;

namespace BusinessLayer.Mapping
{
    public class AGWCategorieProfile : Profile
    {
        public AGWCategorieProfile()
        {
            CreateMap<AGWCategorieView, AGWCategorie>()
                .ForMember(dst => dst.ItemId, src => src.MapFrom(x => x.ItemId))
                .ForMember(dst => dst.IsDeleted, src => src.MapFrom(x => x.IsDeleted))
                .ForMember(dst => dst.FullName, src => src.MapFrom(x => x.FullName))
                .ForMember(dst => dst.Gender, src => src.MapFrom(x => x.Gender))
                .ForMember(dst => dst.MinAge, src => src.MapFrom(x => x.MinAge))
                .ForMember(dst => dst.MaxAge, src => src.MapFrom(x => x.MaxAge))
                .ForMember(dst => dst.WeightSummer, src => src.MapFrom(x => x.WeightSummer))
                .ForMember(dst => dst.WeightWinter, src => src.MapFrom(x => x.WeightWinter));
        }
    }
}