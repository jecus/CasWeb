using BusinessLayer.Repositiry;
using BusinessLayer.Repositiry.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using WebDevelopment.Infrastructude.JWT;

namespace WebDevelopment
{
	public static class RepositoryExtentions
	{
		public static IServiceCollection AddProviders(this IServiceCollection services)
		{
			services.AddSingleton<IJwtProvider, JwtProvider>();
			
			return services;
		}

		public static IServiceCollection AddRepositories(this IServiceCollection services)
		{
			services.AddScoped<IUserRepository, UserRepository>();
			services.AddScoped<IAircraftRepository, AircraftRepository>();
			services.AddScoped<IComponentRepository, ComponentRepository>();
			services.AddScoped<IStockCalculator, StockCalculator>();
			services.AddScoped<IProductRepository, ProductRepository>();
			services.AddScoped<IAtlbRepository, AtlbRepository>();
			services.AddScoped<IMaintenanceDirectiveRepository, MaintenanceDirectiveRepository>();
			services.AddScoped<IDirectiveRepository, DirectiveRepository>();
			return services;
		}
	}
}