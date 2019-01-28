//using System;
//using System.Linq;
//using System.Reflection;
//using System.Web.Mvc;
//using Autofac;
//using Autofac.Extensions.DependencyInjection;
//using Autofac.Integration.Mvc;
//using AutoMapper;
//using BusinessLayer.Repositiry;
//using BusinessLayer.Repositiry.Interfaces;
//using Entity.Infrastructure;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;

//namespace WebDevelopment
//{
//	public static class DependencyInjectionConfig
//	{
//		private static Assembly[] _automapperAssemblies;

//		internal static IContainer Register(IServiceCollection services, params Assembly[] automapperAssemblies)
//		{
//			_automapperAssemblies = automapperAssemblies;

//			var container = CreateContainer(services);
//			DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
//			return container;
//		}

//		private static IContainer CreateContainer(IServiceCollection services)
//		{
//			var container = new ContainerBuilder();

//			RegisterBindings(container, services);

//			return container.Build();
//		}

//		private static void RegisterBindings(ContainerBuilder containerBuilder, IServiceCollection services)
//		{
//			containerBuilder.Populate(services);

//			// Register global constants 
//			containerBuilder.RegisterInstance(Startup.AppConfiguration).As<IConfiguration>();

//			containerBuilder.RegisterType<DatabaseContext>().AsSelf();

//			// Repositories
//			containerBuilder.RegisterType<UserRepository>().As<IUserRepository>().SingleInstance();

//			RegisterAutoMapper(containerBuilder);
//		}

//		private static void RegisterAutoMapper(ContainerBuilder containerBuilder)
//		{
//			var openTypes = new[]
//			{
//				typeof(IValueResolver<,,>),
//				typeof(IMemberValueResolver<,,,>),
//				typeof(ITypeConverter<,>),
//				typeof(IMappingAction<,>)
//			};

//			var assemblyTypes = _automapperAssemblies
//				.Where(a => a.GetName().Name != nameof(AutoMapper))
//				.SelectMany(a => a.DefinedTypes)
//				.ToArray();

//			var additionalTypes = openTypes.SelectMany(t =>
//				assemblyTypes.Where(at =>
//					at.IsClass
//					&& !at.IsAbstract
//					&& at.AsType().ImplementsGenericInterface(t)
//				).Select(a => a.AsType())
//			);

//			// Register injected AutoMapepr types
//			containerBuilder.RegisterTypes(additionalTypes.ToArray())
//				.AsSelf().InstancePerDependency();
//			// Register AutoMapepr configuration
//			containerBuilder.Register(_ => new MapperConfiguration(config =>
//			{
//				config.AddProfiles(_automapperAssemblies);
//				config.AllowNullDestinationValues = false;
//				// откуда AutoMapper берет модели для инъекций в свои модули
//				config.ConstructServicesUsing(DependencyResolver.Current.GetService);
//			}))
//				.As<AutoMapper.IConfigurationProvider>()
//				.SingleInstance();
//			// Register ioc
//			containerBuilder.Register(context => new Mapper(context.Resolve<AutoMapper.IConfigurationProvider>()))
//				.As<IMapper>()
//				.InstancePerLifetimeScope();
//		}

//		private static bool ImplementsGenericInterface(this Type type, Type interfaceType)
//		{
//			return type.IsGenericType(interfaceType) || type.GetTypeInfo().ImplementedInterfaces.Any(@interface => @interface.IsGenericType(interfaceType));
//		}

//		private static bool IsGenericType(this Type type, Type genericType)
//		{
//			return type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == genericType;
//		}

//	}
//}