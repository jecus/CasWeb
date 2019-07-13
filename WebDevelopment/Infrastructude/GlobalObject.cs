using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Views;
using WebDevelopment.Helper;

namespace WebDevelopment.Infrastructude
{
	public static class GlobalObject
	{
		

        public static int AtlbId { get; set; }

        public static AircraftMainMenu AircraftMainMenu { get; set; }

        public static List<int> BaseComponentIds => new List<int>(BaseComponent.Select(i => i.Id));
		public static List<BaseComponentView> BaseComponent { get; set; }

		
		public static AircraftView Aircraft { get; set; }
		public static int AircraftId => Aircraft.Id;
		public static string RegistrationNumber => Aircraft.RegistrationNumber;
	}
}