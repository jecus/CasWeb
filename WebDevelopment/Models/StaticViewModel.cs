using System.Collections.Generic;
using BusinessLayer.Views;
using Entity.Models.General;
using WebDevelopment.Helper;

namespace WebDevelopment.Models
{
	public static class LayoutViewModel
	{
		public static List<AircraftView> AircraftViews { get; set; }
		public static List<StoreView> StoreViews { get; set; }
		public static Operator Operator { get; set; }
		public static List<MainMenu> MainMenu { get; set; }
	}
}