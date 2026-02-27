// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Data.Mapping.NameCompatability
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Nop.Data.Mapping;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.Sliders;
using System;
using System.Collections.Generic;

#nullable disable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Data.Mapping;

public class NameCompatability : INameCompatibility
{
  public Dictionary<Type, string> TableNames
  {
    get
    {
      return new Dictionary<Type, string>()
      {
        {
          typeof (Slide),
          "SS_AS_Slide"
        },
        {
          typeof (Slider),
          "SS_AS_AnywhereSlider"
        }
      };
    }
  }

  public Dictionary<(Type, string), string> ColumnName => new Dictionary<(Type, string), string>();
}
