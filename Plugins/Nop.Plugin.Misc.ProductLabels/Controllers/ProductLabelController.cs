using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Misc.ProductLabels.Domain;
using Nop.Plugin.Misc.ProductLabels.Models;
using Nop.Plugin.Misc.ProductLabels.Services;
using Nop.Services.Messages;
using Nop.Services.Security;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;
using System;
using System.Linq;
using System.Threading.Tasks;

[AuthorizeAdmin]
[Area(AreaNames.Admin)]
[AutoValidateAntiforgeryToken]
public class ProductLabelsController : BasePluginController
{
    private readonly IProductLabelService _labelService;
    private readonly IPermissionService _permissionService;
    private readonly INotificationService _notificationService;

    public ProductLabelsController(
        IProductLabelService labelService,
        IPermissionService permissionService,
        INotificationService notificationService)
    {
        _labelService = labelService;
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

        var labels = await _labelService.GetAllAsync();

        var model = labels.Select(x => new ProductLabelModel
        {
            Id = x.Id,
            ProductId = x.ProductId,
            LabelText = x.LabelText,
            DisplayOrder = x.DisplayOrder,
            IsPublished = x.IsPublished
        }).ToList();

        return View("~/Plugins/Misc.ProductLabels/Views/Admin/List.cshtml", model);
    }

    
    public IActionResult Create()
    {
        return View("~/Plugins/Misc.ProductLabels/Views/Admin/Create.cshtml", new ProductLabelModel());
    }

    [HttpPost]
    public async Task<IActionResult> Create(ProductLabelModel model)
    {
        if (!ModelState.IsValid)
            return View("~/Plugins/Misc.ProductLabels/Views/Admin/Create.cshtml", model);

        var entity = new ProductLabel
        {
            ProductId = model.ProductId,
            LabelText = model.LabelText,
            DisplayOrder = model.DisplayOrder,
            IsPublished = model.IsPublished,
            CreatedOnUtc = DateTime.UtcNow
        };

        await _labelService.InsertAsync(entity);

        _notificationService.SuccessNotification("Label created successfully");

        return RedirectToAction("List");
    }

   
    public async Task<IActionResult> Edit(int id)
    {
        var label = await _labelService.GetByIdAsync(id);
        if (label == null)
            return RedirectToAction("List");

        var model = new ProductLabelModel
        {
            Id = label.Id,
            ProductId = label.ProductId,
            LabelText = label.LabelText,
            DisplayOrder = label.DisplayOrder,
            IsPublished = label.IsPublished
        };

        return View("~/Plugins/Misc.ProductLabels/Views/Admin/Edit.cshtml", model);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(ProductLabelModel model)
    {
        if (!ModelState.IsValid)
            return View("~/Plugins/Misc.ProductLabels/Views/Admin/Edit.cshtml", model);

        var entity = await _labelService.GetByIdAsync(model.Id);
        if (entity == null)
            return RedirectToAction("List");

        entity.ProductId = model.ProductId;
        entity.LabelText = model.LabelText;
        entity.DisplayOrder = model.DisplayOrder;
        entity.IsPublished = model.IsPublished;

        await _labelService.UpdateAsync(entity);

        _notificationService.SuccessNotification("Label updated successfully");

        return RedirectToAction("List");
    }

    [HttpPost]
    public async Task<IActionResult> Delete(int id)
    {
        var entity = await _labelService.GetByIdAsync(id);
        if (entity != null)
            await _labelService.DeleteAsync(entity);

        _notificationService.SuccessNotification("Label deleted successfully");

        return RedirectToAction("List");
    }
}