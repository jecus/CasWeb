using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity.Extentions
{
	public static class DbExtentions
	{
		public static IQueryable<T> OnlyActive<T>(this IQueryable<T> queryable) where  T : class,IBaseEntity
		{
			return queryable.Where(i => !i.IsDeleted);
		}
	}
}
