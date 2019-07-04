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
		
	}
}