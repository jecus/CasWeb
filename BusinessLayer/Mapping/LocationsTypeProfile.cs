using AutoMapper;
using BusinessLayer.Views;
using Entity.Models;
using Entity.Models.Dictionaries;

namespace BusinessLayer.Mapping
{
    public class LocationsTypeProfile : Profile
    {
        public LocationsTypeProfile()
        {
            CreateMap<LocationsTypeView, LocationsType>()
                .ForMember(dst => dst.ItemId, src => src.MapFrom(x => x.ItemId))
                .ForMember(dst => dst.IsDeleted, src => src.MapFrom(x => x.IsDeleted))
                .ForMember(dst => dst.Name, src => src.MapFrom(x => x.Name))
                .ForMember(dst => dst.FullName, src => src.MapFrom(x => x.FullName))
                .ForMember(dst => dst.DepartmentId, src => src.MapFrom(x => x.DepartmentId));
        }
    }
}