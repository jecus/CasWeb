using System.Net;

namespace BusinessLayer.Providers
{
	public class ApiResult<TView>
	{
		public TView Data { get; set; }
		public bool IsSuccessful { get; set; }
		public HttpStatusCode StatusCode { get; set; }
		public string Error { get; set; }
	}
}