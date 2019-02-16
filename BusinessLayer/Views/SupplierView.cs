﻿namespace BusinessLayer.Views
{
    public class SupplierView : BaseView
    {
        public string Name { get; set; }

        public string ShortName { get; set; }

        public string AirCode { get; set; }

        public string VendorCode { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public string Address { get; set; }

        public string ContactPerson { get; set; }

        public string Email { get; set; }

        public string WebSite { get; set; }

        public string Products { get; set; }

        public bool? Approved { get; set; }

        public string Remarks { get; set; }

        public int SupplierClassId { get; set; }

        public string Subject { get; set; }
    }
}