﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using Serilog.Formatting.Compact;

namespace WebDevelopment
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateWebHostBuilder(args).Build().Run();
		}

		public static IWebHostBuilder CreateWebHostBuilder(string[] args)
		{
			var config = new ConfigurationBuilder()
				.AddJsonFile("AppSettings.json")
				.Build();

			return WebHost.CreateDefaultBuilder(args)
				.ConfigureLogging(builder => builder.ClearProviders())
				.UseSerilog((context, configuration) =>
				{
					configuration
						.MinimumLevel.Is(config.GetValue("Logging:Level", LogEventLevel.Debug))
						.WriteTo.Console()
						.WriteTo.RollingFile(pathFormat: Path.Combine(config["Logging:RootPath"], "app.log"),
							formatter: new CompactJsonFormatter());
				})
				.UseStartup<Startup>()
				.UseConfiguration(config);

		}	
	}
}
