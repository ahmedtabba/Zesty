// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Sliders.SliderSearchModel
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

#nullable enable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Sliders;

public record SliderSearchModel() : BaseSearchModel
{
  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.List.Search.FieldTitle")]
  public 
  #nullable disable
  string SearchSliderName { get; set; }

  [CompilerGenerated]
  public virtual 
  #nullable enable
  string ToString()
  {
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append(nameof (SliderSearchModel));
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
    builder.Append("SearchSliderName = ");
    builder.Append((object) this.SearchSliderName);
    return true;
  }

  [CompilerGenerated]
  public virtual int GetHashCode()
  {
    // ISSUE: reference to a compiler-generated field
    return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CSearchSliderName\u003Ek__BackingField);
  }

  [CompilerGenerated]
  public virtual bool Equals(BaseSearchModel? other) => ((object) this).Equals((object) other);

  [CompilerGenerated]
  public virtual bool Equals(SliderSearchModel? other)
  {
    if ((object) this == (object) other)
      return true;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    return base.Equals((BaseSearchModel) other) && EqualityComparer<string>.Default.Equals(this.\u003CSearchSliderName\u003Ek__BackingField, other.\u003CSearchSliderName\u003Ek__BackingField);
  }

  [CompilerGenerated]
  protected SliderSearchModel(SliderSearchModel original)
    : base((BaseSearchModel) original)
  {
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CSearchSliderName\u003Ek__BackingField = original.\u003CSearchSliderName\u003Ek__BackingField;
  }
}
