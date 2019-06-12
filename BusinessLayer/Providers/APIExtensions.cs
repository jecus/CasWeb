using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BusinessLayer.Providers
{
	public static class APIExtensions
	{
		public static async Task<ApiResult<TResult>> GetJsonAsync<TResult>(this HttpClient client, string requestUri)
		{
			var res = await client.GetAsync(requestUri);
			var content = await res.Content.ReadAsStringAsync();

			return new ApiResult<TResult>
			{
				IsSuccessful = res.IsSuccessStatusCode,
				StatusCode = res.StatusCode,
				Data = res.IsSuccessStatusCode && content != "[]" ? JsonConvert.DeserializeObject<TResult>(content) : default(TResult),
				Error = res.IsSuccessStatusCode ? null : (content ?? res.ReasonPhrase)
			};
		}

		public static async Task<ApiResult<TResult>> PostJsonAsync<TResult>(this HttpClient client, string requestUri)
		{
			var res = await client.PostAsync(requestUri, null);
			var content = await res.Content.ReadAsStringAsync();

			return new ApiResult<TResult>
			{
				IsSuccessful = res.IsSuccessStatusCode,
				StatusCode = res.StatusCode,
				Data = res.IsSuccessStatusCode && content != "[]" ? JsonConvert.DeserializeObject<TResult>(content) : default(TResult),
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
				Data = res.IsSuccessStatusCode && content != "[]"
					? (string.IsNullOrWhiteSpace(content) ? default(TResult) : JsonConvert.DeserializeObject<TResult>(content))
					: default(TResult),
				Error = res.IsSuccessStatusCode ? null : (content ?? res.ReasonPhrase)
			};
		}

	}
}