using System.Collections.Generic;
using Entity.Models.General;

namespace Entity.Models.Dictionaries
{
	public class Product : AccessoryDescription
	{
		public ICollection<Component> Components { get; set; }
	}
}