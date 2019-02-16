using AutoMapper;
using BusinessLayer.Views;
using Entity.Models;

namespace BusinessLayer.Mapping
{
    public class NomenclatureProfile : Profile
    {
        public NomenclatureProfile()
        {
            CreateMap<NomenclatureView, Nomenclature>()
                .ForMember(dst => dst.ItemId, src => src.MapFrom(x => x.ItemId))
                .ForMember(dst => dst.IsDeleted, src => src.MapFrom(x => x.IsDeleted))
                .ForMember(dst => dst.DepartmentId, src => src.MapFrom(x => x.DepartmentId))
                .ForMember(dst => dst.Name, src => src.MapFrom(x => x.Name))
                .ForMember(dst => dst.FullName, src => src.MapFrom(x => x.FullName));
        }
    }
}