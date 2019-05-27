using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Dictionaties;
using Entity.Models.General;

namespace BusinessLayer.Views
{
	public class DirectiveView : BaseView
	{
		private List<ItemFileLink> _itemFileLink;

		public string Title { get; set; }
		public string AdNo => Title + "  §: " + Paragraph;

		public bool IsApplicability { get; set; }

		public double? ManHours { get; set; }

		public string Remarks { get; set; }

		public byte[] Threshold { get; set; }

		public byte[] ThldTypeCond { get; set; }

		public string Applicability { get; set; }

		public DirectiveType DirectiveType { get; set; }

		public string Description { get; set; }

		public string EngineeringOrders { get; set; }
		public string EoNo => EngineeringOrders != "" ? EngineeringOrders : "N/A";

		public double? Cost { get; set; }

		public string Paragraph { get; set; }

		public string KitRequired { get; set; }

		public string HiddenRemarks { get; set; }

		public ADType ADType { get; set; }

		public DirectiveWorkType WorkType { get; set; }

		public string ServiceBulletinNo { get; set; }
		public string SbNo => ServiceBulletinNo != "" ? ServiceBulletinNo : "N/A";

		public string StcNo { get; set; }

		public bool? IsClosed { get; set; }

		public int? AircraftFlight { get; set; }

		public NDTType NDTType { get; set; }

		public DirectiveOrder DirectiveOrder { get; set; }

		public int? SupersedesId { get; set; }

		public int? SupersededId { get; set; }
		public string Zone { get; set; }

		public string Access { get; set; }

		public string Workarea { get; set; }

		public ATAChapterView ATAChapter { get; set; }
		public string AtaString => ATAChapter.ToString(); 

		public BaseComponentView BaseComponent { get; set; }

		public List<ItemFileLink> ItemFileLink
		{
			get => _itemFileLink ?? (_itemFileLink = new List<ItemFileLink>());
			set => _itemFileLink = value;
		}

		public int EngineeringOrderFileID  => ItemFileLink.FirstOrDefault(i => i.LinkType == (int)FileLinkType.EOFile)?.FileId ?? -1;

		public int ServiceBulletinFileID => ItemFileLink.FirstOrDefault(i => i.LinkType == (int)FileLinkType.SBFile)?.FileId ?? -1;

		public int ADFileID => ItemFileLink.FirstOrDefault(i => i.LinkType == (int)FileLinkType.ADFile)?.FileId ?? -1;
	}
}