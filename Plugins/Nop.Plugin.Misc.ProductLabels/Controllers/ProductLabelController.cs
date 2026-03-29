using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Plugin.Misc.ProductLabels.Domain;
using Nop.Plugin.Misc.ProductLabels.Models;
using Nop.Plugin.Misc.ProductLabels.Services;
using Nop.Services.Catalog;
using Nop.Services.Messages;
using Nop.Services.Security;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;
using System;
using System.Collections.Generic;
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
    private readonly IProductService _productService;

    public ProductLabelsController(
        IProductLabelService labelService,
        IPermissionService permissionService,
        INotificationService notificationService,
        IProductService productService)
    {
        _labelService = labelService;
        _permissionService = permissionService;
        _notificationService = notificationService;
        _productService = productService;
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

        var model = (await Task.WhenAll(labels.Select(async x =>
        {
            var mappings = await _labelService.GetMappingsByLabelIdAsync(x.Id);
            var productNames = new List<string>();
            foreach(var m in mappings)
            {
                var p = await _productService.GetProductByIdAsync(m.ProductId);
                if (p != null) productNames.Add(p.Name);
            }

            return new ProductLabelModel
            {
                Id = x.Id,
                ProductNames = productNames,
                LabelText = x.LabelText,
                DisplayOrder = x.DisplayOrder,
                IsPublished = x.IsPublished
            };
        }))).ToList();

        return View("~/Plugins/Misc.ProductLabels/Views/Admin/List.cshtml", model);
    }


    public async Task<IActionResult> Create()
    {
        var products = await _productService.SearchProductsAsync(pageSize: 1000);

        var model = new ProductLabelModel
        {
            AvailableProducts = products.Select(p => new SelectListItem
            {
                Value = p.Id.ToString(),
                Text = p.Name
            }).ToList()
        };

        return View("~/Plugins/Misc.ProductLabels/Views/Admin/Create.cshtml", model);
    }

    [HttpPost]
    public async Task<IActionResult> Create(ProductLabelModel model)
    {
        if (!ModelState.IsValid)
        {
            // 🔥 لازم ترجع المنتجات مرة تانية
            var products = await _productService.SearchProductsAsync(pageSize: 1000);

            model.AvailableProducts = products.Select(p => new SelectListItem
            {
                Value = p.Id.ToString(),
                Text = p.Name
            }).ToList();

            return View("~/Plugins/Misc.ProductLabels/Views/Admin/Create.cshtml", model);
        }

        var entity = new ProductLabel
        {
            LabelText = model.LabelText,
            DisplayOrder = model.DisplayOrder,
            IsPublished = model.IsPublished,
            CreatedOnUtc = DateTime.UtcNow
        };

        await _labelService.InsertAsync(entity);

        // insert mappings
        if (model.SelectedProductIds != null)
        {
            foreach (var pid in model.SelectedProductIds)
            {
                await _labelService.InsertMappingAsync(new ProductLabelProduct { ProductLabelId = entity.Id, ProductId = pid });
            }
        }

        _notificationService.SuccessNotification("Label created successfully");

        return RedirectToAction("List");
    }

    public async Task<IActionResult> Edit(int id)
    {
        var label = await _labelService.GetByIdAsync(id);
        if (label == null)
            return RedirectToAction("List");

        var mappings = await _labelService.GetMappingsByLabelIdAsync(label.Id);
        var selectedIds = mappings.Select(m => m.ProductId).ToList();
        var productNames = new List<string>();
        foreach (var pid in selectedIds)
        {
            var p = await _productService.GetProductByIdAsync(pid);
            if (p != null) productNames.Add(p.Name);
        }

        var model = new ProductLabelModel
        {
            Id = label.Id,
            SelectedProductIds = selectedIds,
            ProductNames = productNames,
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

        entity.LabelText = model.LabelText;
        entity.DisplayOrder = model.DisplayOrder;
        entity.IsPublished = model.IsPublished;

        await _labelService.UpdateAsync(entity);

        // update mappings: remove existing and add new
        await _labelService.DeleteMappingsByLabelIdAsync(entity.Id);
        if (model.SelectedProductIds != null)
        {
            foreach (var pid in model.SelectedProductIds)
                await _labelService.InsertMappingAsync(new ProductLabelProduct { ProductLabelId = entity.Id, ProductId = pid });
        }

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
    public IActionResult ProductSearchPopup()
    {
        var model = new ProductSearchModel();
        return View("~/Plugins/Misc.ProductLabels/Views/Admin/ProductSearchPopup.cshtml", model);
    }

    [HttpPost]
    public async Task<IActionResult> ProductSearchList(ProductSearchModel searchModel)
    {
        var products = await _productService.SearchProductsAsync(
            keywords: searchModel.SearchTerm,
            pageIndex: searchModel.Page > 0 ? searchModel.Page - 1 : 0,
            pageSize: searchModel.PageSize > 0 ? searchModel.PageSize : 10
        );

        var model = new
        {
            data = products.Select(p => new
            {
                id = p.Id,
                name = p.Name
            }),
            recordsTotal = products.TotalCount,
            recordsFiltered = products.TotalCount
        };

        return Json(model);
    }
}