// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Widget.ConfigureWidgetModel
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
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Widget;

public record ConfigureWidgetModel() : BaseNopModel
{
  public int WidgetId { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Widget.Slider")]
  public int SliderId { get; set; }

  public 
  #nullable disable
  SelectList Sliders { get; set; }

  [CompilerGenerated]
  public virtual 
  #nullable enable
  string ToString()
  {
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append(nameof (ConfigureWidgetModel));
    stringBuilder.Append(" { ");
    if (base.PrintMembers(stringBuilder))
      stringBuilder.Append(' ');
    stringBuilder.Append('}');
    return stringBuilder.ToString();
  }

  [CompilerGenerated]
  protected virtual bool PrintMembers(StringBuilder builder)
  {
    if (base.PrintMembers(builder))
      builder.Append(", ");
    builder.Append("WidgetId = ");
    builder.Append(this.WidgetId.ToString());
    builder.Append(", SliderId = ");
    builder.Append(this.SliderId.ToString());
    builder.Append(", Sliders = ");
    builder.Append((object) this.Sliders);
    return true;
  }

  [CompilerGenerated]
  public virtual int GetHashCode()
  {
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    return ((base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.\u003CWidgetId\u003Ek__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.\u003CSliderId\u003Ek__BackingField)) * -1521134295 + EqualityComparer<SelectList>.Default.GetHashCode(this.\u003CSliders\u003Ek__BackingField);
  }

  [CompilerGenerated]
  public virtual bool Equals(BaseNopModel? other) => ((object) this).Equals((object) other);

  [CompilerGenerated]
  public virtual bool Equals(ConfigureWidgetModel? other)
  {
    if ((object) this == (object) other)
      return true;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    return base.Equals((BaseNopModel) other) && EqualityComparer<int>.Default.Equals(this.\u003CWidgetId\u003Ek__BackingField, other.\u003CWidgetId\u003Ek__BackingField) && EqualityComparer<int>.Default.Equals(this.\u003CSliderId\u003Ek__BackingField, other.\u003CSliderId\u003Ek__BackingField) && EqualityComparer<SelectList>.Default.Equals(this.\u003CSliders\u003Ek__BackingField, other.\u003CSliders\u003Ek__BackingField);
  }

  [CompilerGenerated]
  protected ConfigureWidgetModel(ConfigureWidgetModel original)
    : base((BaseNopModel) original)
  {
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CWidgetId\u003Ek__BackingField = original.\u003CWidgetId\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CSliderId\u003Ek__BackingField = original.\u003CSliderId\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CSliders\u003Ek__BackingField = original.\u003CSliders\u003Ek__BackingField;
  }
}
