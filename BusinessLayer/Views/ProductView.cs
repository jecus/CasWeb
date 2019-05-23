using BusinessLayer.Dictionaties;
using Entity.Extentions;

namespace BusinessLayer.Views
{
	public class ProductView : BaseView, IProductView
	{
		public string Description { get; set; }

		public string PartNumber { get; set; }

		public string AltPartNumber { get; set; }

		public string Manufacturer { get; set; }

		public double? CostNew { get; set; }

		public double? CostOverhaul { get; set; }

		public double? CostServiceable { get; set; }

		public int? Measure { get; set; }

		public string Remarks { get; set; }

		public string Model { get; set; }

		public string Code { get; set; }

		public string SubModel { get; set; }

		public string FullName { get; set; }

		public string ShortName { get; set; }

		public string Designer { get; set; }

		public GoodsClass ComponentClass { get; set; }
		public string ComponentClassString => ComponentClass?.ToString();


		public bool IsDangerous { get; set; }
		public string IsDangerousString => IsDangerous.ToYesNo();

		public string DescRus { get; set; }

		public string HTS { get; set; }

		public string Reference { get; set; }

		public string IsEffectivity { get; set; }
		
		public ATAChapterView AtaChapter { get; set; }
		public string AtaChapterString => AtaChapter?.ToString();

		public GoodStandartView Standard { get; set; }
		public string StandardString => Standard?.ToString();
	}
}