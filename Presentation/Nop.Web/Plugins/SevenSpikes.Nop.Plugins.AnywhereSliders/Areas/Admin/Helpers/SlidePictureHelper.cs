// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Helpers.SlidePictureHelper
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Nop.Core.Domain.Customers;
using Nop.Core.Domain.Media;
using Nop.Services.Logging;
using Nop.Services.Media;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.Sliders;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Services;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable enable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Helpers;

public class SlidePictureHelper : ISlidePictureHelper
{
  private readonly 
  #nullable disable
  ILogger _logger;
  private readonly IPictureService _pictureService;
  private readonly ISliderService _sliderService;

  public SlidePictureHelper(
    ILogger logger,
    IPictureService pictureService,
    ISliderService sliderService)
  {
    this._logger = logger;
    this._pictureService = pictureService;
    this._sliderService = sliderService;
  }

  public async Task<Dictionary<string, string>> GetPictureDimensionsAsync(int pictureId)
  {
    Dictionary<string, string> emptyResult = new Dictionary<string, string>()
    {
      {
        "height",
        "0px"
      },
      {
        "width",
        "0px"
      }
    };
    Picture pictureByIdAsync = await this._pictureService.GetPictureByIdAsync(pictureId);
    if (pictureByIdAsync == null)
      return emptyResult;
    byte[] numArray = await this._pictureService.LoadPictureBinaryAsync(pictureByIdAsync);
    if (numArray.Length == 0)
      return emptyResult;
    int num;
    try
    {
      using (SKBitmap skBitmap = SKBitmap.Decode(numArray))
        return new Dictionary<string, string>()
        {
          {
            "height",
            skBitmap.Height.ToString() + "px"
          },
          {
            "width",
            skBitmap.Width.ToString() + "px"
          }
        };
    }
    catch (Exception ex)
    {
      num = 1;
    }
    if (num == 1)
    {
      Exception exception = ex;
      await this._logger.ErrorAsync(exception.Message, exception, (Customer) null);
      return emptyResult;
    }
    emptyResult = (Dictionary<string, string>) null;
    Dictionary<string, string> pictureDimensionsAsync;
    return pictureDimensionsAsync;
  }

  public async Task DeleteSlidePicturesAsync(Slide slide)
  {
    if ((await this._sliderService.GetAllSlidesBySliderIdAsync(slide.SliderId)).All<Slide>((Func<Slide, bool>) (i => i.PictureId != slide.PictureId)))
    {
      Picture pictureByIdAsync = await this._pictureService.GetPictureByIdAsync(slide.PictureId);
      if (pictureByIdAsync != null)
        await this._pictureService.DeletePictureAsync(pictureByIdAsync);
    }
    if (!(await this._sliderService.GetAllSlidesBySliderIdAsync(slide.SliderId)).All<Slide>((Func<Slide, bool>) (i => i.MobilePictureId != slide.MobilePictureId)))
      ;
    else
    {
      Picture pictureByIdAsync = await this._pictureService.GetPictureByIdAsync(slide.MobilePictureId);
      if (pictureByIdAsync == null)
        ;
      else
        await this._pictureService.DeletePictureAsync(pictureByIdAsync);
    }
  }
}
