﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebDevelopment.Helper
{
	public class MainMenu : StaticMenu
	{
		public List<MainMenu> Items = new List<MainMenu>();

        #region Constructor


        public MainMenu(IUrlHelper url)
        {
            Items.AddRange(new []
            {
                new MainMenu(1, "Documents", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
                {
                    new MainMenu(1, "Registry", url.Action("Doc", "Home")),
                    new MainMenu(2, "Correspondence", "#!"),
                    new MainMenu(3, "Internal Documents", "#!")

                }),

                new MainMenu(2, "OPS", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
                {
                    new MainMenu(1, "Aircraft Status", "#!"),
                    new MainMenu(2, "Plan OPS", "#!"),
                    new MainMenu(3, "Flights Schedule", "#!"),
                    new MainMenu(4, "Flights UnSchedule", "#!")

                }),

                new MainMenu(3, "Personnel", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
                {
                    new MainMenu(1, "Personnel", "#!"),
                    new MainMenu(2, "Technical Training", "#!"),
                    new MainMenu(3, "Regularity Training", "#!"),
                    new MainMenu(4, "Testing", "#!")

                }),

                new MainMenu(4, "Reliability", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
                {
                    new MainMenu(1, "General", "#!"),
                    new MainMenu(2, "Occurrences and Interruptions", "#!"),
                    new MainMenu(3, "System reliability", "#!"),
                    new MainMenu(4, "Components reliability", "#!"),
                    new MainMenu(5, "Engines and APU", "#!"),
                    new MainMenu(6, "Defects", "#!"),
                    new MainMenu(7, "Deferred defects", "#!"),
                    new MainMenu(8, "Reliability report builder", "#!")

                }),

                new MainMenu(5, "Quality Assurance", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
                {
                    new MainMenu(1, "CR", "#!"),
                    new MainMenu(2, "Procedures and Processes", "#!"),
                    new MainMenu(3, "Quality Audits", "#!"),
                    new MainMenu(4, "Requirements", "#!"),
                    new MainMenu(5, "Training and Staff Qualification", "#!")

                }),
                
                new MainMenu(6, "SMS", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
                {


                }),

                new MainMenu(7, "MCC", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
                {


                }),

                new MainMenu(8, "PPCD", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
                {
                    new MainMenu(1, "Brief Report", "#!"),
                    new MainMenu(2, "Forecast", "#!"),
                    new MainMenu(3, "Technical Library", "#!"),
                    new MainMenu(4, "Technical Records", "#!"),
                    new MainMenu(5, "Work Packages", "#!")

                }),

                new MainMenu(9, "Cabin Interior", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
                {


                }),

                new MainMenu(10, "Cabin Interior", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
                {
                    new MainMenu(1, "Requests", "#!"),
                    new MainMenu(2, "Work Orders", "#!")

                }),

                new MainMenu(11, "Development", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
                {
                    new MainMenu(1, "Contract Maintenance Service", "#!"),
                    new MainMenu(2, "Ground Equipment", "#!"),
                    new MainMenu(3, "IT Service", "#!"),
                    new MainMenu(4, "Projects", "#!")

                }),

                new MainMenu(12, "Hangars", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
                {


                }),

                new MainMenu(13, "Line Maintenance", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
                {


                }),

                new MainMenu(14, "POOL, Warranty", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
                {
                    new MainMenu(1, "POOL", "#!"),
                    new MainMenu(2, "Warranty", "#!")

                }),

                new MainMenu(15, "Products", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
                {
                    new MainMenu(1, "Component Models", "#!"),
                    new MainMenu(2, "Equipment and Materials", "#!")

                }),

                new MainMenu(16, "Purchase", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
                {
                    new MainMenu(1, "Initial Orders", "#!"),
                    new MainMenu(2, "Purchase Orders", "#!"),
                    new MainMenu(3, "Quotation Orders", "#!"),
                    new MainMenu(4, "Suppliers", "#!"),
                    new MainMenu(5, "Processing", "#!"),

                }),

                new MainMenu(17, "Work Shops", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
                {


                })
        });
        }

        private MainMenu(int order, string header, string url)
		{
			Order = order;
			Header = header;
			Url = url;
		}

		private MainMenu(int order, string header, string url, string icon, IEnumerable<MainMenu> subMenu)
		{
			Order = order;
			Header = header;
			Url = url;
			SubMenu = subMenu;
            Icon = icon;

			//Items.Add(this);
		}

		#endregion

        
    }
}