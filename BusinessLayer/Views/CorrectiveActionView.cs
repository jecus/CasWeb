namespace BusinessLayer.Views
{
    public class CorrectiveActionView : BaseView
    {
        public int DiscrepancyID { get; set; }

        public string Description { get; set; }

        public string ShortDescription { get; set; }

        public string ADDNo { get; set; }

        public bool IsClosed { get; set; }

        public string PartNumberOff { get; set; }

        public string SerialNumberOff { get; set; }

        public string PartNumberOn { get; set; }

        public string SerialNumberOn { get; set; }

        public int CRSID { get; set; }

        public CertificateOfReleaseToServiceView CertificateOfReleaseToService { get; set; }
    }
}