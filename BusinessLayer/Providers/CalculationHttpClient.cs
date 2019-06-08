using System;
using System.Collections.Specialized;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace BusinessLayer.Providers
{
	public class CalculationHttpClient : ICalculationHttpClient
	{
		private readonly ILogger<CalculationHttpClient> _logger;
		private readonly HttpClient _httpClient;

		public CalculationHttpClient(ILogger<CalculationHttpClient> logger, HttpClient httpClient,
			IConfiguration config)
		{
			_logger = logger;
			var clientConfig = config.GetSection("Services").GetSection("Calculation");

			var endpoint = clientConfig.GetValue<string>("Endpoint");
			httpClient.BaseAddress = new Uri(endpoint);

			_httpClient = httpClient;
		}

	}
}