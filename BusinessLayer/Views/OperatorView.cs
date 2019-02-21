namespace BusinessLayer.Views
{
    public class OperatorView : BaseView
    {
        public int ItemId { get; set; }
        
        public bool IsDeleted { get; set; }

        public string Name { get; set; }

        public string ICAOCode { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public string Email { get; set; }

        public byte[] LogoType { get; set; }

        public byte[] LogoTypeWhite { get; set; }

        public byte[] LogotypeReportLarge { get; set; }

        public byte[] LogotypeReportVeryLarge { get; set; }
    }
}