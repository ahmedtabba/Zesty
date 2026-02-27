// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.Sliders.Slider
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Nop.Core;
using Nop.Core.Domain.Stores;

#nullable disable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.Sliders;

public class Slider : BaseEntity, IStoreMappingSupported
{
  public string SystemName { get; set; }

  public bool PreLoadFirstSlide { get; set; }

  public bool Autoplay { get; set; }

  public int AutoplaySpeed { get; set; }

  public int Speed { get; set; }

  public bool PauseOnHover { get; set; }

  public bool Fade { get; set; }

  public bool Dots { get; set; }

  public bool Arrows { get; set; }

  public int MobileBreakpoint { get; set; }

  public string CustomClass { get; set; }

  public int LanguageId { get; set; }

  public bool LimitedToStores { get; set; }
}
