// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Sliders.SliderModel
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;
using SevenSpikes.Nop.Framework.Areas.Admin.Models;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

#nullable enable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Sliders;

public record SliderModel : BaseNopEntityModel
{
  public SliderModel()
  {
    this.AddSlide = new SlideModel();
    this.Widgets = (IList<SliderToWidgetModel>) new List<SliderToWidgetModel>();
    this.AddSliderToWidget = new SliderToWidgetModel();
    this.StoreMappingModel = new StoreMappingModel();
    this.Languages = (IList<SelectListItem>) new List<SelectListItem>();
  }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slider.SystemName")]
  public 
  #nullable disable
  string SystemName { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slider.PreLoadFirstSlide")]
  public bool PreLoadFirstSlide { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slider.Autoplay")]
  public bool Autoplay { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slider.AutoplaySpeed")]
  public int AutoplaySpeed { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slider.Speed")]
  public int Speed { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slider.PauseOnHover")]
  public bool PauseOnHover { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slider.Fade")]
  public bool Fade { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slider.Dots")]
  public bool Dots { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slider.Arrows")]
  public bool Arrows { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slider.MobileBreakpoint")]
  public int MobileBreakpoint { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slider.CustomClass")]
  public string CustomClass { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slider.CustomCss")]
  public string CustomCss { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slider.Language")]
  public string Language { get; set; }

  public IList<SelectListItem> Languages { get; set; }

  public IList<SliderToWidgetModel> Widgets { get; set; }

  public bool IsActive { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slider.WidgetZonesNames")]
  public string WidgetZoneNames { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slider.CategoriesNames")]
  public string CategoriesNames { get; set; }

  [NopResourceDisplayName("SevenSpikes.Plugins.AnywhereSliders.Admin.Slider.ManufacturerNames")]
  public string ManufacturerNames { get; set; }

  public SliderToWidgetModel AddSliderToWidget { get; set; }

  public IList<SlideModel> Slides { get; set; }

  public bool IsTrialVersion { get; set; }

  public SlideModel AddSlide { get; set; }

  public StoreMappingModel StoreMappingModel { get; set; }

  [NopResourceDisplayName("Admin.Catalog.Products.Fields.LimitedToStores")]
  public bool LimitedToStores { get; set; }

  public bool DisableCustomCss { get; set; }

  [CompilerGenerated]
  public virtual 
  #nullable enable
  string ToString()
  {
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append(nameof (SliderModel));
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
    builder.Append("SystemName = ");
    builder.Append((object) this.SystemName);
    builder.Append(", PreLoadFirstSlide = ");
    builder.Append(this.PreLoadFirstSlide.ToString());
    builder.Append(", Autoplay = ");
    builder.Append(this.Autoplay.ToString());
    builder.Append(", AutoplaySpeed = ");
    builder.Append(this.AutoplaySpeed.ToString());
    builder.Append(", Speed = ");
    builder.Append(this.Speed.ToString());
    builder.Append(", PauseOnHover = ");
    builder.Append(this.PauseOnHover.ToString());
    builder.Append(", Fade = ");
    builder.Append(this.Fade.ToString());
    builder.Append(", Dots = ");
    builder.Append(this.Dots.ToString());
    builder.Append(", Arrows = ");
    builder.Append(this.Arrows.ToString());
    builder.Append(", MobileBreakpoint = ");
    builder.Append(this.MobileBreakpoint.ToString());
    builder.Append(", CustomClass = ");
    builder.Append((object) this.CustomClass);
    builder.Append(", CustomCss = ");
    builder.Append((object) this.CustomCss);
    builder.Append(", Language = ");
    builder.Append((object) this.Language);
    builder.Append(", Languages = ");
    builder.Append((object) this.Languages);
    builder.Append(", Widgets = ");
    builder.Append((object) this.Widgets);
    builder.Append(", IsActive = ");
    builder.Append(this.IsActive.ToString());
    builder.Append(", WidgetZoneNames = ");
    builder.Append((object) this.WidgetZoneNames);
    builder.Append(", CategoriesNames = ");
    builder.Append((object) this.CategoriesNames);
    builder.Append(", ManufacturerNames = ");
    builder.Append((object) this.ManufacturerNames);
    builder.Append(", AddSliderToWidget = ");
    builder.Append((object) this.AddSliderToWidget);
    builder.Append(", Slides = ");
    builder.Append((object) this.Slides);
    builder.Append(", IsTrialVersion = ");
    builder.Append(this.IsTrialVersion.ToString());
    builder.Append(", AddSlide = ");
    builder.Append((object) this.AddSlide);
    builder.Append(", StoreMappingModel = ");
    builder.Append((object) this.StoreMappingModel);
    builder.Append(", LimitedToStores = ");
    builder.Append(this.LimitedToStores.ToString());
    builder.Append(", DisableCustomCss = ");
    builder.Append(this.DisableCustomCss.ToString());
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
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    return (((((((((((((((((((((((((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CSystemName\u003Ek__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.\u003CPreLoadFirstSlide\u003Ek__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.\u003CAutoplay\u003Ek__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.\u003CAutoplaySpeed\u003Ek__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.\u003CSpeed\u003Ek__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.\u003CPauseOnHover\u003Ek__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.\u003CFade\u003Ek__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.\u003CDots\u003Ek__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.\u003CArrows\u003Ek__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.\u003CMobileBreakpoint\u003Ek__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CCustomClass\u003Ek__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CCustomCss\u003Ek__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CLanguage\u003Ek__BackingField)) * -1521134295 + EqualityComparer<IList<SelectListItem>>.Default.GetHashCode(this.\u003CLanguages\u003Ek__BackingField)) * -1521134295 + EqualityComparer<IList<SliderToWidgetModel>>.Default.GetHashCode(this.\u003CWidgets\u003Ek__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.\u003CIsActive\u003Ek__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CWidgetZoneNames\u003Ek__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CCategoriesNames\u003Ek__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.\u003CManufacturerNames\u003Ek__BackingField)) * -1521134295 + EqualityComparer<SliderToWidgetModel>.Default.GetHashCode(this.\u003CAddSliderToWidget\u003Ek__BackingField)) * -1521134295 + EqualityComparer<IList<SlideModel>>.Default.GetHashCode(this.\u003CSlides\u003Ek__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.\u003CIsTrialVersion\u003Ek__BackingField)) * -1521134295 + EqualityComparer<SlideModel>.Default.GetHashCode(this.\u003CAddSlide\u003Ek__BackingField)) * -1521134295 + EqualityComparer<StoreMappingModel>.Default.GetHashCode(this.\u003CStoreMappingModel\u003Ek__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.\u003CLimitedToStores\u003Ek__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(this.\u003CDisableCustomCss\u003Ek__BackingField);
  }

  [CompilerGenerated]
  public virtual bool Equals(BaseNopEntityModel? other) => ((object) this).Equals((object) other);

  [CompilerGenerated]
  public virtual bool Equals(SliderModel? other)
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
    return base.Equals((BaseNopEntityModel) other) && EqualityComparer<string>.Default.Equals(this.\u003CSystemName\u003Ek__BackingField, other.\u003CSystemName\u003Ek__BackingField) && EqualityComparer<bool>.Default.Equals(this.\u003CPreLoadFirstSlide\u003Ek__BackingField, other.\u003CPreLoadFirstSlide\u003Ek__BackingField) && EqualityComparer<bool>.Default.Equals(this.\u003CAutoplay\u003Ek__BackingField, other.\u003CAutoplay\u003Ek__BackingField) && EqualityComparer<int>.Default.Equals(this.\u003CAutoplaySpeed\u003Ek__BackingField, other.\u003CAutoplaySpeed\u003Ek__BackingField) && EqualityComparer<int>.Default.Equals(this.\u003CSpeed\u003Ek__BackingField, other.\u003CSpeed\u003Ek__BackingField) && EqualityComparer<bool>.Default.Equals(this.\u003CPauseOnHover\u003Ek__BackingField, other.\u003CPauseOnHover\u003Ek__BackingField) && EqualityComparer<bool>.Default.Equals(this.\u003CFade\u003Ek__BackingField, other.\u003CFade\u003Ek__BackingField) && EqualityComparer<bool>.Default.Equals(this.\u003CDots\u003Ek__BackingField, other.\u003CDots\u003Ek__BackingField) && EqualityComparer<bool>.Default.Equals(this.\u003CArrows\u003Ek__BackingField, other.\u003CArrows\u003Ek__BackingField) && EqualityComparer<int>.Default.Equals(this.\u003CMobileBreakpoint\u003Ek__BackingField, other.\u003CMobileBreakpoint\u003Ek__BackingField) && EqualityComparer<string>.Default.Equals(this.\u003CCustomClass\u003Ek__BackingField, other.\u003CCustomClass\u003Ek__BackingField) && EqualityComparer<string>.Default.Equals(this.\u003CCustomCss\u003Ek__BackingField, other.\u003CCustomCss\u003Ek__BackingField) && EqualityComparer<string>.Default.Equals(this.\u003CLanguage\u003Ek__BackingField, other.\u003CLanguage\u003Ek__BackingField) && EqualityComparer<IList<SelectListItem>>.Default.Equals(this.\u003CLanguages\u003Ek__BackingField, other.\u003CLanguages\u003Ek__BackingField) && EqualityComparer<IList<SliderToWidgetModel>>.Default.Equals(this.\u003CWidgets\u003Ek__BackingField, other.\u003CWidgets\u003Ek__BackingField) && EqualityComparer<bool>.Default.Equals(this.\u003CIsActive\u003Ek__BackingField, other.\u003CIsActive\u003Ek__BackingField) && EqualityComparer<string>.Default.Equals(this.\u003CWidgetZoneNames\u003Ek__BackingField, other.\u003CWidgetZoneNames\u003Ek__BackingField) && EqualityComparer<string>.Default.Equals(this.\u003CCategoriesNames\u003Ek__BackingField, other.\u003CCategoriesNames\u003Ek__BackingField) && EqualityComparer<string>.Default.Equals(this.\u003CManufacturerNames\u003Ek__BackingField, other.\u003CManufacturerNames\u003Ek__BackingField) && EqualityComparer<SliderToWidgetModel>.Default.Equals(this.\u003CAddSliderToWidget\u003Ek__BackingField, other.\u003CAddSliderToWidget\u003Ek__BackingField) && EqualityComparer<IList<SlideModel>>.Default.Equals(this.\u003CSlides\u003Ek__BackingField, other.\u003CSlides\u003Ek__BackingField) && EqualityComparer<bool>.Default.Equals(this.\u003CIsTrialVersion\u003Ek__BackingField, other.\u003CIsTrialVersion\u003Ek__BackingField) && EqualityComparer<SlideModel>.Default.Equals(this.\u003CAddSlide\u003Ek__BackingField, other.\u003CAddSlide\u003Ek__BackingField) && EqualityComparer<StoreMappingModel>.Default.Equals(this.\u003CStoreMappingModel\u003Ek__BackingField, other.\u003CStoreMappingModel\u003Ek__BackingField) && EqualityComparer<bool>.Default.Equals(this.\u003CLimitedToStores\u003Ek__BackingField, other.\u003CLimitedToStores\u003Ek__BackingField) && EqualityComparer<bool>.Default.Equals(this.\u003CDisableCustomCss\u003Ek__BackingField, other.\u003CDisableCustomCss\u003Ek__BackingField);
  }

  [CompilerGenerated]
  protected SliderModel(SliderModel original)
    : base((BaseNopEntityModel) original)
  {
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CSystemName\u003Ek__BackingField = original.\u003CSystemName\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CPreLoadFirstSlide\u003Ek__BackingField = original.\u003CPreLoadFirstSlide\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CAutoplay\u003Ek__BackingField = original.\u003CAutoplay\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CAutoplaySpeed\u003Ek__BackingField = original.\u003CAutoplaySpeed\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CSpeed\u003Ek__BackingField = original.\u003CSpeed\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CPauseOnHover\u003Ek__BackingField = original.\u003CPauseOnHover\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CFade\u003Ek__BackingField = original.\u003CFade\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CDots\u003Ek__BackingField = original.\u003CDots\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CArrows\u003Ek__BackingField = original.\u003CArrows\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CMobileBreakpoint\u003Ek__BackingField = original.\u003CMobileBreakpoint\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CCustomClass\u003Ek__BackingField = original.\u003CCustomClass\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CCustomCss\u003Ek__BackingField = original.\u003CCustomCss\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CLanguage\u003Ek__BackingField = original.\u003CLanguage\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CLanguages\u003Ek__BackingField = original.\u003CLanguages\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CWidgets\u003Ek__BackingField = original.\u003CWidgets\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CIsActive\u003Ek__BackingField = original.\u003CIsActive\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CWidgetZoneNames\u003Ek__BackingField = original.\u003CWidgetZoneNames\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CCategoriesNames\u003Ek__BackingField = original.\u003CCategoriesNames\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CManufacturerNames\u003Ek__BackingField = original.\u003CManufacturerNames\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CAddSliderToWidget\u003Ek__BackingField = original.\u003CAddSliderToWidget\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CSlides\u003Ek__BackingField = original.\u003CSlides\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CIsTrialVersion\u003Ek__BackingField = original.\u003CIsTrialVersion\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CAddSlide\u003Ek__BackingField = original.\u003CAddSlide\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CStoreMappingModel\u003Ek__BackingField = original.\u003CStoreMappingModel\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CLimitedToStores\u003Ek__BackingField = original.\u003CLimitedToStores\u003Ek__BackingField;
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated field
    this.\u003CDisableCustomCss\u003Ek__BackingField = original.\u003CDisableCustomCss\u003Ek__BackingField;
  }
}
