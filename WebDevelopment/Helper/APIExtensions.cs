using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WebDevelopment.Helper
{
	public static class APIExtensions
	{
		//private readonly IHttpClientFactory _httpClientFactory;
		//var client = _httpClientFactory.CreateClient(serviceName);
		//client.BaseAddress = baseAddress;
		//client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _authtoken);
		//return client;

		public static async Task<ApiResult<TResult>> GetJsonAsync<TResult>(this HttpClient client, string requestUri)
		{
			var res = await client.GetAsync(requestUri);
			var content = await res.Content.ReadAsStringAsync();

			return new ApiResult<TResult>
			{
				IsSuccessful = res.IsSuccessStatusCode,
				StatusCode = res.StatusCode,
				Data = res.IsSuccessStatusCode ? JsonConvert.DeserializeObject<TResult>(content) : default(TResult),
				Error = res.IsSuccessStatusCode ? null : (content ?? res.ReasonPhrase)
			};
		}

		public static async Task<ApiResult<TResult>> SendJsonAsync<TModel, TResult>(this HttpClient client, HttpMethod httpMethod, string requestUri, TModel model)
		{
			var json = JsonConvert.SerializeObject(model);
			var res = await client.SendAsync(new HttpRequestMessage(httpMethod, requestUri)
			{
				Content = new StringContent(json, Encoding.UTF8, MediaTypeNames.Application.Json)
			});
			var content = await res.Content.ReadAsStringAsync();

			return new ApiResult<TResult>
			{
				IsSuccessful = res.IsSuccessStatusCode,
				StatusCode = res.StatusCode,
				Data = res.IsSuccessStatusCode
					? (string.IsNullOrWhiteSpace(content) ? default(TResult) : JsonConvert.DeserializeObject<TResult>(content))
					: default(TResult),
				Error = res.IsSuccessStatusCode ? null : (content ?? res.ReasonPhrase)
			};
		}
	}



	public class ApiResult<TView>
	{
		public TView Data { get; set; }
		public bool IsSuccessful { get; set; }
		public HttpStatusCode StatusCode { get; set; }
		public string Error { get; set; }
	}
}