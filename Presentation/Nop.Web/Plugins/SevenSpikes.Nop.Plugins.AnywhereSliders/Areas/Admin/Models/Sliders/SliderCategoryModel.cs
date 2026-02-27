// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Sliders.SliderCategoryModel
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

#nullable enable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Sliders;

public record SliderCategoryModel() : BaseNopEntityModel
{
  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Category.DisplayText.Category")]
  [UIHint("SliderCategory")]
  public 
  #nullable disable
  string Category { get; set; }

  public int SliderId { get; set; }

  public int CategoryId { get; set; }

  [CompilerGenerated]
  public virtual 
  #nullable enable
  string ToString()
  {
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append(nameof (SliderCategoryModel));
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
    builder.Append("Category = ");
    builder.Append((object) this.Category);
    builder.Append(", SliderId = ");
    builder.Append(this.SliderId.ToString());
    builder.Append(", CategoryId = ");
    builder.Append(this.CategoryId.ToString());
    return true;
  }

  [CompilerGenerated]
  public virtual int GetHashCode()
  {
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    return ((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CCategory\u003Ek__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.\u003CSliderId\u003Ek__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.\u003CCategoryId\u003Ek__BackingField);
  }

  [CompilerGenerated]
  public virtual bool Equals(BaseNopEntityModel? other) => ((object) this).Equals((object) other);

  [CompilerGenerated]
  public virtual bool Equals(SliderCategoryModel? other)
  {
    if ((object) this == (object) other)
      return true;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    return base.Equals((BaseNopEntityModel) other) && EqualityComparer<string>.Default.Equals(this.\u003CCategory\u003Ek__BackingField, other.\u003CCategory\u003Ek__BackingField) && EqualityComparer<int>.Default.Equals(this.\u003CSliderId\u003Ek__BackingField, other.\u003CSliderId\u003Ek__BackingField) && EqualityComparer<int>.Default.Equals(this.\u003CCategoryId\u003Ek__BackingField, other.\u003CCategoryId\u003Ek__BackingField);
  }

  [CompilerGenerated]
  protected SliderCategoryModel(SliderCategoryModel original)
    : base((BaseNopEntityModel) original)
  {
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CCategory\u003Ek__BackingField = original.\u003CCategory\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CSliderId\u003Ek__BackingField = original.\u003CSliderId\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CCategoryId\u003Ek__BackingField = original.\u003CCategoryId\u003Ek__BackingField;
  }
}
