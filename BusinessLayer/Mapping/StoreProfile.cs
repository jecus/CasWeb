using AutoMapper;
using BusinessLayer.Views;
using Entity.Models;
using Entity.Models.General;

namespace BusinessLayer.Mapping
{
    public class StoreProfile : Profile
    {
        public StoreProfile()
        {
            CreateMap<StoreView, Store>()
                .ForMember(dst => dst.ItemId, src => src.MapFrom(x => x.ItemId))
                .ForMember(dst => dst.IsDeleted, src => src.MapFrom(x => x.IsDeleted))
                .ForMember(dst => dst.StoreName, src => src.MapFrom(x => x.StoreName));
        }
    }
}