using AutoMapper;
using BusinessLayer.Views;
using Entity.Models;
using Entity.Models.Dictionaries;

namespace BusinessLayer.Mapping
{
    public class LocationProfile : Profile
    {
        public LocationProfile()
        {
            CreateMap<LocationView, Location>()
                .ForMember(dst => dst.ItemId, src => src.MapFrom(x => x.ItemId))
                .ForMember(dst => dst.IsDeleted, src => src.MapFrom(x => x.IsDeleted))
                .ForMember(dst => dst.Name, src => src.MapFrom(x => x.Name))
                .ForMember(dst => dst.FullName, src => src.MapFrom(x => x.FullName))
                .ForMember(dst => dst.LocationsTypeId, src => src.MapFrom(x => x.LocationsTypeId));
        }
    }
}