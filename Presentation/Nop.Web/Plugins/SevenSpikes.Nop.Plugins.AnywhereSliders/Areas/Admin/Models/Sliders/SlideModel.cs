// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Sliders.SlideModel
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

#nullable enable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Sliders;

public record SlideModel : BaseNopEntityModel, ILocalizedModel<
#nullable disable
SlideLocalizedModel>, ILocalizedModel
{
  public SlideModel()
  {
    this.Locales = (IList<SlideLocalizedModel>) new List<SlideLocalizedModel>();
    this.AvailableTypes = (IList<SelectListItem>) new List<SelectListItem>();
    this.Visible = true;
  }

  public int SliderId { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slide.Type")]
  public SlideType Type { get; set; }

  public IList<SelectListItem> AvailableTypes { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slide.SystemName")]
  public string SystemName { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slide.Url")]
  public string Url { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slide.Alt")]
  public string Alt { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slide.Visible")]
  public bool Visible { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slide.DisplayOrder")]
  public int DisplayOrder { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slide.Picture")]
  [UIHint("Picture")]
  public int PictureId { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slide.Url")]
  public string PictureUrl { get; set; }
  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slide.PictureProduct")]
  [UIHint("Picture")]
  public int PictureProductId { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slide.Product.Url")]
  public string PictureProductUrl { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slide.MobilePicture")]
  [UIHint("Picture")]
  public int MobilePictureId { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slide.MobilePictureUrl")]
  [UIHint("Picture")]
  public string MobilePictureUrl { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slide.Content")]
  public string Content { get; set; }

  public string PictureHeight { get; set; }

  public string PictureWidth { get; set; }

  public string MobilePictureHeight { get; set; }

  public string MobilePictureWidth { get; set; }

  public IList<SlideLocalizedModel> Locales { get; set; }

  [CompilerGenerated]
  public virtual 
  #nullable enable
  string ToString()
  {
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append(nameof (SlideModel));
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
    builder.Append("SliderId = ");
    builder.Append(this.SliderId.ToString());
    builder.Append(", Type = ");
    builder.Append(this.Type.ToString());
    builder.Append(", AvailableTypes = ");
    builder.Append((object) this.AvailableTypes);
    builder.Append(", SystemName = ");
    builder.Append((object) this.SystemName);
    builder.Append(", Url = ");
    builder.Append((object) this.Url);
    builder.Append(", Alt = ");
    builder.Append((object) this.Alt);
    builder.Append(", Visible = ");
    builder.Append(this.Visible.ToString());
    builder.Append(", DisplayOrder = ");
    builder.Append(this.DisplayOrder.ToString());
    builder.Append(", PictureId = ");
    builder.Append(this.PictureId.ToString());
    builder.Append(", PictureUrl = ");
    builder.Append((object) this.PictureUrl);
    builder.Append(", MobilePictureId = ");
    builder.Append(this.MobilePictureId.ToString());
    builder.Append(", MobilePictureUrl = ");
    builder.Append((object) this.MobilePictureUrl);
    builder.Append(", Content = ");
    builder.Append((object) this.Content);
    builder.Append(", PictureHeight = ");
    builder.Append((object) this.PictureHeight);
    builder.Append(", PictureWidth = ");
    builder.Append((object) this.PictureWidth);
    builder.Append(", MobilePictureHeight = ");
    builder.Append((object) this.MobilePictureHeight);
    builder.Append(", MobilePictureWidth = ");
    builder.Append((object) this.MobilePictureWidth);
    builder.Append(", Locales = ");
    builder.Append((object) this.Locales);
    return true;
  }

  [CompilerGenerated]
  public virtual int GetHashCode()
  {
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    return (((((((((((((((((base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.\u003CSliderId\u003Ek__BackingField)) * -1521134295 + EqualityComparer<SlideType>.Default.GetHashCode(this.\u003CType\u003Ek__BackingField)) * -1521134295 + EqualityComparer<IList<SelectListItem>>.Default.GetHashCode(this.\u003CAvailableTypes\u003Ek__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CSystemName\u003Ek__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CUrl\u003Ek__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CAlt\u003Ek__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.\u003CVisible\u003Ek__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.\u003CDisplayOrder\u003Ek__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.\u003CPictureId\u003Ek__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CPictureUrl\u003Ek__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.\u003CMobilePictureId\u003Ek__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CMobilePictureUrl\u003Ek__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CContent\u003Ek__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CPictureHeight\u003Ek__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CPictureWidth\u003Ek__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CMobilePictureHeight\u003Ek__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CMobilePictureWidth\u003Ek__BackingField)) * -1521134295 + EqualityComparer<IList<SlideLocalizedModel>>.Default.GetHashCode(this.\u003CLocales\u003Ek__BackingField);
  }

  [CompilerGenerated]
  public virtual bool Equals(BaseNopEntityModel? other) => ((object) this).Equals((object) other);

  [CompilerGenerated]
  public virtual bool Equals(SlideModel? other)
  {
    if ((object) this == (object) other)
      return true;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    return base.Equals((BaseNopEntityModel) other) && EqualityComparer<int>.Default.Equals(this.\u003CSliderId\u003Ek__BackingField, other.\u003CSliderId\u003Ek__BackingField) && EqualityComparer<SlideType>.Default.Equals(this.\u003CType\u003Ek__BackingField, other.\u003CType\u003Ek__BackingField) && EqualityComparer<IList<SelectListItem>>.Default.Equals(this.\u003CAvailableTypes\u003Ek__BackingField, other.\u003CAvailableTypes\u003Ek__BackingField) && EqualityComparer<string>.Default.Equals(this.\u003CSystemName\u003Ek__BackingField, other.\u003CSystemName\u003Ek__BackingField) && EqualityComparer<string>.Default.Equals(this.\u003CUrl\u003Ek__BackingField, other.\u003CUrl\u003Ek__BackingField) && EqualityComparer<string>.Default.Equals(this.\u003CAlt\u003Ek__BackingField, other.\u003CAlt\u003Ek__BackingField) && EqualityComparer<bool>.Default.Equals(this.\u003CVisible\u003Ek__BackingField, other.\u003CVisible\u003Ek__BackingField) && EqualityComparer<int>.Default.Equals(this.\u003CDisplayOrder\u003Ek__BackingField, other.\u003CDisplayOrder\u003Ek__BackingField) && EqualityComparer<int>.Default.Equals(this.\u003CPictureId\u003Ek__BackingField, other.\u003CPictureId\u003Ek__BackingField) && EqualityComparer<string>.Default.Equals(this.\u003CPictureUrl\u003Ek__BackingField, other.\u003CPictureUrl\u003Ek__BackingField) && EqualityComparer<int>.Default.Equals(this.\u003CMobilePictureId\u003Ek__BackingField, other.\u003CMobilePictureId\u003Ek__BackingField) && EqualityComparer<string>.Default.Equals(this.\u003CMobilePictureUrl\u003Ek__BackingField, other.\u003CMobilePictureUrl\u003Ek__BackingField) && EqualityComparer<string>.Default.Equals(this.\u003CContent\u003Ek__BackingField, other.\u003CContent\u003Ek__BackingField) && EqualityComparer<string>.Default.Equals(this.\u003CPictureHeight\u003Ek__BackingField, other.\u003CPictureHeight\u003Ek__BackingField) && EqualityComparer<string>.Default.Equals(this.\u003CPictureWidth\u003Ek__BackingField, other.\u003CPictureWidth\u003Ek__BackingField) && EqualityComparer<string>.Default.Equals(this.\u003CMobilePictureHeight\u003Ek__BackingField, other.\u003CMobilePictureHeight\u003Ek__BackingField) && EqualityComparer<string>.Default.Equals(this.\u003CMobilePictureWidth\u003Ek__BackingField, other.\u003CMobilePictureWidth\u003Ek__BackingField) && EqualityComparer<IList<SlideLocalizedModel>>.Default.Equals(this.\u003CLocales\u003Ek__BackingField, other.\u003CLocales\u003Ek__BackingField);
  }

  [CompilerGenerated]
  protected SlideModel(SlideModel original)
    : base((BaseNopEntityModel) original)
  {
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CSliderId\u003Ek__BackingField = original.\u003CSliderId\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CType\u003Ek__BackingField = original.\u003CType\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CAvailableTypes\u003Ek__BackingField = original.\u003CAvailableTypes\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CSystemName\u003Ek__BackingField = original.\u003CSystemName\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CUrl\u003Ek__BackingField = original.\u003CUrl\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CAlt\u003Ek__BackingField = original.\u003CAlt\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CVisible\u003Ek__BackingField = original.\u003CVisible\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CDisplayOrder\u003Ek__BackingField = original.\u003CDisplayOrder\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CPictureId\u003Ek__BackingField = original.\u003CPictureId\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CPictureUrl\u003Ek__BackingField = original.\u003CPictureUrl\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CMobilePictureId\u003Ek__BackingField = original.\u003CMobilePictureId\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CMobilePictureUrl\u003Ek__BackingField = original.\u003CMobilePictureUrl\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CContent\u003Ek__BackingField = original.\u003CContent\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CPictureHeight\u003Ek__BackingField = original.\u003CPictureHeight\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CPictureWidth\u003Ek__BackingField = original.\u003CPictureWidth\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CMobilePictureHeight\u003Ek__BackingField = original.\u003CMobilePictureHeight\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CMobilePictureWidth\u003Ek__BackingField = original.\u003CMobilePictureWidth\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CLocales\u003Ek__BackingField = original.\u003CLocales\u003Ek__BackingField;
  }
}
