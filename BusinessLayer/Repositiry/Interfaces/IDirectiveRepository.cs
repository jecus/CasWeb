using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLayer.Dictionaties;
using BusinessLayer.Views;

namespace BusinessLayer.Repositiry.Interfaces
{
	public interface IDirectiveRepository
	{
		Task<List<DirectiveView>> GetDirectives(int aircraftId, DirectiveType directiveType, ADType? adType = null);
	}
}