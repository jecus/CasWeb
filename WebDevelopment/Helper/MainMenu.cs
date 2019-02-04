using System.Collections.Generic;

namespace WebDevelopment.Helper
{
	public class MainMenu : StaticMenu
	{
		public static List<MainMenu> Items = new List<MainMenu>();

		#region Constructor

		public MainMenu(int order, string header, string url)
		{
			Order = order;
			Header = header;
			Url = url;
		}

		public MainMenu(int order, string header, string url, string icon, IEnumerable<MainMenu> subMenu)
		{
			Order = order;
			Header = header;
			Url = url;
			SubMenu = subMenu;
            Icon = icon;

			Items.Add(this);
		}

		#endregion

		private static MainMenu Documents = new MainMenu(1, "Documents", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
		{
			new MainMenu(1, "Registry", "#!"),
			new MainMenu(2, "Correspondence", "#!"),
			new MainMenu(3, "Internal Documents", "#!")

		});

        private static MainMenu OPS = new MainMenu(2, "OPS", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
        {
            new MainMenu(1, "Aircraft Status", "#!"),
            new MainMenu(2, "Plan OPS", "#!"),
            new MainMenu(3, "Flights Schedule", "#!"),
            new MainMenu(4, "Flights UnSchedule", "#!")

        });

        private static MainMenu Personnel = new MainMenu(3, "Personnel", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
        {
            new MainMenu(1, "Personnel", "#!"),
            new MainMenu(2, "Technical Training", "#!"),
            new MainMenu(3, "Regularity Training", "#!"),
            new MainMenu(4, "Testing", "#!")

        });

        private static MainMenu Reliability = new MainMenu(4, "Reliability", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
        {
            new MainMenu(1, "General", "#!"),
            new MainMenu(2, "Occurrences and Interruptions", "#!"),
            new MainMenu(3, "System reliability", "#!"),
            new MainMenu(4, "Components reliability", "#!"),
            new MainMenu(5, "Engines and APU", "#!"),
            new MainMenu(6, "Defects", "#!"),
            new MainMenu(7, "Deferred defects", "#!"),
            new MainMenu(8, "Reliability report builder", "#!")

        });

        private static MainMenu QualityAssu = new MainMenu(5, "Quality Assurance", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
        {
            new MainMenu(1, "CR", "#!"),
            new MainMenu(2, "Procedures and Processes", "#!"),
            new MainMenu(3, "Quality Audits", "#!"),
            new MainMenu(4, "Requirements", "#!"),
            new MainMenu(5, "Training and Staff Qualification", "#!")

        });

        private static MainMenu SMS = new MainMenu(6, "SMS", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
        {
          

        });

        private static MainMenu MCC = new MainMenu(7, "MCC", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
        {


        });

        private static MainMenu PPCD = new MainMenu(8, "PPCD", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
        {
            new MainMenu(1, "Brief Report", "#!"),
            new MainMenu(2, "Forecast", "#!"),
            new MainMenu(3, "Technical Library", "#!"),
            new MainMenu(4, "Technical Records", "#!"),
            new MainMenu(5, "Work Packages", "#!")

        });

        private static MainMenu CabInterior = new MainMenu(9, "Cabin Interior", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
        {


        });

        private static MainMenu Comercial = new MainMenu(10, "Cabin Interior", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
        {
            new MainMenu(1, "Requests", "#!"),
            new MainMenu(2, "Work Orders", "#!")
        
        });

        private static MainMenu Development = new MainMenu(11, "Development", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
        {
            new MainMenu(1, "Contract Maintenance Service", "#!"),
            new MainMenu(2, "Ground Equipment", "#!"),
            new MainMenu(3, "IT Service", "#!"),
            new MainMenu(4, "Projects", "#!")

        });

        private static MainMenu Hangars = new MainMenu(12, "Hangars", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
        {


        });

        private static MainMenu LineMaintenance = new MainMenu(13, "Line Maintenance", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
        {


        });

        private static MainMenu POOLWar = new MainMenu(14, "POOL, Warranty", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
        {
            new MainMenu(1, "POOL", "#!"),
            new MainMenu(2, "Warranty", "#!")

        });

        private static MainMenu Products = new MainMenu(15, "Products", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
        {
            new MainMenu(1, "Component Models", "#!"),
            new MainMenu(2, "Equipment and Materials", "#!")

        });

        private static MainMenu Purchase = new MainMenu(16, "Purchase", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
        {
            new MainMenu(1, "Initial Orders", "#!"),
            new MainMenu(2, "Purchase Orders", "#!"),
            new MainMenu(3, "Quotation Orders", "#!"),
            new MainMenu(4, "Suppliers", "#!"),
            new MainMenu(5, "Processing", "#!"),

        });

        private static MainMenu WorkShops = new MainMenu(17, "Work Shops", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
        {
            

        });

    }
}