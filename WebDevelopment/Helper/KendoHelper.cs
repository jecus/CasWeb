using System.Collections.Generic;
using System.Text;

namespace WebDevelopment.Helper
{
	public enum ButtonType
	{
		Open, Edit, Delete
	}

	public  static class KendoHelper
	{
		public static string PdfButton(string url, params string[] properties)
		{
			var sb = new StringBuilder();
			foreach (var property in properties)
			{
				sb.AppendLine("<a class=" +
				              "#if (" + property + " > 0) {# 'btn waves-effect waves-dark btn-danger btn-outline-danger btn-icon' #}" +
				              "else {# 'btn waves-effect waves-dark btn-disabled btn-outline-danger btn-icon disabled' #}#" +
				              " href=" + url + $@"?fileId=#={property}#" + @"><i class=""fa fa-file-pdf-o""></i></a>");
			}

			return sb.ToString();
		}

		public static string PdfButton(string url, Dictionary<string, string> properties)
		{
			var sb = new StringBuilder();
			foreach (var property in properties)
			{
				sb.AppendLine("<a class=" +
				             "#if (" + property.Key + " > 0) {# 'btn waves-effect waves-dark btn-danger btn-outline-danger btn-icon' #}" +
				             "else {# 'btn waves-effect waves-dark btn-disabled btn-outline-danger btn-icon disabled' #}#" +
				             " href=" + url + $@"?fileId=#={property.Key}#" + @"><i class=""fa fa-file-pdf-o""></i></a>");
			}

			return sb.ToString();
		}


		public static string Button(string url, string paramName, string property, ButtonType type)
		{
			var typeClass = "";
			var icon = "";
			switch (type)
			{
				case ButtonType.Open:
					typeClass = "btn-success btn-outline-success";
					icon = "fa fa-folder-open-o";
					break;
				case ButtonType.Edit:
					typeClass = "btn-primary btn-outline-primary";
					icon = "fa fa-pencil";
					break;
				default:
					typeClass = "btn-danger btn-outline-danger";
					icon = "fa fa-times";
					break;
			}

			return "<a class= 'btn waves-effect waves-dark " + typeClass + " btn-icon'" +
			       " href=" + url + $@"?{paramName}=#={property}#" + @"><i class=""" + icon + @"""></i></a>";
		}

		public static string ButtonModal(string url, string paramName, string property, ButtonType type, string windowName)
		{
			var typeClass = "";
			var icon = "";
			switch (type)
			{
				case ButtonType.Open:
					typeClass = "btn-success btn-outline-success";
					icon = "fa fa-folder-open-o";
					break;
				case ButtonType.Edit:
					typeClass = "btn-primary btn-outline-primary";
					icon = "fa fa-pencil";
					break;
				default:
					typeClass = "btn-danger btn-outline-danger";
					icon = "fa fa-times";
					break;
			}

			var res = "<button class= 'btn waves-effect waves-dark " + typeClass + " btn-icon'" +
				   @" onclick=""OpenModal('" + url + $@"?{paramName}=#={property}#', '{windowName}')""" + @"><i class=""" + icon + @"""></i></button>";

			return res;
		}
	}
}