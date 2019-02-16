using AutoMapper;
using BusinessLayer.Views;
using Entity.Models;

namespace BusinessLayer.Mapping
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<DepartmentView, Department>()
                .ForMember(dst => dst.ItemId, src => src.MapFrom(x => x.ItemId))
                .ForMember(dst => dst.IsDeleted, src => src.MapFrom(x => x.IsDeleted))
                .ForMember(dst => dst.Name, src => src.MapFrom(x => x.Name))
                .ForMember(dst => dst.FullName, src => src.MapFrom(x => x.FullName));
        }
    }
}