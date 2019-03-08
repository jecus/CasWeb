using Microsoft.AspNetCore.Mvc;

namespace WebDevelopment.Infrastructude
{
	public class AircraftRouteAttribute : RouteAttribute
	{
		private static string _ConstructPrefix(string prefix)
		{
			return "aircraft/{aircraftId}/" + prefix;
		}

		public AircraftRouteAttribute(string template) : base(_ConstructPrefix(template))
		{
		}
	}
}