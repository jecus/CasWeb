using BusinessLayer.Dictionaties;

namespace BusinessLayer.Views
{
	public class BaseComponentView : ComponentView
	{
		private BaseComponentType _baseComponentType;
		
		public int BaseComponentTypeId { get; set; }

		public string Position
		{
			get { return TransferRecords.GetLast() != null ? TransferRecords.GetLast().Position : ""; }
		}

		public BaseComponentType BaseComponentType
		{
			get => BaseComponentType.GetComponentTypeById(BaseComponentTypeId);
		}

		public int ParentAircraftId { get; set; }
		public int ParentStoreId { get; set; }


		#region Overrides of Object

		public override string ToString()
		{
			var position = TransferRecords != null && TransferRecords.GetLast() != null
				? TransferRecords.GetLast().Position
				: "";
			var res = "";
			res += BaseComponentType.ShortName != "" ? " " + BaseComponentType.ShortName : "";
			res += position != "" ? " " + position : "";
			res += " S/N " + SerialNumber;


			return res;
		}

		#endregion
	}
}