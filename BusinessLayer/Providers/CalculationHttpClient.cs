using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using BusinessLayer.Views;
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

		public async Task<List<NextPerformance>> NextPerformanceForComponent(int componentId)
		{
			var param = HttpUtility.ParseQueryString(string.Empty); 
			param.Add(new NameValueCollection()
			{
				["componentId"] = componentId.ToString()
			});
			var res = await _httpClient.PostJsonAsync<List<NextPerformance>>($"api/PerformanceCalculatorRepository/NextPerformanceForComponent?{param}");
			return res?.Data ?? new List<NextPerformance>();
		}
		public async Task<Dictionary<int, List<NextPerformance>>> NextPerformanceForComponents(List<int> componentIds)
		{
			var res = await _httpClient.SendJsonAsync<List<int>, Dictionary<int, List<NextPerformance>>>(HttpMethod.Post, $"api/PerformanceCalculatorRepository/NextPerformanceForComponents", componentIds);
			return res?.Data ?? new Dictionary<int, List<NextPerformance>>();
		}

		public async Task<List<NextPerformance>> NextPerformanceForComponentDirective(int componentDirectiveId)
		{
			var param = HttpUtility.ParseQueryString(string.Empty);
			param.Add(new NameValueCollection()
			{
				["componentDirectiveId"] = componentDirectiveId.ToString()
			});
			var res = await _httpClient.PostJsonAsync<List<NextPerformance>>($"api/PerformanceCalculatorRepository/NextPerformanceForComponentDirective?{param}");
			return res?.Data ?? new List<NextPerformance>();
		}

		public async Task<Dictionary<int, List<NextPerformance>>> NextPerformanceForComponentDirectives(List<int> componentDirectiveIds)
		{
			var res = await _httpClient.SendJsonAsync<List<int>, Dictionary<int, List<NextPerformance>>>(HttpMethod.Post, $"api/PerformanceCalculatorRepository/NextPerformanceForComponentDirectives", componentDirectiveIds);
			return res?.Data ?? new Dictionary<int, List<NextPerformance>>();
		}
	}
}