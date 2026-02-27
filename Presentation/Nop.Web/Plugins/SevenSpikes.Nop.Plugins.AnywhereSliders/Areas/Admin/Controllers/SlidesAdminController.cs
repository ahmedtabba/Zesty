// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Controllers.SlidesAdminController
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Microsoft.AspNetCore.Mvc;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Extensions.Primitives;
using Nop.Core;
using Nop.Services.Localization;
using Nop.Web.Framework.Kendoui;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Models.Extensions;
using Nop.Web.Framework.Validators;
using SevenSpikes.Nop.Framework.Areas.Admin.ControllerAttributes;
using SevenSpikes.Nop.Framework.Areas.Admin.Controllers;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Extensions;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Factories;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Helpers;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Sliders;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.Sliders;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

#nullable enable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Controllers;

[ManagePluginsAdminAuthorize("SevenSpikes.Nop.Plugins.AnywhereSliders", false)]
public class SlidesAdminController : Base7SpikesAdminController
{
  private readonly 
  #nullable disable
  ISliderService _sliderService;
  private readonly ISlideAdminModelFactory _slideAdminModelFactory;
  private readonly ISlidePictureHelper _slidePictureHelper;
  private readonly ILocalizedEntityService _localizedEntityService;

  public SlidesAdminController(
    ISliderService sliderService,
    ISlideAdminModelFactory slideAdminModelFactory,
    ISlidePictureHelper slidePictureHelper,
    ILocalizedEntityService localizedEntityService)
  {
    this._sliderService = sliderService;
    this._slideAdminModelFactory = slideAdminModelFactory;
    this._slidePictureHelper = slidePictureHelper;
    this._localizedEntityService = localizedEntityService;
  }

  [HttpPost]
  public async Task<ActionResult> List(
    SliderSearchModel searchModel,
    int sliderId,
    DataSourceRequest command = null)
  {
    SlidesAdminController slidesAdminController = this;
    IList<Slide> slidesBySliderIdAsync = await slidesAdminController._sliderService.GetAllSlidesBySliderIdAsync(sliderId);
    PagedList<SlideModel> pagedList = new PagedList<SlideModel>(slidesAdminController._slideAdminModelFactory.PrepareSlideListModel(slidesBySliderIdAsync), searchModel.Page - 1, searchModel.PageSize, new int?());
    SlideListModel grid = ModelExtensions.PrepareToGrid<SlideListModel, SlideModel, SlideModel>(new SlideListModel(), (BaseSearchModel) searchModel, (IPagedList<SlideModel>) pagedList, (Func<IEnumerable<SlideModel>>) (() => (IEnumerable<SlideModel>) pagedList));
    return (ActionResult) ((Controller) slidesAdminController).Json((object) grid);
  }

  public async Task<ActionResult> Delete(int id, DataSourceRequest command)
  {
    SlidesAdminController slidesAdminController = this;
    Slide slide = await slidesAdminController._sliderService.GetSlideByIdAsync(id);
    int num = slide != null ? slide.SliderId : throw new ArgumentException("No slide found with the specified id");
    await slidesAdminController._sliderService.DeleteSlideAsync(slide);
    await slidesAdminController._slidePictureHelper.DeleteSlidePicturesAsync(slide);
    ActionResult actionResult = (ActionResult) ((Controller) slidesAdminController).Json((object) null);
    slide = (Slide) null;
    return actionResult;
  }

  public async Task<ActionResult> Update(SlideModel model, DataSourceRequest command)
  {
    SlidesAdminController slidesAdminController = this;
    Slide slide = await slidesAdminController._sliderService.GetSlideByIdAsync(model.Id);
    if (slide == null)
      throw new ArgumentException("No slide found with the specified id");
    slide.DisplayOrder = model.DisplayOrder;
    slide.Visible = model.Visible;
    slide.Content = model.Content;
    await slidesAdminController._sliderService.UpdateSlideAsync(slide);
    ActionResult action = (ActionResult) ((ControllerBase) slidesAdminController).RedirectToAction("List", (object) new
    {
      command = command,
      sliderId = slide.SliderId
    });
    slide = (Slide) null;
    return action;
  }

  public async Task<ActionResult> Create(int sliderId)
  {
    SlidesAdminController slidesAdminController = this;
    SlideModel model = new SlideModel()
    {
      SliderId = sliderId
    };
    await slidesAdminController._slideAdminModelFactory.PrepareSlideModelAsync(model);
    ActionResult actionResult = (ActionResult) ((Controller) slidesAdminController).View("CreateSlide", (object) model);
    model = (SlideModel) null;
    return actionResult;
  }

  [HttpPost]
  public async Task<ActionResult> Create([Validate] SlideModel model)
  {
    SlidesAdminController slidesAdminController = this;
    if (((ControllerBase) slidesAdminController).ModelState.IsValid)
    {
      Slide entity = model.ToEntity();
      entity.SlideType = model.Type;
      await slidesAdminController._sliderService.InsertSlideAsync(entity);
      // ISSUE: reference to a compiler-generated field
      if (SlidesAdminController.\u003C\u003Eo__9.\u003C\u003Ep__0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        SlidesAdminController.\u003C\u003Eo__9.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "RefreshPage", typeof (SlidesAdminController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      object obj1 = SlidesAdminController.\u003C\u003Eo__9.\u003C\u003Ep__0.Target((CallSite) SlidesAdminController.\u003C\u003Eo__9.\u003C\u003Ep__0, ((Controller) slidesAdminController).ViewBag, true);
      // ISSUE: reference to a compiler-generated field
      if (SlidesAdminController.\u003C\u003Eo__9.\u003C\u003Ep__1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        SlidesAdminController.\u003C\u003Eo__9.\u003C\u003Ep__1 = CallSite<Func<CallSite, object, StringValues, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "btnId", typeof (SlidesAdminController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      object obj2 = SlidesAdminController.\u003C\u003Eo__9.\u003C\u003Ep__1.Target((CallSite) SlidesAdminController.\u003C\u003Eo__9.\u003C\u003Ep__1, ((Controller) slidesAdminController).ViewBag, ((ControllerBase) slidesAdminController).Request.Form["refreshButtonId"]);
    }
    await slidesAdminController._slideAdminModelFactory.PrepareSlideModelAsync(model);
    return (ActionResult) ((Controller) slidesAdminController).View("CreateSlide", (object) model);
  }

  public async Task<ActionResult> Edit(int id)
  {
    SlidesAdminController slidesAdminController = this;
    Slide slideByIdAsync = await slidesAdminController._sliderService.GetSlideByIdAsync(id);
    SlideModel model = await slidesAdminController._slideAdminModelFactory.PrepareSlideModelAsync(slideByIdAsync);
    return (ActionResult) ((Controller) slidesAdminController).View("EditSlide", (object) model);
  }

  [HttpPost]
  public async Task<ActionResult> Edit([Validate] SlideModel model)
  {
    SlidesAdminController slidesAdminController = this;
    Slide slide = await slidesAdminController._sliderService.GetSlideByIdAsync(model.Id);
    if (slide == null)
      throw new ArgumentException("No slide found with the specified id");
    if (((ControllerBase) slidesAdminController).ModelState.IsValid)
    {
      slide = model.ToEntity(slide);
      slide.SlideType = model.Type;
      await slidesAdminController._sliderService.UpdateSlideAsync(slide);
      await slidesAdminController.UpdateLocalesAsync(slide, (ILocalizedModel<SlideLocalizedModel>) model);
      // ISSUE: reference to a compiler-generated field
      if (SlidesAdminController.\u003C\u003Eo__11.\u003C\u003Ep__0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        SlidesAdminController.\u003C\u003Eo__11.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "RefreshPage", typeof (SlidesAdminController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      object obj1 = SlidesAdminController.\u003C\u003Eo__11.\u003C\u003Ep__0.Target((CallSite) SlidesAdminController.\u003C\u003Eo__11.\u003C\u003Ep__0, ((Controller) slidesAdminController).ViewBag, true);
      // ISSUE: reference to a compiler-generated field
      if (SlidesAdminController.\u003C\u003Eo__11.\u003C\u003Ep__1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        SlidesAdminController.\u003C\u003Eo__11.\u003C\u003Ep__1 = CallSite<Func<CallSite, object, StringValues, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "btnId", typeof (SlidesAdminController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      object obj2 = SlidesAdminController.\u003C\u003Eo__11.\u003C\u003Ep__1.Target((CallSite) SlidesAdminController.\u003C\u003Eo__11.\u003C\u003Ep__1, ((Controller) slidesAdminController).ViewBag, ((ControllerBase) slidesAdminController).Request.Form["refreshButtonId"]);
    }
    model = await slidesAdminController._slideAdminModelFactory.PrepareSlideModelAsync(slide);
    ActionResult actionResult = (ActionResult) ((Controller) slidesAdminController).View("EditSlide", (object) model);
    slide = (Slide) null;
    return actionResult;
  }

  [NonAction]
  private async Task UpdateLocalesAsync(Slide slide, ILocalizedModel<SlideLocalizedModel> model)
  {
    foreach (SlideLocalizedModel localized in (IEnumerable<SlideLocalizedModel>) model.Locales)
    {
      await this._localizedEntityService.SaveLocalizedValueAsync<Slide>(slide, (Expression<Func<Slide, string>>) (x => x.Url), localized.Url, localized.LanguageId);
      await this._localizedEntityService.SaveLocalizedValueAsync<Slide>(slide, (Expression<Func<Slide, string>>) (x => x.Alt), localized.Alt, localized.LanguageId);
    }
  }
}
