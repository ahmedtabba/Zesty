// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Models.Sliders.SliderImageLocalizedModel
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Nop.Web.Framework.Models;

#nullable disable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Models.Sliders;

public class SliderImageLocalizedModel : ILocalizedLocaleModel
{
  public int LanguageId { get; set; }

  public string Url { get; set; }

  public string MobileUrl { get; set; }

  public string Alt { get; set; }

  public string DisplayText { get; set; }
}
