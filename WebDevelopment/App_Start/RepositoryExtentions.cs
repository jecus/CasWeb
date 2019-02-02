using System;
using System.Linq;
using System.Reflection;
using AutoMapper;
using BusinessLayer.Mapping;
using BusinessLayer.Repositiry;
using BusinessLayer.Repositiry.Interfaces;
using Microsoft.Extensions.DependencyInjection;

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
			});

			var mapper = mappingConfig.CreateMapper();
			services.AddSingleton(mapper);
			return services;
		}

		public static IServiceCollection AddRepositories(this IServiceCollection services)
		{
			services.AddScoped<IUserRepository, UserRepository>();
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