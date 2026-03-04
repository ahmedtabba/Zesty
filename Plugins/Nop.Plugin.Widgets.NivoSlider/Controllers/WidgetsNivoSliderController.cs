using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Widgets.NivoSlider.Domain;
using Nop.Plugin.Widgets.NivoSlider.Models;
using Nop.Plugin.Widgets.NivoSlider.Services;
using Nop.Services.Messages;
using Nop.Services.Security;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;
using System.Linq;
using System.Threading.Tasks;

[AuthorizeAdmin]
[Area(AreaNames.Admin)]
[AutoValidateAntiforgeryToken]
public class WidgetsNivoSliderController : BasePluginController
{
    private readonly INivoSliderService _sliderService;
    private readonly IPermissionService _permissionService;
    private readonly INotificationService _notificationService;

    public WidgetsNivoSliderController(
        INivoSliderService sliderService,
        IPermissionService permissionService,
        INotificationService notificationService)
    {
        _sliderService = sliderService;
        _permissionService = permissionService;
        _notificationService = notificationService;
    }

    public async Task<IActionResult> Configure()
    {
        return RedirectToAction("List");
    }

    public async Task<IActionResult> List()
    {
        if (!await _permissionService.AuthorizeAsync(StandardPermissionProvider.ManageWidgets))
            return AccessDeniedView();

        var slides = await _sliderService.GetAllSlidesAsync();

        var model = slides.Select(x => new SlideModel
        {
            Id = x.Id,
            Text = x.Text,
            DisplayOrder = x.DisplayOrder,
            IsActive = x.IsActive
        }).ToList();

        return View("~/Plugins/Widgets.NivoSlider/Views/Admin/List.cshtml", model);
    }
    public IActionResult Create()
    {
        return View("~/Plugins/Widgets.NivoSlider/Views/Admin/Create.cshtml", new SlideModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(SlideModel model)
    {
        if (!ModelState.IsValid)
            return View("~/Plugins/Widgets.NivoSlider/Views/Admin/Create.cshtml", model);

        var entity = new NivoSliderSlide
        {
            PictureId = model.PictureId,
            PictureProductId = model.PictureProductId,
            CaptionHtml = model.CaptionHtml,
            Text = model.Text,
            Link = model.Link,
            AltText = model.AltText,
            DisplayOrder = model.DisplayOrder,
            IsActive = model.IsActive
        };

        await _sliderService.InsertSlideAsync(entity);

        return RedirectToAction("List");
    }

    public async Task<IActionResult> Edit(int id)
    {
        var slide = await _sliderService.GetByIdAsync(id);
        if (slide == null)
            return RedirectToAction("List");

        var model = new SlideModel
        {
            Id = slide.Id,
            PictureId = slide.PictureId,
            CaptionHtml = slide.CaptionHtml,
            Text = slide.Text,
            Link = slide.Link,
            AltText = slide.AltText,
            DisplayOrder = slide.DisplayOrder,
            IsActive = slide.IsActive,
            PictureProductId = slide.PictureProductId
        };

        return View("~/Plugins/Widgets.NivoSlider/Views/Admin/Edit.cshtml", model);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(SlideModel model)
    {
        if (!ModelState.IsValid)
            return View("~/Plugins/Widgets.NivoSlider/Views/Admin/Create.cshtml", model);

        var slide = await _sliderService.GetByIdAsync(model.Id);
        if (slide == null)
            return RedirectToAction("List");

        slide.PictureId = model.PictureId;
        slide.CaptionHtml = model.CaptionHtml;
        slide.Text = model.Text;
        slide.Link = model.Link;
        slide.AltText = model.AltText;
        slide.DisplayOrder = model.DisplayOrder;
        slide.IsActive = model.IsActive;
        slide.PictureProductId = model.PictureProductId;
        await _sliderService.UpdateSlideAsync(slide);

        return RedirectToAction("List");
    }
    [HttpPost]
    public async Task<IActionResult> Delete(int id)
    {
        var slide = await _sliderService.GetByIdAsync(id);
        if (slide != null)
            await _sliderService.DeleteSlideAsync(slide);

        return RedirectToAction("List");
    }
}