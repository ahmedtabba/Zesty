// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Extensions.MappingExtensions
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using SevenSpikes.Nop.Framework.AutoMapper;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Sliders;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.Sliders;

#nullable disable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Extensions;

public static class MappingExtensions
{
  public static SlideModel ToModel(this Slide entity)
  {
    return AutoMapperConfiguration7Spikes.MapTo<Slide, SlideModel>(entity);
  }

  public static Slide ToEntity(this SlideModel model)
  {
    return AutoMapperConfiguration7Spikes.MapTo<SlideModel, Slide>(model);
  }

  public static Slide ToEntity(this SlideModel model, Slide destination)
  {
    return AutoMapperConfiguration7Spikes.MapTo<SlideModel, Slide>(model, destination);
  }

  public static SliderModel ToModel(this Slider entity)
  {
    return AutoMapperConfiguration7Spikes.MapTo<Slider, SliderModel>(entity);
  }

  public static Slider ToEntity(this SliderModel model)
  {
    return AutoMapperConfiguration7Spikes.MapTo<SliderModel, Slider>(model);
  }

  public static Slider ToEntity(this SliderModel model, Slider destination)
  {
    return AutoMapperConfiguration7Spikes.MapTo<SliderModel, Slider>(model, destination);
  }
}
