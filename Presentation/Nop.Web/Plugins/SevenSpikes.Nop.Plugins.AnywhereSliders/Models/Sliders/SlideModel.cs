// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Models.Sliders.SlideModel
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Nop.Web.Framework.Models;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

#nullable enable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Models.Sliders;

public record SlideModel : 
  BaseNopEntityModel,
  ILocalizedModel<
  #nullable disable
  SliderImageLocalizedModel>,
  ILocalizedModel
{
  public SlideModel()
  {
    this.Locales = (IList<SliderImageLocalizedModel>) new List<SliderImageLocalizedModel>();
  }

  public string Url { get; set; }

  public string MobileUrl { get; set; }

  public string Alt { get; set; }

  public string PicturePath { get; set; }

  public string MobilePicturePath { get; set; }

  public string PictureThumbPath { get; set; }

  public string MobilePictureThumbPath { get; set; }

  public string DisplayText { get; set; }

  public IList<SliderImageLocalizedModel> Locales { get; set; }

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
    builder.Append("Url = ");
    builder.Append((object) this.Url);
    builder.Append(", MobileUrl = ");
    builder.Append((object) this.MobileUrl);
    builder.Append(", Alt = ");
    builder.Append((object) this.Alt);
    builder.Append(", PicturePath = ");
    builder.Append((object) this.PicturePath);
    builder.Append(", MobilePicturePath = ");
    builder.Append((object) this.MobilePicturePath);
    builder.Append(", PictureThumbPath = ");
    builder.Append((object) this.PictureThumbPath);
    builder.Append(", MobilePictureThumbPath = ");
    builder.Append((object) this.MobilePictureThumbPath);
    builder.Append(", DisplayText = ");
    builder.Append((object) this.DisplayText);
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
    return ((((((((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CUrl\u003Ek__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CMobileUrl\u003Ek__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CAlt\u003Ek__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CPicturePath\u003Ek__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CMobilePicturePath\u003Ek__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CPictureThumbPath\u003Ek__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CMobilePictureThumbPath\u003Ek__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CDisplayText\u003Ek__BackingField)) * -1521134295 + EqualityComparer<IList<SliderImageLocalizedModel>>.Default.GetHashCode(this.\u003CLocales\u003Ek__BackingField);
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
    return base.Equals((BaseNopEntityModel) other) && EqualityComparer<string>.Default.Equals(this.\u003CUrl\u003Ek__BackingField, other.\u003CUrl\u003Ek__BackingField) && EqualityComparer<string>.Default.Equals(this.\u003CMobileUrl\u003Ek__BackingField, other.\u003CMobileUrl\u003Ek__BackingField) && EqualityComparer<string>.Default.Equals(this.\u003CAlt\u003Ek__BackingField, other.\u003CAlt\u003Ek__BackingField) && EqualityComparer<string>.Default.Equals(this.\u003CPicturePath\u003Ek__BackingField, other.\u003CPicturePath\u003Ek__BackingField) && EqualityComparer<string>.Default.Equals(this.\u003CMobilePicturePath\u003Ek__BackingField, other.\u003CMobilePicturePath\u003Ek__BackingField) && EqualityComparer<string>.Default.Equals(this.\u003CPictureThumbPath\u003Ek__BackingField, other.\u003CPictureThumbPath\u003Ek__BackingField) && EqualityComparer<string>.Default.Equals(this.\u003CMobilePictureThumbPath\u003Ek__BackingField, other.\u003CMobilePictureThumbPath\u003Ek__BackingField) && EqualityComparer<string>.Default.Equals(this.\u003CDisplayText\u003Ek__BackingField, other.\u003CDisplayText\u003Ek__BackingField) && EqualityComparer<IList<SliderImageLocalizedModel>>.Default.Equals(this.\u003CLocales\u003Ek__BackingField, other.\u003CLocales\u003Ek__BackingField);
  }

  [CompilerGenerated]
  protected SlideModel(SlideModel original)
    : base((BaseNopEntityModel) original)
  {
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CUrl\u003Ek__BackingField = original.\u003CUrl\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CMobileUrl\u003Ek__BackingField = original.\u003CMobileUrl\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CAlt\u003Ek__BackingField = original.\u003CAlt\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CPicturePath\u003Ek__BackingField = original.\u003CPicturePath\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CMobilePicturePath\u003Ek__BackingField = original.\u003CMobilePicturePath\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CPictureThumbPath\u003Ek__BackingField = original.\u003CPictureThumbPath\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CMobilePictureThumbPath\u003Ek__BackingField = original.\u003CMobilePictureThumbPath\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CDisplayText\u003Ek__BackingField = original.\u003CDisplayText\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CLocales\u003Ek__BackingField = original.\u003CLocales\u003Ek__BackingField;
  }
}
