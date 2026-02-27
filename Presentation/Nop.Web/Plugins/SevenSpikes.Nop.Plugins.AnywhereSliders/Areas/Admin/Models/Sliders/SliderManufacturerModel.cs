// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Sliders.SliderManufacturerModel
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Nop.Web.Framework.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

#nullable disable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Sliders;

public class SliderManufacturerModel
{
  public int Id { get; set; }

  [NopResourceDisplayName("Admin.Catalog.Products.Manufacturers.Fields.Manufacturer")]
  [UIHint("ManufacturerMapping")]
  public string Manufacturer { get; set; }

  public int SliderId { get; set; }

  public int ManufacturerId { get; set; }
}
