// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Helpers.CustomCssHelper
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Microsoft.AspNetCore.Hosting;
using Nop.Core;
using Nop.Core.Domain.Stores;
using Nop.Core.Infrastructure;
using Nop.Services.Common;
using Nop.Services.Configuration;
using Nop.Services.Stores;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.Sliders;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

#nullable enable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Helpers;

public class CustomCssHelper : ICustomCssHelper
{
  private const 
  #nullable disable
  string STORE_CUSTOM_CSS_GENERIC_ATTRIBUTE_KEY = "AnywhereSliders.Store.CustomCss";
  private const string SLIDER_CUSTOM_CSS_GENERIC_ATTRIBUTE_KEY = "AnywhereSliders.Slider.CustomCss";
  private readonly IStoreService _storeService;
  private readonly ISliderService _sliderService;
  private readonly IStoreMappingService _storeMappingService;
  private readonly IGenericAttributeService _genericAttributeService;
  private readonly ISettingService _settingService;
  private readonly IWebHostEnvironment _webHostEnvironment;
  private readonly INopFileProvider _nopFileProvider;
  private readonly IStoreContext _storeContext;

  public CustomCssHelper(
    IStoreService storeService,
    ISliderService sliderService,
    IStoreMappingService storeMappingService,
    IGenericAttributeService genericAttributeService,
    ISettingService settingService,
    IWebHostEnvironment webHostEnvironment,
    INopFileProvider nopFileProvider,
    IStoreContext storeContext)
  {
    this._storeService = storeService;
    this._sliderService = sliderService;
    this._storeMappingService = storeMappingService;
    this._genericAttributeService = genericAttributeService;
    this._settingService = settingService;
    this._webHostEnvironment = webHostEnvironment;
    this._nopFileProvider = nopFileProvider;
    this._storeContext = storeContext;
  }

  public async Task SaveCustomCssAsync(Slider slider, string customCss)
  {
    await this._genericAttributeService.SaveAttributeAsync<string>((BaseEntity) slider, "AnywhereSliders.Slider.CustomCss", customCss, 0);
    await this.WriteCustomCssToFileAsync();
  }

  public async Task<string> GetCustomCssAsync(Slider slider)
  {
    string attributeAsync = await this._genericAttributeService.GetAttributeAsync<string>((BaseEntity) slider, "AnywhereSliders.Slider.CustomCss", 0, (string) null);
    return string.IsNullOrEmpty(attributeAsync) ? string.Empty : attributeAsync;
  }

  public async Task WriteCustomCssToFileAsync()
  {
    foreach (Store store in (IEnumerable<Store>) await this._storeService.GetAllStoresAsync())
    {
      string customCss = await this.GetCustomCssAsync(((BaseEntity) store).Id);
      string fileNameAsync = await this.GetFileNameAsync(((BaseEntity) store).Id);
      await this.SaveCustomCssToFileAsync(this._nopFileProvider.Combine(new string[2]
      {
        this.GetFolderPath(),
        fileNameAsync
      }), customCss, ((BaseEntity) store).Id);
      await this._genericAttributeService.SaveAttributeAsync<string>((BaseEntity) store, "AnywhereSliders.Store.CustomCss", customCss, ((BaseEntity) store).Id);
      customCss = (string) null;
    }
  }

  private async Task<string> GetCustomCssAsync(int storeId)
  {
    string customCss = string.Empty;
    foreach (Slider slider1 in (IEnumerable<Slider>) await this._sliderService.GetAllSlidersAsync())
    {
      Slider slider = slider1;
      IList<StoreMapping> storeMappingsAsync = await this._storeMappingService.GetStoreMappingsAsync<Slider>(slider);
      if (storeMappingsAsync.Count <= 0 || storeMappingsAsync.FirstOrDefault<StoreMapping>((Func<StoreMapping, bool>) (x => x.StoreId == storeId)) != null)
      {
        string attributeAsync = await this._genericAttributeService.GetAttributeAsync<string>((BaseEntity) slider, "AnywhereSliders.Slider.CustomCss", 0, string.Empty);
        if (!string.IsNullOrEmpty(customCss))
          customCss += Environment.NewLine;
        customCss += attributeAsync;
        slider = (Slider) null;
      }
    }
    string customCssAsync = customCss;
    customCss = (string) null;
    return customCssAsync;
  }

  public async Task<string> GetFileNameAsync(int storeId)
  {
    int fileVersion = await this._settingService.GetSettingByKeyAsync<int>("AnywhereSliderSettings.CustomCssFileVersion", 0, storeId, false);
    if (fileVersion == 0)
    {
      fileVersion = 1;
      await this._settingService.SetSettingAsync<int>("AnywhereSliderSettings.CustomCssFileVersion", fileVersion, storeId, true);
    }
    return $"anywhereSlidersCustomCss-{storeId}-{fileVersion}.css";
  }

  public string GetFolderPath()
  {
    return this._nopFileProvider.Combine(new string[3]
    {
      this._webHostEnvironment.WebRootPath,
      "css",
      "Slick"
    });
  }

  private async Task SaveCustomCssToFileAsync(string fullPath, string customCss, int storeId)
  {
    if (!this._nopFileProvider.DirectoryExists(this.GetFolderPath()))
      this._nopFileProvider.CreateDirectory(this.GetFolderPath());
    if (await this._settingService.GetSettingByKeyAsync<bool>("AnywhereSliderSettings.DoNotUseCustomCSSInAnywhereSliders", false, storeId, true))
      return;
    using (FileStream fileStream = new FileStream(fullPath, FileMode.Create))
    {
      using (StreamWriter streamWriter = new StreamWriter((Stream) fileStream))
      {
        streamWriter.Write(customCss);
        streamWriter.Close();
      }
      fileStream.Close();
    }
  }
}
