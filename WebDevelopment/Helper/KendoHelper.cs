using System.Security.Policy;
using System.Text;
using Microsoft.AspNetCore.Mvc.ModelBinding.Internal;

namespace WebDevelopment.Helper
{
	public  static class KendoHelper
	{
		public static string PdfButton(string url, params string[] properties)
		{
			var sb = new StringBuilder();
			foreach (var property in properties)
			{
				sb.Append("<a class=" +
				          "#if ("+ property +" > 0) {# 'btn waves-effect waves-dark btn-danger btn-outline-danger btn-icon' #}" +
				          "else {# 'btn waves-effect waves-dark btn-disabled btn-outline-danger btn-icon disabled' #}#" +
				          " href=" + url + $@"?fileId=#={property}#" + @"><i class=""fa fa-file-pdf-o""></i></a>");
			}

			return sb.ToString();
		}
	}
}