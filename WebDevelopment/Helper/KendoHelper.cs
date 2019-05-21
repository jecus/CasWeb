using System.Security.Policy;

namespace WebDevelopment.Helper
{
	public  static class KendoHelper
	{
		public static string PdfButton(string url)
		{
			return "<a class=" +
			       "#if (FileId > 0) {# 'btn waves-effect waves-dark btn-danger btn-outline-danger btn-icon' #}" +
			       "else {# 'btn waves-effect waves-dark btn-disabled btn-outline-danger btn-icon disabled' #}#" +
			       "' href='" + url +
			       @"'><i class=""fa fa-file-pdf-o""></i></a>";
		}
	}
}