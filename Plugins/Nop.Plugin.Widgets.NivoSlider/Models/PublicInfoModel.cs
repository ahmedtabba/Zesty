using Nop.Web.Framework.Models;

namespace Nop.Plugin.Widgets.NivoSlider.Models
{
    public record PublicInfoModel : BaseNopModel
    {
        // SLIDE 1
        public string Picture1Url { get; set; }
        public string Picture1ProductUrl { get; set; }
        public string Text1 { get; set; }
        public string CaptionHtml1 { get; set; } 
        public string Link1 { get; set; }
        public string AltText1 { get; set; }

        // SLIDE 2
        public string Picture2Url { get; set; }
        public string Picture2ProductUrl { get; set; }
        public string Text2 { get; set; }
        public string CaptionHtml2 { get; set; } 
        public string Link2 { get; set; }
        public string AltText2 { get; set; }

        // SLIDE 3
        public string Picture3Url { get; set; }
        public string Picture3ProductUrl { get; set; }
        public string Text3 { get; set; }
        public string CaptionHtml3 { get; set; } 
        public string Link3 { get; set; }
        public string AltText3 { get; set; }

        // SLIDE 4
        public string Picture4Url { get; set; }
        public string Picture4ProductUrl { get; set; }
        public string Text4 { get; set; }
        public string CaptionHtml4 { get; set; } 
        public string Link4 { get; set; }
        public string AltText4 { get; set; }

        // SLIDE 5
        public string Picture5Url { get; set; }
        public string Picture5ProductUrl { get; set; }
        public string Text5 { get; set; }
        public string CaptionHtml5 { get; set; } 
        public string Link5 { get; set; }
        public string AltText5 { get; set; }
    }
}