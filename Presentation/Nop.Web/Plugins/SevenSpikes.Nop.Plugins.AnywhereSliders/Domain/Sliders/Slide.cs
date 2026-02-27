// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.Sliders.Slide
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Nop.Core;
using Nop.Core.Domain.Localization;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.Enums;

#nullable disable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.Sliders;

public class Slide : BaseEntity, ILocalizedEntity
{
  public string SystemName { get; set; }

  public string Url { get; set; }

  public string Alt { get; set; }

  public bool Visible { get; set; }

  public int DisplayOrder { get; set; }

  public int PictureId { get; set; }

  public int MobilePictureId { get; set; }

  public string Content { get; set; }

  public SlideType SlideType { get; set; }

  public int SliderId { get; set; }
}
