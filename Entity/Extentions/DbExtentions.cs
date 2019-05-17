using System.Linq;

namespace Entity.Extentions
{
	public static class DbExtentions
	{
		public static IQueryable<T> OnlyActive<T>(this IQueryable<T> queryable) where  T : class,IBaseEntity
		{
			return queryable.Where(i => !i.IsDeleted);
		}

        public static string ToYesNo(this bool flag)
        {
            return flag ? "Yes" : "No";
        }
	}
}
