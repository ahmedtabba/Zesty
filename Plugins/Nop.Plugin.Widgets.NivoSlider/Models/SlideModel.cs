using Microsoft.AspNetCore.Http;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Nop.Plugin.Widgets.NivoSlider.Models
{
    public record SlideModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Picture")]
        [UIHint("Picture")]
        [Required]
        public int? PictureId { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Picture.Product")]
        [UIHint("Picture")]
        public int PictureProductId { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.CaptionHtml")]
        [UIHint("RichEditor")]
        public string CaptionHtml { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Text")]
        public string Text { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Link")]
        public string Link { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.AltText")]
        public string AltText { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.DisplayOrder")]
        [Required]
        public int DisplayOrder { get; set; }

        public bool IsActive { get; set; }

        public string PictureUrl { get; set; }
        public string PictureProductUrl { get; set; }


    }
}