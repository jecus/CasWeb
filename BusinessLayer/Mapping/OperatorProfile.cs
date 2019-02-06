using AutoMapper;
using BusinessLayer.Views;
using Entity.Models;

namespace BusinessLayer.Mapping
{
    public class OperatorProfile : Profile
    {
        public OperatorProfile()
        {
            CreateMap<OperatorView, Operator>()
                .ForMember(dst => dst.ItemId, src => src.MapFrom(x => x.ItemId))
                .ForMember(dst => dst.IsDeleted, src => src.MapFrom(x => x.IsDeleted))
                .ForMember(dst => dst.Name, src => src.MapFrom(x => x.Name))
                .ForMember(dst => dst.ICAOCode, src => src.MapFrom(x => x.ICAOCode))
                .ForMember(dst => dst.Address, src => src.MapFrom(x => x.Address))
                .ForMember(dst => dst.Phone, src => src.MapFrom(x => x.Phone))
                .ForMember(dst => dst.Fax, src => src.MapFrom(x => x.Fax))
                .ForMember(dst => dst.Email, src => src.MapFrom(x => x.Email));
        }
    }
}