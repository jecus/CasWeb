using System.Collections.Generic;
using BusinessLayer.Views;
using WebDevelopment.Helper;

namespace WebDevelopment.Infrastructude
{
	public static class GlobalObject
	{
		public static int AircraftId { get; set; }

        public static int AtlbId { get; set; }

        public static AircraftMainMenu AircraftMainMenu { get; set; }

		public static List<int> BaseComponentIds { get; set; }

		public static string RegistrationNumber { get; set; }
        
    }
}