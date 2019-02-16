using AutoMapper;
using BusinessLayer.Views;
using Entity.Models;

namespace BusinessLayer.Mapping
{
    public class SpecializationProfile : Profile
    {
        public SpecializationProfile()
        {
            CreateMap<SpecializationView, Specialization>()
                .ForMember(dst => dst.ItemId, src => src.MapFrom(x => x.ItemId))
                .ForMember(dst => dst.IsDeleted, src => src.MapFrom(x => x.IsDeleted))
                .ForMember(dst => dst.FullName, src => src.MapFrom(x => x.FullName))
                .ForMember(dst => dst.ShortName, src => src.MapFrom(x => x.ShortName))
                .ForMember(dst => dst.DepartmentId, src => src.MapFrom(x => x.DepartmentId))
                .ForMember(dst => dst.Level, src => src.MapFrom(x => x.Level))
                .ForMember(dst => dst.KeyPersonel, src => src.MapFrom(x => x.KeyPersonel));
        }
    }
}