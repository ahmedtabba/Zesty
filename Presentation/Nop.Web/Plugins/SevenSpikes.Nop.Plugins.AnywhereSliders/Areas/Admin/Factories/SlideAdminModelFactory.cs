// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Factories.SlideAdminModelFactory
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Core.Domain.Media;
using Nop.Services.Localization;
using Nop.Services.Media;
using Nop.Web.Framework.Factories;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Extensions;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Helpers;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Sliders;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.Sliders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

#nullable enable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Factories;

public class SlideAdminModelFactory : ISlideAdminModelFactory
{
  private readonly 
  #nullable disable
  IPictureService _pictureService;
  private readonly ILocalizationService _localizationService;
  private readonly ISlidePictureHelper _slidePictureHelper;
  private readonly ILocalizedModelFactory _localizedModelFactory;

  public SlideAdminModelFactory(
    IPictureService pictureService,
    ILocalizationService localizationService,
    ISlidePictureHelper slidePictureHelper,
    ILocalizedModelFactory localizedModelFactory)
  {
    this._pictureService = pictureService;
    this._localizationService = localizationService;
    this._slidePictureHelper = slidePictureHelper;
    this._localizedModelFactory = localizedModelFactory;
  }

  public IList<SlideModel> PrepareSlideListModel(IList<Slide> slides)
  {
    return (IList<SlideModel>) slides.Select<Slide, Task<SlideModel>>((Func<Slide, Task<SlideModel>>) (async x =>
    {
      int mobilePictureId = x.MobilePictureId == 0 ? x.PictureId : x.MobilePictureId;
      SlideModel slideModel1 = new SlideModel();
      slideModel1.Id = x.Id;
      slideModel1.DisplayOrder = x.DisplayOrder;
      slideModel1.SystemName = x.SystemName;
      slideModel1.Content = x.Content;
      slideModel1.Url = x.Url;
      slideModel1.Alt = x.Alt;
      slideModel1.PictureId = x.PictureId;
      slideModel1.PictureProductId = x.PictureProductId;
      slideModel1.MobilePictureId = mobilePictureId;
      SlideModel slideModel2 = slideModel1;
      slideModel2.PictureUrl = await this._pictureService.GetPictureUrlAsync(x.PictureId, 200, true, (string) null, (PictureType) 1);
      slideModel2.PictureProductUrl = await this._pictureService.GetPictureUrlAsync(x.PictureProductId, 200, true, (string) null, (PictureType) 1);
      SlideModel slideModel3 = slideModel1;
      slideModel3.MobilePictureUrl = await this._pictureService.GetPictureUrlAsync(mobilePictureId, 200, true, (string) null, (PictureType) 1);
      slideModel1.SliderId = x.SliderId;
      slideModel1.Visible = x.Visible;
      SlideModel slideModel4 = slideModel1;
      slideModel4.Locales = await this.PrepareLocalesAsync(x);
      SlideModel sliderImageModel = slideModel1;
      slideModel2 = (SlideModel) null;
      slideModel3 = (SlideModel) null;
      slideModel4 = (SlideModel) null;
      slideModel1 = (SlideModel) null;
      Dictionary<string, string> pictureDimensions = await this._slidePictureHelper.GetPictureDimensionsAsync(x.PictureId);
      Dictionary<string, string> mobilePictureDimensions = await this._slidePictureHelper.GetPictureDimensionsAsync(mobilePictureId);
      string resourceAsync = await this._localizationService.GetResourceAsync("SevenSpikes.Plugins.AnywhereSliders.Admin.SliderImage.ZeroPixelsDimension");
      sliderImageModel.PictureHeight = pictureDimensions.ContainsKey("height") ? pictureDimensions["height"] : resourceAsync;
      sliderImageModel.PictureWidth = pictureDimensions.ContainsKey("width") ? pictureDimensions["width"] : resourceAsync;
      sliderImageModel.MobilePictureHeight = mobilePictureDimensions.ContainsKey("height") ? mobilePictureDimensions["height"] : resourceAsync;
      sliderImageModel.MobilePictureWidth = mobilePictureDimensions.ContainsKey("width") ? mobilePictureDimensions["width"] : resourceAsync;
      SlideModel slideModel = sliderImageModel;
      sliderImageModel = (SlideModel) null;
      pictureDimensions = (Dictionary<string, string>) null;
      mobilePictureDimensions = (Dictionary<string, string>) null;
      return slideModel;
    })).Select<Task<SlideModel>, SlideModel>((Func<Task<SlideModel>, SlideModel>) (x => x.Result)).ToList<SlideModel>();
  }

  public async Task PrepareSlideModelAsync(SlideModel model)
  {
    SlideModel slideModel = model;
    slideModel.Locales = await this.PrepareLocalesAsync(new Slide());
    slideModel = (SlideModel) null;
    await this.AddAvailableTypesAsync(model);
  }

  public async Task<SlideModel> PrepareSlideModelAsync(Slide slide)
  {
    SlideModel model = slide.ToModel();
    model.Type = slide.SlideType;
    SlideModel slideModel = model;
    slideModel.Locales = await this.PrepareLocalesAsync(slide);
    slideModel = (SlideModel) null;
    await this.AddAvailableTypesAsync(model);
    SlideModel slideModel1 = model;
    model = (SlideModel) null;
    return slideModel1;
  }

  private async Task AddAvailableTypesAsync(SlideModel model)
  {
    IList<SelectListItem> selectListItemList = model.AvailableTypes;
    SelectListItem selectListItem1 = new SelectListItem();
    SelectListItem selectListItem2 = selectListItem1;
    selectListItem2.Text = await this._localizationService.GetResourceAsync("SevenSpikes.Plugins.AnywhereSliders.Admin.Slide.SlideTypeEnum.SelectType");
    selectListItem1.Value = "0";
    selectListItemList.Add(selectListItem1);
    selectListItemList = (IList<SelectListItem>) null;
    selectListItem2 = (SelectListItem) null;
    selectListItem1 = (SelectListItem) null;
    selectListItemList = model.AvailableTypes;
    selectListItem2 = new SelectListItem();
    selectListItem1 = selectListItem2;
    selectListItem1.Text = await this._localizationService.GetResourceAsync("SevenSpikes.Plugins.AnywhereSliders.Admin.Slide.SlideTypeEnum.Picture");
    selectListItem2.Value = 1.ToString();
    selectListItemList.Add(selectListItem2);
    selectListItemList = (IList<SelectListItem>) null;
    selectListItem1 = (SelectListItem) null;
    selectListItem2 = (SelectListItem) null;
    selectListItemList = model.AvailableTypes;
    selectListItem1 = new SelectListItem();
    selectListItem2 = selectListItem1;
    selectListItem2.Text = await this._localizationService.GetResourceAsync("SevenSpikes.Plugins.AnywhereSliders.Admin.Slide.SlideTypeEnum.Content");
    selectListItem1.Value = 5.ToString();
    selectListItemList.Add(selectListItem1);
    selectListItemList = (IList<SelectListItem>) null;
    selectListItem2 = (SelectListItem) null;
    selectListItem1 = (SelectListItem) null;
  }

  private async Task<IList<SlideLocalizedModel>> PrepareLocalesAsync(Slide slide)
  {
    return await this._localizedModelFactory.PrepareLocalizedModelsAsync<SlideLocalizedModel>((Func<SlideLocalizedModel, int, Task>) (async (locale, languageId) =>
    {
      SlideLocalizedModel slideLocalizedModel = locale;
      ILocalizationService localizationService1 = this._localizationService;
      Slide slide1 = slide;
      Expression<Func<Slide, string>> expression1 = (Expression<Func<Slide, string>>) (x => x.Url);
      int? nullable1 = new int?(languageId);
      slideLocalizedModel.Url = await localizationService1.GetLocalizedAsync<Slide, string>(slide1, expression1, nullable1, false, false);
      slideLocalizedModel = (SlideLocalizedModel) null;
      slideLocalizedModel = locale;
      ILocalizationService localizationService2 = this._localizationService;
      Slide slide2 = slide;
      Expression<Func<Slide, string>> expression2 = (Expression<Func<Slide, string>>) (x => x.Alt);
      int? nullable2 = new int?(languageId);
      slideLocalizedModel.Alt = await localizationService2.GetLocalizedAsync<Slide, string>(slide2, expression2, nullable2, false, false);
      slideLocalizedModel = (SlideLocalizedModel) null;
    }));
  }
}
