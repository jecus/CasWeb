using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Dictionaties;

namespace BusinessLayer.Views
{
	public class TransferRecordView : BaseView
	{
		public int? ParentID { get; set; }

		public int? ParentType { get; set; }

		public int FromAircraftID { get; set; }

		public int FromStoreID { get; set; }

		public int? DestinationObjectID { get; set; }

		public int? DestinationObjectType { get; set; }

        public SmartCoreType DestinationType
        {
            get { return SmartCoreType.GetSmartCoreTypeById(DestinationObjectType.Value); }
        }

        public DateTime? TransferDate { get; set; }

		public string Position { get; set; }

        public BaseComponentView Component { get; set; }

        public int? State { get; set; }
        

    }
}