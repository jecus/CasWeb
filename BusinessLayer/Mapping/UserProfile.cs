using AutoMapper;
using BusinessLayer.Views;
using Entity.Models;
using Entity.Models.General;

namespace BusinessLayer.Mapping
{
	public class UserProfile : Profile
	{
		public UserProfile()
		{
			CreateMap<UserView, User>()
				.ForMember(dst => dst.ItemId, src => src.MapFrom(x => x.ItemId))
				.ForMember(dst => dst.IsDeleted, src => src.MapFrom(x => x.IsDeleted))
				.ForMember(dst => dst.Login, src => src.MapFrom(x => x.Login))
				.ForMember(dst => dst.Name, src => src.MapFrom(x => x.Name))
				.ForMember(dst => dst.Password, src => src.MapFrom(x => x.Password))
				.ForMember(dst => dst.Surname, src => src.MapFrom(x => x.Surname));
		}
	}
}