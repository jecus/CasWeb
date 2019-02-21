using AutoMapper;
using BusinessLayer.Views;
using Entity.Models;
using Entity.Models.General;

namespace BusinessLayer.Mapping
{
    public class SupplierProfile : Profile
    {
        public SupplierProfile()
        {
            CreateMap<SupplierView, Supplier>()
                .ForMember(dst => dst.ItemId, src => src.MapFrom(x => x.ItemId))
                .ForMember(dst => dst.IsDeleted, src => src.MapFrom(x => x.IsDeleted))
                .ForMember(dst => dst.Name, src => src.MapFrom(x => x.Name))
                .ForMember(dst => dst.ShortName, src => src.MapFrom(x => x.ShortName))
                .ForMember(dst => dst.AirCode, src => src.MapFrom(x => x.AirCode))
                .ForMember(dst => dst.VendorCode, src => src.MapFrom(x => x.VendorCode))
                .ForMember(dst => dst.Phone, src => src.MapFrom(x => x.Phone))
                .ForMember(dst => dst.Fax, src => src.MapFrom(x => x.Fax))
                .ForMember(dst => dst.Address, src => src.MapFrom(x => x.Address))
                .ForMember(dst => dst.ContactPerson, src => src.MapFrom(x => x.ContactPerson))
                .ForMember(dst => dst.Email, src => src.MapFrom(x => x.Email))
                .ForMember(dst => dst.WebSite, src => src.MapFrom(x => x.WebSite))
                .ForMember(dst => dst.Products, src => src.MapFrom(x => x.Products))
                .ForMember(dst => dst.Approved, src => src.MapFrom(x => x.Approved))
                .ForMember(dst => dst.Remarks, src => src.MapFrom(x => x.Remarks))
                .ForMember(dst => dst.SupplierClassId, src => src.MapFrom(x => x.SupplierClassId))
                .ForMember(dst => dst.Subject, src => src.MapFrom(x => x.Subject));
        }
    }
}