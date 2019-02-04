using System.Collections.Generic;

namespace WebDevelopment.Helper
{
	public abstract class StaticMenu
	{
		public int Order { get; set; }
		public string Header { get; set; }
		public string Url { get; set; }
		public string Icon { get; set; }
		public IEnumerable<StaticMenu> SubMenu { get; set; }
	}
}