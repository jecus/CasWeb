using System.Collections.Generic;
using System.Collections.ObjectModel;
using AutoMapper;
using BusinessLayer.Views;
using Entity;

namespace BusinessLayer.Mapping
{
	public class CommonProfile : Profile
	{
		public CommonProfile()
		{
			CreateMap<IBaseEntity, IBaseView>();

			CreateMap<Dictionary<string, string>, IReadOnlyDictionary<string, string>>()
				.ConstructUsing(dictionary => new ReadOnlyDictionary<string, string>(dictionary));
		}
	}
}