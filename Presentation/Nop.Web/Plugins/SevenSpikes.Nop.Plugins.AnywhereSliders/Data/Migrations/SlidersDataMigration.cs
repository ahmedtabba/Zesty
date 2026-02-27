// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Data.Migrations.SlidersDataMigration
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using FluentMigrator;
using Nop.Data.Migrations;
using SevenSpikes.Nop.EntitySettings.Services.EntitySettings;
using SevenSpikes.Nop.Framework.Domain.Enums;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.Sliders;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Data.Migrations;

[NopMigration]
public class SlidersDataMigration : AutoReversingMigration
{
  protected 
  #nullable disable
  IMigrationManager _migrationManager;
  private readonly IEntitySettingService _entitySettingService;
  private readonly ISliderService _sliderService;

  public SlidersDataMigration(
    IMigrationManager migrationManager,
    IEntitySettingService entitySettingService,
    ISliderService sliderService)
  {
    this._migrationManager = migrationManager;
    this._entitySettingService = entitySettingService;
    this._sliderService = sliderService;
  }

  public virtual void Up()
  {
    this.UpdateSlidersDataAsync().Wait();
    this.FillSlidesSystemNameAsync().Wait();
  }

  public async Task UpdateSlidersDataAsync()
  {
    foreach (Slider slider in (IEnumerable<Slider>) await this._sliderService.GetAllSlidersAsync())
    {
      int autoSlideInterval = await this._entitySettingService.GetEntitySettingByKeyAsync<int>("nivosettings.autoslideinterval", (EntityType) 15, slider.Id, 3000);
      int animationSpeed = await this._entitySettingService.GetEntitySettingByKeyAsync<int>("nivosettings.animationspeed", (EntityType) 15, slider.Id, 1000);
      bool controlNavigation = await this._entitySettingService.GetEntitySettingByKeyAsync<bool>("nivosettings.enablecontrolnavigation", (EntityType) 15, slider.Id, false);
      bool directionalNavigation = await this._entitySettingService.GetEntitySettingByKeyAsync<bool>("nivosettings.enabledirectionnavigation", (EntityType) 15, slider.Id, false);
      string settingByKeyAsync = await this._entitySettingService.GetEntitySettingByKeyAsync<string>("nivosettings.theme", (EntityType) 15, slider.Id, string.Empty);
      slider.Autoplay = true;
      slider.AutoplaySpeed = autoSlideInterval;
      slider.Speed = animationSpeed;
      slider.Fade = true;
      slider.Dots = controlNavigation;
      slider.Arrows = directionalNavigation;
      slider.MobileBreakpoint = 768 /*0x0300*/;
      slider.CustomClass = string.IsNullOrEmpty(settingByKeyAsync) ? string.Empty : "theme-" + settingByKeyAsync;
      await this._sliderService.UpdateSliderAsync(slider);
    }
  }

  public async Task FillSlidesSystemNameAsync()
  {
    foreach (Slide slide in (IEnumerable<Slide>) await this._sliderService.GetAllSlidesAsync())
    {
      if (string.IsNullOrEmpty(slide.SystemName))
      {
        slide.SystemName = slide.Id.ToString();
        await this._sliderService.UpdateSlideAsync(slide);
      }
    }
  }
}
