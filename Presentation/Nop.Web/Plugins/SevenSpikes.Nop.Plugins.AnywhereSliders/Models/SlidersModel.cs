// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Models.SlidersModel
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using System.Collections.Generic;

#nullable disable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Models;

public class SlidersModel
{
  public SlidersModel() => this.Sliders = (IList<SliderCachedModel>) new List<SliderCachedModel>();

  public string Theme { get; set; }

  public IList<SliderCachedModel> Sliders { get; set; }
}
