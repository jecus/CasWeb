using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.Views
{
    public class ATLBView : BaseView
    {
	    public ATLBView()
	    {
		    OpeningDate = DateTime.Today;
	    }

        public int? AircraftID { get; set; }

        public string ATLBNo { get; set; }

        public int StartPageNo { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("OpeningDate")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? OpeningDate { get; set; }

        public string Remarks { get; set; }

        public string Revision { get; set; }

        public int? PageFlightCount { get; set; }

        public AtlbStatus AtlbStatus { get; set; }

        public string Pages { get; set; }

        public string Dates { get; set; }

        public DateTime DateFrom { get; set; }
    }
}