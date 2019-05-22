using BusinessLayer.Dictionaties;
using Entity.Extentions;

namespace BusinessLayer.Views
{
	public interface IProductView
	{
		string Description { get; }

		string PartNumber { get; }

		string AltPartNumber { get; }

		string Manufacturer { get; }

		double? CostNew { get; }

		double? CostOverhaul { get; }

		double? CostServiceable { get; }

		int? Measure { get; }

		string Remarks { get; }

		string Model { get;  }

		string Code { get; }

		string SubModel { get; set; }

		string FullName { get; set; }

		string ShortName { get; set; }

		string Designer { get; set; }


		GoodsClass ComponentClass { get; }
		string ComponentClassString { get; }


		bool IsDangerous { get; }
		string IsDangerousString { get; }

		string DescRus { get; }

		string HTS { get; }

		string Reference { get; }

		string IsEffectivity { get;}

		ATAChapterView AtaChapter { get; }
		string AtaChapterString { get; }
	}
}