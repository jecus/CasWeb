using AutoMapper;
using BusinessLayer.Views;
using Entity.Models;
using Entity.Models.General;

namespace BusinessLayer.Mapping
{
	public class BaseComponentProfile : Profile
	{
		public BaseComponentProfile()
		{
			CreateMap<BaseComponentView, Component>()
				.ForMember(dst => dst.ItemId, src => src.MapFrom(x => x.ItemId))
				.ForMember(dst => dst.IsDeleted, src => src.MapFrom(x => x.IsDeleted))
				.ForMember(dst => dst.StartDate, src => src.MapFrom(x => x.StartDate))
				.ForMember(dst => dst.IsBaseComponent, src => src.MapFrom(x => x.IsBaseComponent))
				.ForMember(dst => dst.ManufactureDate, src => src.MapFrom(x => x.ManufactureDate))
				.ForMember(dst => dst.Manufacturer, src => src.MapFrom(x => x.Manufacturer))
				.ForMember(dst => dst.PartNumber, src => src.MapFrom(x => x.PartNumber))
				.ForMember(dst => dst.SerialNumber, src => src.MapFrom(x => x.SerialNumber))
				.ForMember(dst => dst.BaseComponentTypeId, src => src.MapFrom(x => x.BaseComponentTypeId))
				.ForMember(dst => dst.TransferRecords, src => src.MapFrom(x => x.TransferRecords))
				.ForMember(dst => dst.Model, src => src.MapFrom(x => x.Model));
		}
	}
}