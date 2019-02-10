using System;
using System.Linq;
using System.Reflection;
using AutoMapper;
using BusinessLayer.Mapping;
using BusinessLayer.Repositiry;
using BusinessLayer.Repositiry.Interfaces;
using BusinessLayer.Views;
using Microsoft.Extensions.DependencyInjection;
using WebDevelopment.Infrastructude;

namespace WebDevelopment
{
	public static class RepositoryExtentions
	{
		public static IServiceCollection AddMapping(this IServiceCollection services, params Assembly[] automapperAssemblies)
		{
			var mappingConfig = new MapperConfiguration(mc =>
			{
				mc.AddProfile(new UserProfile());
				mc.AddProfile(new AircraftProfile());
				mc.AddProfile(new ModelProfile());
				mc.AddProfile(new StoreProfile());
				mc.AddProfile(new OperatorProfile());
				mc.AddProfile(new DocumentProfile());
			});

			var mapper = mappingConfig.CreateMapper();
			services.AddSingleton(mapper);
			return services;
		}

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
			return services;
		}

		private static bool ImplementsGenericInterface(this Type type, Type interfaceType)
		{
			return type.IsGenericType(interfaceType) || type.GetTypeInfo().ImplementedInterfaces.Any(@interface => @interface.IsGenericType(interfaceType));
		}

		private static bool IsGenericType(this Type type, Type genericType)
		{
			return type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == genericType;
		}
	}
}