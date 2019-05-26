using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Dictionaties;
using Entity.Models.General;

namespace BusinessLayer.Views
{
	public class MaintenanceDirectiveView : BaseView
	{
		private List<ItemFileLink> _itemFileLink;
		public string TaskNumberCheck { get; set; }

		public MaintenanceDirectiveTaskType WorkType { get; set; }

		public string MPDTaskNumber { get; set; }

		public string MPDNumber { get; set; }

		public string MaintenanceManual { get; set; }

		public string Zone { get; set; }

		public string Access { get; set; }

		public string Applicability { get; set; }

		public string Description { get; set; }

		public string EngineeringOrders { get; set; }

		public string ServiceBulletinNo { get; set; }

		public byte[] Threshold { get; set; }

		public string Remarks { get; set; }

		public string HiddenRemarks { get; set; }

		public bool? IsClosed { get; set; }

		public double? ManHours { get; set; }

		public double? Cost { get; set; }

		public double? Elapsed { get; set; }

		public string MRB { get; set; }

		public string TaskCardNumber { get; set; }

		public MaintenanceDirectiveProgramType Program { get; set; }
		public string ProgramString => Program?.ToString();

		public CriticalSystemList CriticalSystem { get; set; }

		public int? MaintenanceCheckId { get; set; }

		public bool PrintInWP { get; set; }

		public int? JobCardId { get; set; }

		public NDTType NDTType { get; set; }

		public bool KitsApplicable { get; set; }

		public int? ComponentId { get; set; }

		public int? ForComponentId { get; set; }

		public string MpdRef { get; set; }

		public string MpdRevisionNum { get; set; }

		public string MpdOldTaskCard { get; set; }

		public string Workarea { get; set; }

		public DateTime? MpdRevisionDate { get; set; }

		public MpdCategory Category { get; set; }

		public Skill Skill { get; set; }

		public string ScheduleItem { get; set; }

		public string ScheduleRef { get; set; }

		public string ScheduleRevisionNum { get; set; }

		public DateTime? ScheduleRevisionDate { get; set; }

		public bool IsApplicability { get; set; }

		public bool IsOperatorTask { get; set; }

		public MaintenanceDirectiveProgramIndicator ProgramIndicator { get; set; }
		public string ProgramIndicatorString => ProgramIndicator.ToString();

		public ATAChapterView ATAChapter { get; set; }

		public BaseComponentView BaseComponent { get; set; }

		public List<ItemFileLink> ItemFileLink
		{
			get => _itemFileLink ?? (_itemFileLink = new List<ItemFileLink>());
			set => _itemFileLink = value;
		}

		public int FileId => ItemFileLink.FirstOrDefault(i => i.LinkType == (int)FileLinkType.MaintenanceTaskCardNumberFile)?.FileId ?? -1;
	}
}