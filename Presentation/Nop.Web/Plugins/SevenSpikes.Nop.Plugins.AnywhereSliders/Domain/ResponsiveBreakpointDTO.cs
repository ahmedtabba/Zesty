// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.ResponsiveBreakpointDTO
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Newtonsoft.Json;

#nullable disable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Domain;

public class ResponsiveBreakpointDTO
{
  [JsonProperty("breakpoint")]
  public int Breakpoint { get; set; }
}
