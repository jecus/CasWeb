using System;
using System.Collections.Generic;
using System.Linq;
using Entity;
using Kendo.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace WebDevelopment.Helper
{
	public static class ListResult
	{
		private const int LIST_LIMIT = 400;

		public static DataSourceResult ToListResult<TEntity, TResult>(this IQueryable<TEntity> query, DataSourceRequest request, Func<TEntity, TResult> selector)
			where TEntity : class
		{
			_ApplyDefaultPageSize(request);
			_ApplyDefaultSorting(request);
			_CleanUpClientAggregates(request);

			return query.ToDataSourceResult(request, selector);
		}

		private static void _ApplyDefaultPageSize(DataSourceRequest request)
		{
			if (request == null)
			{
				throw new NullReferenceException();
			}

			if (request.PageSize > LIST_LIMIT)
			{
				request.PageSize = LIST_LIMIT;
			}

			if (request.PageSize <= 0)
			{
				request.PageSize = 250;
			}
		}

		private static void _ApplyDefaultSorting(DataSourceRequest request)
		{
			if (request == null)
			{
				throw new NullReferenceException();
			}

			if (request.Sorts == null || !request.Sorts.Any())
			{
				request.Sorts = new List<SortDescriptor>
				{
					new GroupDescriptor
					{
						Member = nameof(BaseEntity.Id),
						SortDirection = Kendo.Mvc.ListSortDirection.Descending
					}
				};
			}
		}

		private static void _CleanUpClientAggregates(DataSourceRequest request)
		{
			if (request == null)
			{
				return;
			}

			request.Groups = null;
			request.Aggregates = null;
		}
	}
}