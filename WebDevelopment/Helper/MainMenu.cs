using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebDevelopment.Controllers;

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
                    new MainMenu(1, "Registry", url.Action("Index", "Document")),
                    new MainMenu(2, "Nomenclatures", url.Action("Index", "Nomenclature")),

                }),

                new MainMenu(10, "Personnel", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
                {
                    //new MainMenu(1, "Personnel", url.Action("Index", "Specialist")),
                    new MainMenu(2, "Occupation", url.Action("Index", "Specialization")),
                    new MainMenu(3, "Departments", url.Action("Index", "Department")),

                }),

                new MainMenu(30, "Products", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
                {
                    new MainMenu(1, "Component Models", url.Action("GetAllModels","Product")),
                    new MainMenu(2, "Equipment and Materials", url.Action("GetAllProducts", "Product")),
                    new MainMenu(3, "Products", url.Action("GetAll", "Product"))

                }),

                new MainMenu(40, "Purchase", "#!", "feather icon-clipboard", subMenu: new List<MainMenu>()
                {
                    new MainMenu(1, "Initial Orders", url.Action("Initial", "Order")),
                    new MainMenu(2, "Purchase Orders", url.Action("Purchase", "Order")),
					new MainMenu(3, "Quotation Orders", url.Action("Quotation", "Order")),
					new MainMenu(4, "Suppliers", "#!"),
                    new MainMenu(5, "Processing", "#!"),

                }),
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