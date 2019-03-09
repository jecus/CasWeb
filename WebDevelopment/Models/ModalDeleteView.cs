namespace WebDevelopment.Models
{
	public class ModalDeleteView
	{
		public string ControllerName { get; set; }
		public string ActionName { get; set; }
		public int DeleteId { get; set; }
		public string Message { get; set; }

		public ModalDeleteView(string controllerName, string actionName, int deleteId, string message ="")
		{
			ControllerName = controllerName;
			ActionName = actionName;
			DeleteId = deleteId;
			Message = message;
		}
	}
}