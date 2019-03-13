﻿using System;
using System.Linq;
using System.Reflection;
using BusinessLayer.Repositiry;
using BusinessLayer.Repositiry.Interfaces;
using BusinessLayer.Views;
using Microsoft.Extensions.DependencyInjection;
using WebDevelopment.Infrastructude;
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
			return services;
		}
	}
}