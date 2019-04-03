using System;

namespace BusinessLayer.Views
{
    public class CertificateOfReleaseToServiceView : BaseView
    {
        public string Station { get; set; }

        public DateTime? RecordDate { get; set; }

        public string CheckPerformed { get; set; }

        public string Reference { get; set; }

        public int? AuthorizationB1Id { get; set; }

        public int? AuthorizationB2Id { get; set; }
        
    }
}