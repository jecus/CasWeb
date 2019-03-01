
namespace BusinessLayer.Views
{
    public class ComponentDirectiveView : BaseView
    {
        
        public int DirectiveType { get; set; }

        public byte[] Threshold { get; set; }

        public double? ManHours { get; set; }

        public string Remarks { get; set; }

        public double? Cost { get; set; }

        public int? Highlight { get; set; }

        public string KitRequired { get; set; }

        public int? FaaFormFileID { get; set; }

        public string HiddenRemarks { get; set; }

        public bool? IsClosed { get; set; }

        public int? MPDTaskTypeId { get; set; }

        public short NDTType { get; set; }

        public int? ComponentId { get; set; }
        
        public string ZoneArea { get; set; }

        public string AccessDirective { get; set; }

        public string AAM { get; set; }

        public string CMM { get; set; }



        #region Navigation Property

        public ComponentView Component { get; set; }

        #endregion
    }
}