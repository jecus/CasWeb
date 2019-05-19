using System.Collections.Generic;
using Entity.Models.General;

namespace Entity.Models.Dictionaries
{
	public class AircraftModel : AccessoryDescription
	{
		public ICollection<Aircraft> Aircrafts { get; set; }
	}
}