namespace BusinessLayer.Views
{
	public class ProductView : BaseView
	{
		public string Description { get; set; }

		public string PartNumber { get; set; }

		public string AltPartNumber { get; set; }

		public int? StandartId { get; set; }

		public string Manufacturer { get; set; }

		public double? CostNew { get; set; }

		public double? CostOverhaul { get; set; }

		public double? CostServiceable { get; set; }

		public int? Measure { get; set; }

		public string Remarks { get; set; }

		public string DefaultProduct { get; set; }

		public string Model { get; set; }

		public string SubModel { get; set; }

		public string FullName { get; set; }

		public string ShortName { get; set; }

		public string Designer { get; set; }

		public string Code { get; set; }

		public short? ComponentClass { get; set; }

		public int? ComponentModel { get; set; }

		public int? ComponentType { get; set; }

		public bool IsDangerous { get; set; }

		public string DescRus { get; set; }

		public string HTS { get; set; }

		public string Reference { get; set; }

		public string IsEffectivity { get; set; }
		
		public ATAChapterView AtaChapter { get; set; }
	}
}