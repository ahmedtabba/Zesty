using System.Collections.Generic;
using System.Threading.Tasks;
using Nop.Core;
using Nop.Core.Infrastructure;
using Nop.Services.Cms;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Media;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;

namespace Nop.Plugin.Widgets.NivoSlider
{
    /// <summary>
    /// Nivo Slider Plugin
    /// </summary>
    public class NivoSliderPlugin : BasePlugin, IWidgetPlugin
    {
        private readonly ILocalizationService _localizationService;
        private readonly IPictureService _pictureService;
        private readonly ISettingService _settingService;
        private readonly IWebHelper _webHelper;
        private readonly INopFileProvider _fileProvider;

        public NivoSliderPlugin(
            ILocalizationService localizationService,
            IPictureService pictureService,
            ISettingService settingService,
            IWebHelper webHelper,
            INopFileProvider fileProvider)
        {
            _localizationService = localizationService;
            _pictureService = pictureService;
            _settingService = settingService;
            _webHelper = webHelper;
            _fileProvider = fileProvider;
        }

        /// <summary>
        /// Widget zones where the slider will appear
        /// </summary>
        public Task<IList<string>> GetWidgetZonesAsync()
        {
            return Task.FromResult<IList<string>>(
                new List<string> { PublicWidgetZones.HomepageTop });
        }

        /// <summary>
        /// Configuration page URL
        /// </summary>
        public override string GetConfigurationPageUrl()
        {
            return _webHelper.GetStoreLocation() +
                   "Admin/WidgetsNivoSlider/List";
        }

        /// <summary>
        /// View component name
        /// </summary>
        public string GetWidgetViewComponentName(string widgetZone)
        {
            return "WidgetsNivoSlider";
        }

        /// <summary>
        /// Install plugin
        /// </summary>
        public override async Task InstallAsync()
        {
            var imagesPath = _fileProvider.MapPath(
                "~/Plugins/Widgets.NivoSlider/Content/nivoslider/sample-images/");

            var settings = new NivoSliderSettings
            {
                // Slide 1
                Picture1Id = (await _pictureService.InsertPictureAsync(
                    await _fileProvider.ReadAllBytesAsync(
                        _fileProvider.Combine(imagesPath, "banner1.jpg")),
                    MimeTypes.ImagePJpeg,
                    "banner_1")).Id,

                PictureProduct1Id = 0,
                Text1 = "",
                CaptionHtml1 = "",
                Link1 = _webHelper.GetStoreLocation(),
                AltText1 = "",

                // Slide 2
                Picture2Id = (await _pictureService.InsertPictureAsync(
                    await _fileProvider.ReadAllBytesAsync(
                        _fileProvider.Combine(imagesPath, "banner2.jpg")),
                    MimeTypes.ImagePJpeg,
                    "banner_2")).Id,

                PictureProduct2Id = 0,
                Text2 = "",
                CaptionHtml2 = "",
                Link2 = _webHelper.GetStoreLocation(),
                AltText2 = "",

                // Slide 3
                Picture3Id = (await _pictureService.InsertPictureAsync(
                    await _fileProvider.ReadAllBytesAsync(
                        _fileProvider.Combine(imagesPath, "banner3.jpg")),
                    MimeTypes.ImagePJpeg,
                    "banner_3")).Id,

                PictureProduct3Id = 0,
                Text3 = "",
                CaptionHtml3 = "",
                Link3 = _webHelper.GetStoreLocation(),
                AltText3 = "",

                // Slide 4
                Picture4Id = (await _pictureService.InsertPictureAsync(
                    await _fileProvider.ReadAllBytesAsync(
                        _fileProvider.Combine(imagesPath, "banner4.jpg")),
                    MimeTypes.ImagePJpeg,
                    "banner_4")).Id,

                PictureProduct4Id = 0,
                Text4 = "",
                CaptionHtml4 = "",
                Link4 = _webHelper.GetStoreLocation(),
                AltText4 = "",

                // Slide 5
                Picture5Id = (await _pictureService.InsertPictureAsync(
                    await _fileProvider.ReadAllBytesAsync(
                        _fileProvider.Combine(imagesPath, "banner5.jpg")),
                    MimeTypes.ImagePJpeg,
                    "banner_5")).Id,

                PictureProduct5Id = 0,
                Text5 = "",
                CaptionHtml5 = "",
                Link5 = _webHelper.GetStoreLocation(),
                AltText5 = ""
            };

            await _settingService.SaveSettingAsync(settings);

            /// Localization resources
            await _localizationService.AddOrUpdateLocaleResourceAsync(
                new Dictionary<string, string>
                {
                    ["Plugins.Widgets.NivoSlider.Picture"] = "Picture",
                    ["Plugins.Widgets.NivoSlider.Picture.Hint"] = "Upload image",

                    ["Plugins.Widgets.NivoSlider.Picture.Product"] =
                    "Overlay Picture",

                    ["Plugins.Widgets.NivoSlider.Text"] =
                    "Text",

                    ["Plugins.Widgets.NivoSlider.Link"] =
                    "URL",

                    ["Plugins.Widgets.NivoSlider.AltText"] =
                    "Alt text",

                    ["Plugins.Widgets.NivoSlider.Caption"] =
                    "Caption (HTML)",

                    ["Plugins.Widgets.NivoSlider.Caption.Hint"] =
                    "HTML content displayed over the slide"
                });

            await base.InstallAsync();
        }

        /// <summary>
        /// Uninstall plugin
        /// </summary>
        public override async Task UninstallAsync()
        {
            await _settingService.DeleteSettingAsync<NivoSliderSettings>();

            await _localizationService.DeleteLocaleResourcesAsync(
                "Plugins.Widgets.NivoSlider");

            await base.UninstallAsync();
        }

        /// <summary>
        /// Show plugin in widget list
        /// </summary>
        public bool HideInWidgetList => false;
    }
}