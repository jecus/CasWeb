﻿using BusinessLayer.Providers;
using Entity.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace WebDevelopment
{
	public class Startup
	{
		public IConfiguration Configuration { get; }

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public void  ConfigureServices(IServiceCollection services)
		{
			services.AddLogging(builder => builder.AddSeq());

			services.Configure<CookiePolicyOptions>(options =>
			{
				options.CheckConsentNeeded = context => true;
				options.MinimumSameSitePolicy = SameSiteMode.None;
			});

			services.AddMvc()
				.AddJsonOptions(options =>
				{
					options.SerializerSettings.ContractResolver = new DefaultContractResolver();
					options.AllowInputFormatterExceptionMessages = true;
					options.SerializerSettings.DateFormatHandling = DateFormatHandling.IsoDateFormat;
					options.SerializerSettings.Converters.Add(new StringEnumConverter());
					options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
					options.SerializerSettings.ObjectCreationHandling = ObjectCreationHandling.Reuse;
					options.UseMemberCasing();
				})
				.SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

			services.AddDbContext<DatabaseContext>(builder => builder.UseSqlServer(Configuration.GetConnectionString("CORE_CONNECTION_STRING")));
			services.AddProviders();
			services.AddRepositories();
			services.AddKendo();

			services.AddHttpClient<ICalculationHttpClient, CalculationHttpClient>();
		}


		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			Setup(app, env);
			app.UseKendo(env);
		}

		protected void Setup(IApplicationBuilder app, IHostingEnvironment env)
		{
			RouteConfig.RegisterRoutes(app, env);
		}
	}
}
