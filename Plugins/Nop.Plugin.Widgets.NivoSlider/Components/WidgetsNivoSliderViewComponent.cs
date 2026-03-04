using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Widgets.NivoSlider.Models;
using Nop.Plugin.Widgets.NivoSlider.Services;
using Nop.Services.Media;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nop.Plugin.Widgets.NivoSlider.Components
{
    [ViewComponent(Name = "WidgetsNivoSlider")]
    public class WidgetsNivoSliderViewComponent : ViewComponent
    {
        private readonly INivoSliderService _sliderService;
        private readonly IPictureService _pictureService;

        public WidgetsNivoSliderViewComponent(INivoSliderService sliderService, IPictureService pictureService)
        {
            _sliderService = sliderService;
            _pictureService = pictureService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var slides = await _sliderService.GetAllSlidesAsync();

            var model = new PublicInfoModel
            {
                Slides = new List<SlideModel>()
            };

            foreach (var s in slides.Where(x => x.IsActive).OrderBy(x => x.DisplayOrder))
            {
                var pictureUrl = await _pictureService.GetPictureUrlAsync(s.PictureId??0);
                var pictureProductUrl = await _pictureService.GetPictureUrlAsync(s.PictureProductId);

                model.Slides.Add(new SlideModel
                {
                    Id = s.Id,
                    PictureUrl = pictureUrl,
                    PictureProductUrl = pictureProductUrl,
                    PictureProductId = s.PictureProductId,
                    Text = s.Text,
                    CaptionHtml = s.CaptionHtml,
                    Link = s.Link,
                    AltText = s.AltText,
                    DisplayOrder = s.DisplayOrder,
                    IsActive = s.IsActive
                });
            }

            return View("~/Plugins/Widgets.NivoSlider/Views/PublicInfo.cshtml", model);
        }
    }
}