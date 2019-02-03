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

		public MainMenu(int order, string header, string url, IEnumerable<MainMenu> subMenu)
		{
			Order = order;
			Header = header;
			Url = url;
			SubMenu = subMenu;

			Items.Add(this);
		}

		#endregion

		private static MainMenu Documents = new MainMenu(1, "Documents", "#!", subMenu: new List<MainMenu>()
		{
			new MainMenu(1, "Registry", "#!"),
			new MainMenu(2, "Correspondence", "#!"),
			new MainMenu(2, "Internal Documents", "#!")

		});

	}
}