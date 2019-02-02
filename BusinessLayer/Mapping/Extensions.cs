using System.Collections.Generic;
using AutoMapper;
using BusinessLayer.Views;
using Entity;

namespace BusinessLayer.Mapping
{
	public static class Extensions
	{
        /// <summary>
        /// Получение <see cref="IBaseView"/> модели
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TView"></typeparam>
        /// <param name="mapper"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public static TView MapToBlView<TEntity, TView>(this IMapper mapper, TEntity source)
			where TEntity : class, IBaseEntity
			where TView : class, IBaseView
			=> mapper.Map<TEntity, TView>(source);


        /// <inheritdoc cref="MapToBlView{TEntity, TView}(IMapper, TEntity)"/>
        public static IEnumerable<TView> MapToBlView<TEntity, TView>(this IMapper mapper, IEnumerable<TEntity> source)
			where TEntity : class, IBaseEntity
			where TView : class, IBaseView
			=> mapper.Map<IEnumerable<TEntity>, IEnumerable<TView>>(source);

        /// <summary>
        /// Получение  модели из <see cref="IBaseView"/> 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TView"></typeparam>
        /// <param name="mapper"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public static TEntity MapToEntity<TView, TEntity>(this IMapper mapper, TView source)
			where TView : class, IBaseView
			where TEntity : class, IBaseEntity
			=> mapper.Map<TView, TEntity>(source);

        /// <inheritdoc cref="MapToEntity{TView, TEntity}(IMapper, TView)"/>
        public static IEnumerable<TEntity> MapToEntity<TView, TEntity>(this IMapper mapper, IEnumerable<TView> source)
			where TView : class, IBaseView
			where TEntity : class, IBaseEntity
			=> mapper.Map<IEnumerable<TView>, IEnumerable<TEntity>>(source);
	}
}