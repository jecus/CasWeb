namespace BusinessLayer.Views
{
	public class GoodStandartView : BaseView
	{
		public string Name { get; set; }

		public string PartNumber { get; set; }

		public string Description { get; set; }

		public double? CostNew { get; set; }

		public double? CostOverhaul { get; set; }

		public double? CostServiceable { get; set; }

		public int? Measure { get; set; }

		public string Remarks { get; set; }

		public int? DefaultProductId { get; set; }

		public int? ComponentType { get; set; }

		public int? ComponentClass { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}
}