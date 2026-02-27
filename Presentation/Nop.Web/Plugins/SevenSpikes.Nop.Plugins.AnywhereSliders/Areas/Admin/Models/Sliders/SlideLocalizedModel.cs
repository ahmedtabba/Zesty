// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Sliders.SlideLocalizedModel
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

#nullable disable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Sliders;

public class SlideLocalizedModel : ILocalizedLocaleModel
{
  public int LanguageId { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slide.Url")]
  public string Url { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slide.Alt")]
  public string Alt { get; set; }
}
