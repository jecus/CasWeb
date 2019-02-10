using AutoMapper;
using BusinessLayer.Views;
using Entity.Models;

namespace BusinessLayer.Mapping
{
	public class TransferRecordProfile : Profile
	{
		public TransferRecordProfile()
		{
			CreateMap<TransferRecordView, TransferRecord>()
				.ForMember(dst => dst.ItemId, src => src.MapFrom(x => x.ItemId))
				.ForMember(dst => dst.IsDeleted, src => src.MapFrom(x => x.IsDeleted))
				.ForMember(dst => dst.DestinationObjectID, src => src.MapFrom(x => x.DestinationObjectID))
				.ForMember(dst => dst.DestinationObjectType, src => src.MapFrom(x => x.DestinationObjectType))
				.ForMember(dst => dst.FromAircraftID, src => src.MapFrom(x => x.FromAircraftID))
				.ForMember(dst => dst.FromStoreID, src => src.MapFrom(x => x.FromStoreID))
				.ForMember(dst => dst.ParentID, src => src.MapFrom(x => x.ParentID))
				.ForMember(dst => dst.ParentType, src => src.MapFrom(x => x.ParentType))
				.ForMember(dst => dst.Position, src => src.MapFrom(x => x.Position))
				.ForMember(dst => dst.TransferDate, src => src.MapFrom(x => x.TransferDate))
				.ForMember(dst => dst.Component, src => src.MapFrom(x => x.Component));
		}
	}
}