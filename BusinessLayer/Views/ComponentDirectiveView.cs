using BusinessLayer.Dictionaties;
using Entity.Models.General;

namespace BusinessLayer.Views
{
	public class ComponentDirectiveView : BaseView
	{
		
		public int DirectiveType { get; set; }

		public Threshold Threshold { get; set; }

		public double ManHours { get; set; }

		public string Remarks { get; set; }

		public double Cost { get; set; }

		public int? Highlight { get; set; }

		public string KitRequired { get; set; }

		public int? FaaFormFileID { get; set; }

		public string HiddenRemarks { get; set; }

		public bool? IsClosed { get; set; }

		public int? MPDTaskTypeId { get; set; }

		public NDTType NDTType { get; set; }
		public string NDTTypeString => NDTType.ShortName;

		public int? ComponentId { get; set; }
		
		public string ZoneArea { get; set; }

		public string AccessDirective { get; set; }

		public string AAM { get; set; }

		public string CMM { get; set; }

		public string ATAChapterString => Component != null ? Component.ATAChapterString : " ";
		public string PartNumberString => Component != null ? Component.PartNumber : " ";
		public string DescriptionString => Component != null ? Component.Description : " ";
		public string SerialNumberString => Component != null ? Component.SerialNumber : " ";
		public string MPDItemString => Component != null ? Component.MPDItem : " ";
		public string TransferDateString => Component != null ? Component?.TransferRecords?.GetLast()?.TransferDate.ToUniversalString() : " ";
		public string PositionString => Component != null ? Component?.TransferRecords?.GetLast()?.Position : " ";
		


		#region Navigation Property

		public ComponentView Component { get; set; }

		#endregion
	}
}