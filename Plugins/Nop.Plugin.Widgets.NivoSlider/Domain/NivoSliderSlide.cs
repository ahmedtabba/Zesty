using Nop.Core;

namespace Nop.Plugin.Widgets.NivoSlider.Domain
{
    public class NivoSliderSlide : BaseEntity
    {
        public int? PictureId { get; set; }
        public int PictureProductId { get; set; }
        public string Text { get; set; }
        public string CaptionHtml { get; set; }
        public string Link { get; set; }
        public string AltText { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; }
    }
}