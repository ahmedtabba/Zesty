// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Sliders.SliderToWidgetModel
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

#nullable enable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Sliders;

public record SliderToWidgetModel() : BaseNopEntityModel
{
  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Widget.WidgetZone")]
  public 
  #nullable disable
  string WidgetZone { get; set; }

  public SelectList SupportedWidgetZones { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Widget.DisplayOrder")]
  public int DisplayOrder { get; set; }

  [CompilerGenerated]
  public virtual 
  #nullable enable
  string ToString()
  {
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append(nameof (SliderToWidgetModel));
    stringBuilder.Append(" { ");
    if (((BaseNopModel) this).PrintMembers(stringBuilder))
      stringBuilder.Append(' ');
    stringBuilder.Append('}');
    return stringBuilder.ToString();
  }

  [CompilerGenerated]
  protected virtual bool PrintMembers(StringBuilder builder)
  {
    if (base.PrintMembers(builder))
      builder.Append(", ");
    builder.Append("WidgetZone = ");
    builder.Append((object) this.WidgetZone);
    builder.Append(", SupportedWidgetZones = ");
    builder.Append((object) this.SupportedWidgetZones);
    builder.Append(", DisplayOrder = ");
    builder.Append(this.DisplayOrder.ToString());
    return true;
  }

  [CompilerGenerated]
  public virtual int GetHashCode()
  {
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    return ((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CWidgetZone\u003Ek__BackingField)) * -1521134295 + EqualityComparer<SelectList>.Default.GetHashCode(this.\u003CSupportedWidgetZones\u003Ek__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.\u003CDisplayOrder\u003Ek__BackingField);
  }

  [CompilerGenerated]
  public virtual bool Equals(BaseNopEntityModel? other) => ((object) this).Equals((object) other);

  [CompilerGenerated]
  public virtual bool Equals(SliderToWidgetModel? other)
  {
    if ((object) this == (object) other)
      return true;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    return base.Equals((BaseNopEntityModel) other) && EqualityComparer<string>.Default.Equals(this.\u003CWidgetZone\u003Ek__BackingField, other.\u003CWidgetZone\u003Ek__BackingField) && EqualityComparer<SelectList>.Default.Equals(this.\u003CSupportedWidgetZones\u003Ek__BackingField, other.\u003CSupportedWidgetZones\u003Ek__BackingField) && EqualityComparer<int>.Default.Equals(this.\u003CDisplayOrder\u003Ek__BackingField, other.\u003CDisplayOrder\u003Ek__BackingField);
  }

  [CompilerGenerated]
  protected SliderToWidgetModel(SliderToWidgetModel original)
    : base((BaseNopEntityModel) original)
  {
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CWidgetZone\u003Ek__BackingField = original.\u003CWidgetZone\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CSupportedWidgetZones\u003Ek__BackingField = original.\u003CSupportedWidgetZones\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CDisplayOrder\u003Ek__BackingField = original.\u003CDisplayOrder\u003Ek__BackingField;
  }
}
