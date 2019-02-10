using AutoMapper;
using BusinessLayer.Views;
using Entity.Models;

namespace BusinessLayer.Mapping
{
	public class ModelProfile : Profile
	{
		public ModelProfile()
		{
			CreateMap<ModelView, AccessoryDescription>()
				.ForMember(dst => dst.ItemId, src => src.MapFrom(x => x.ItemId))
				.ForMember(dst => dst.IsDeleted, src => src.MapFrom(x => x.IsDeleted))
				.ForMember(dst => dst.ShortName, src => src.MapFrom(x => x.ShortName))
				.ForMember(dst => dst.FullName, src => src.MapFrom(x => x.FullName));
		}
	}
}