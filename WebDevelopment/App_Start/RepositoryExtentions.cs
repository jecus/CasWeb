using System;
using System.Linq;
using System.Reflection;
using BusinessLayer.Repositiry;
using BusinessLayer.Repositiry.Interfaces;
using BusinessLayer.Views;
using Microsoft.Extensions.DependencyInjection;
using WebDevelopment.Infrastructude;

namespace WebDevelopment
{
	public static class RepositoryExtentions
	{
		public static IServiceCollection AddProviderModule(this IServiceCollection services)
		{
			services.AddSingleton<AuthenticationProvider>();
			services.AddTransient(provider => (Identity)provider.GetService<AuthenticationProvider>().GetIdentity());
			return services;
		}

		public static IServiceCollection AddRepositories(this IServiceCollection services)
		{
			services.AddScoped<IUserRepository, UserRepository>();
			services.AddScoped<IAircraftRepository, AircraftRepository>();
			services.AddScoped<IComponentRepository, ComponentRepository>();
			return services;
		}
	}
}