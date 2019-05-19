using System.Collections.Generic;
using Entity.Models.General;

namespace Entity.Models.Dictionaries
{
	public class ComponentModel : AccessoryDescription
	{
		public ICollection<Component> Components { get; set; }
	}
}