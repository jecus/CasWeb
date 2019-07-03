namespace BusinessLayer.Views
{
	public class MaintenanceCheckView : BaseView
	{
		public string Name { get; set; }

		public byte[] Interval { get; set; }

		public byte[] Notify { get; set; }

		public int ParentAircraft { get; set; }

		public int? CheckTypeId { get; set; }

		public double? Cost { get; set; }

		public double? ManHours { get; set; }

		public bool? Schedule { get; set; }

		public short Resource { get; set; }

		public bool Grouping { get; set; }


		public MaintenanceCheckTypeView CheckType { get; set; }
	}
}