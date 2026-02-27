// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Controllers.AnywhereSlidersAdminController
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Services.Localization;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Kendoui;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Models.Extensions;
using Nop.Web.Framework.Mvc.Filters;
using SevenSpikes.Nop.Framework.Areas.Admin.ControllerAttributes;
using SevenSpikes.Nop.Framework.Areas.Admin.Controllers;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Extensions;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Factories;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Helpers;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Sliders;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.Sliders;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Helpers;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable enable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Controllers;

[ManagePluginsAdminAuthorize("SevenSpikes.Nop.Plugins.AnywhereSliders", false)]
public class AnywhereSlidersAdminController : Base7SpikesAdminController
{
  private readonly 
  #nullable disable
  ISliderService _sliderService;
  private readonly ILocalizationService _localizationService;
  private readonly ISliderAdminModelFactory _sliderAdminModelFactory;
  private readonly ISlidePictureHelper _sliderPictureHelper;
  private readonly ICustomCssHelper _customCssHelper;

  public AnywhereSlidersAdminController(
    ISliderService sliderService,
    ILocalizationService localizationService,
    ISliderAdminModelFactory sliderAdminModelFactory,
    ISlidePictureHelper slidePictureHelper,
    ICustomCssHelper customCssHelper)
  {
    this._sliderService = sliderService;
    this._localizationService = localizationService;
    this._sliderAdminModelFactory = sliderAdminModelFactory;
    this._sliderPictureHelper = slidePictureHelper;
    this._customCssHelper = customCssHelper;
  }

  public ActionResult List() => (ActionResult) ((Controller) this).View(nameof (List));

  [HttpPost]
  public async Task<ActionResult> List(SliderSearchModel searchModel)
  {
    AnywhereSlidersAdminController slidersAdminController = this;
    System.Collections.Generic.List<Slider> sliderList = new System.Collections.Generic.List<Slider>();
    System.Collections.Generic.List<Slider> list;
    if (!string.IsNullOrEmpty(searchModel.SearchSliderName))
      list = (await slidersAdminController._sliderService.SearchSlidersAsync(searchModel.SearchSliderName)).ToList<Slider>();
    else
      list = (await slidersAdminController._sliderService.GetAllSlidersAsync()).ToList<Slider>();
    PagedList<SliderModel> pagedList = new PagedList<SliderModel>(slidersAdminController._sliderAdminModelFactory.PrepareSlidersList((IList<Slider>) list), searchModel.Page - 1, searchModel.PageSize, new int?());
    SliderListModel grid = ModelExtensions.PrepareToGrid<SliderListModel, SliderModel, SliderModel>(new SliderListModel(), (BaseSearchModel) searchModel, (IPagedList<SliderModel>) pagedList, (Func<IEnumerable<SliderModel>>) (() => (IEnumerable<SliderModel>) pagedList));
    return (ActionResult) ((Controller) slidersAdminController).Json((object) grid);
  }

  public async Task<ActionResult> Create()
  {
    AnywhereSlidersAdminController slidersAdminController = this;
    SliderModel model = await slidersAdminController._sliderAdminModelFactory.PrepareSliderModelAsync();
    return (ActionResult) ((Controller) slidersAdminController).View(nameof (Create), (object) model);
  }

  [HttpPost]
  [ParameterBasedOnFormName("save-continue", "continueEditing")]
  public async Task<ActionResult> Create(SliderModel model, bool continueEditing)
  {
    AnywhereSlidersAdminController slidersAdminController = this;
    if (((ControllerBase) slidersAdminController).ModelState.IsValid)
    {
      Slider slider = model.ToEntity();
      await slidersAdminController._sliderService.InsertSliderAsync(slider);
      await slidersAdminController._customCssHelper.SaveCustomCssAsync(slider, model.CustomCss);
      string resourceAsync = await slidersAdminController._localizationService.GetResourceAsync("SevenSpikes.Plugins.AnywhereSliders.Admin.Slider.Created");
      slidersAdminController.SuccessNotification(resourceAsync);
      if (!continueEditing)
        return (ActionResult) ((ControllerBase) slidersAdminController).RedirectToAction("List");
      ((BaseController) slidersAdminController).SaveSelectedTabName("", true);
      return (ActionResult) ((ControllerBase) slidersAdminController).RedirectToAction("Edit", (object) new
      {
        id = slider.Id
      });
    }
    SliderModel sliderModel = model;
    sliderModel.Languages = await slidersAdminController._sliderAdminModelFactory.GetAvailableLanguagesAsync();
    sliderModel = (SliderModel) null;
    return (ActionResult) ((Controller) slidersAdminController).View("Edit", (object) model);
  }

  [HttpPost]
  [ParameterBasedOnFormName("save-continue", "continueEditing")]
  public async Task<ActionResult> Edit(SliderModel model, bool continueEditing)
  {
    AnywhereSlidersAdminController slidersAdminController = this;
    Slider slider = await slidersAdminController._sliderService.GetSliderByIdAsync(model.Id);
    if (slider == null)
      throw new ArgumentException("No slider found with the specified id");
    if (((ControllerBase) slidersAdminController).ModelState.IsValid)
    {
      slider = model.ToEntity(slider);
      slider.LanguageId = int.Parse(model.Language);
      await slidersAdminController.SaveStoreMappingsAsync<Slider>(slider, model.StoreMappingModel);
      await slidersAdminController._sliderService.UpdateSliderAsync(slider);
      await slidersAdminController._customCssHelper.SaveCustomCssAsync(slider, model.CustomCss);
      string resourceAsync = await slidersAdminController._localizationService.GetResourceAsync("SevenSpikes.Plugins.AnywhereSliders.Admin.Slider.Edited");
      slidersAdminController.SuccessNotification(resourceAsync);
      if (!continueEditing)
        return (ActionResult) ((ControllerBase) slidersAdminController).RedirectToAction("List");
      ((BaseController) slidersAdminController).SaveSelectedTabName("", true);
      return (ActionResult) ((ControllerBase) slidersAdminController).RedirectToAction(nameof (Edit), (object) new
      {
        id = slider.Id
      });
    }
    SliderModel sliderModel = model;
    sliderModel.Languages = await slidersAdminController._sliderAdminModelFactory.GetAvailableLanguagesAsync();
    sliderModel = (SliderModel) null;
    model.Language = slider.LanguageId.ToString();
    await slidersAdminController.PrepareStoresMappingModelAsync<Slider>(model.StoreMappingModel, slider, false);
    return (ActionResult) ((Controller) slidersAdminController).View(nameof (Edit), (object) model);
  }

  public async Task<ActionResult> Edit(int id)
  {
    AnywhereSlidersAdminController slidersAdminController = this;
    Slider slider = await slidersAdminController._sliderService.GetSliderByIdAsync(id);
    SliderModel model = await slidersAdminController._sliderAdminModelFactory.PrepareSliderModelAsync(slider);
    await slidersAdminController.PrepareStoresMappingModelAsync<Slider>(model.StoreMappingModel, slider, false);
    ActionResult actionResult = (ActionResult) ((Controller) slidersAdminController).View(nameof (Edit), (object) model);
    slider = (Slider) null;
    model = (SliderModel) null;
    return actionResult;
  }

  [HttpPost]
  [ActionName("Delete")]
  public async Task<ActionResult> DeleteConfirmed(int id)
  {
    AnywhereSlidersAdminController slidersAdminController = this;
    foreach (Slide slide in (IEnumerable<Slide>) await slidersAdminController._sliderService.GetAllSlidesBySliderIdAsync(id))
      await slidersAdminController._sliderPictureHelper.DeleteSlidePicturesAsync(slide);
    Slider sliderByIdAsync = await slidersAdminController._sliderService.GetSliderByIdAsync(id);
    await slidersAdminController._sliderService.DeleteSliderAsync(sliderByIdAsync);
    await slidersAdminController._customCssHelper.WriteCustomCssToFileAsync();
    string resourceAsync = await slidersAdminController._localizationService.GetResourceAsync("SevenSpikes.Plugins.AnywhereSliders.Admin.Slider.Deleted");
    slidersAdminController.SuccessNotification(resourceAsync);
    return (ActionResult) ((ControllerBase) slidersAdminController).RedirectToAction("List");
  }

  public async Task<ActionResult> SliderDelete(int id, DataSourceRequest command)
  {
    AnywhereSlidersAdminController slidersAdminController = this;
    foreach (Slide slide in (IEnumerable<Slide>) await slidersAdminController._sliderService.GetAllSlidesBySliderIdAsync(id))
      await slidersAdminController._sliderPictureHelper.DeleteSlidePicturesAsync(slide);
    Slider sliderByIdAsync = await slidersAdminController._sliderService.GetSliderByIdAsync(id);
    if (sliderByIdAsync == null)
      throw new ArgumentException("No slider found with the specified id");
    await slidersAdminController._sliderService.DeleteSliderAsync(sliderByIdAsync);
    await slidersAdminController._customCssHelper.WriteCustomCssToFileAsync();
    return (ActionResult) slidersAdminController.EmptyJson;
  }
}
