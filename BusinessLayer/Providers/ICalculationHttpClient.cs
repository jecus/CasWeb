using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLayer.Views;

namespace BusinessLayer.Providers
{
	public interface ICalculationHttpClient
	{
		Task<List<NextPerformance>> NextPerformanceForComponent(int componentId);
		Task<Dictionary<int, List<NextPerformance>>> NextPerformanceForComponents(List<int> componentIds);
		Task<List<NextPerformance>> NextPerformanceForComponentDirective(int componentDirectiveId);
		Task<Dictionary<int, List<NextPerformance>>> NextPerformanceForComponentDirectives(List<int> componentDirectiveIds);
	}
}