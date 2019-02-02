using AutoMapper;
using BusinessLayer.Views;
using Entity.Models;

namespace BusinessLayer.Mapping
{
    public class AircraftProfile : Profile
    {
        public AircraftProfile()
        {
            CreateMap<AircraftView, Aircraft>()
                .ForMember(dst => dst.ItemId, src => src.MapFrom(x => x.ItemId))
                .ForMember(dst => dst.IsDeleted, src => src.MapFrom(x => x.IsDeleted))
                .ForMember(dst => dst.RegistrationNumber, src => src.MapFrom(x => x.RegistrationNumber));
        }
    }
}