// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Infrastructure.DependancyRegistrar
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Microsoft.Extensions.DependencyInjection;
using SevenSpikes.Nop.Framework.DependancyRegistrar;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Factories;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Helpers;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Sliders;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.Sliders;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Helpers;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Services;

#nullable disable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Infrastructure;

public class DependancyRegistrar : BaseDependancyRegistrar7Spikes
{
  protected virtual void CreateModelMappings()
  {
    this.CreateMvcModelMap<SlideModel, Slide>();
    this.CreateMvcModelMap<SliderModel, Slider>();
  }

  protected virtual void RegisterPluginServices(IServiceCollection services)
  {
    services.AddTransient<ISliderService, SliderService>();
    services.AddTransient<ISlideAdminModelFactory, SlideAdminModelFactory>();
    services.AddTransient<ISliderAdminModelFactory, SliderAdminModelFactory>();
    services.AddTransient<ISlidePictureHelper, SlidePictureHelper>();
    services.AddTransient<ICustomCssHelper, CustomCssHelper>();
  }
}
