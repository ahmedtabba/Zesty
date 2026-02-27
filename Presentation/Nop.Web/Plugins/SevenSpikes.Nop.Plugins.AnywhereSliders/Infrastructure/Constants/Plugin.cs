// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Infrastructure.Constants.Plugin
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using SevenSpikes.Nop.Conditions.Domain;
using SevenSpikes.Nop.Framework.Domain.Enums;
using System.Collections.Generic;

#nullable disable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Infrastructure.Constants;

public static class Plugin
{
  public const string Name = "Nop Anywhere Sliders";
  public const string SystemName = "SevenSpikes.Nop.Plugins.AnywhereSliders";
  public const string FolderName = "SevenSpikes.Nop.Plugins.AnywhereSliders";
  public const string ResourceName = "SevenSpikes.Plugins.AnywhereSliders.Admin.Menu.MenuName";
  public static EntityType EntityType = (EntityType) 15;
  public const string NopCommerceNivoSliderWidgetWidgetSystemName = "Widgets.NivoSlider";
  public const string UrlInStore = "http://www.nop-templates.com/anywhere-sliders-plugin-for-nopcommerce";
  public const string CustomCssFileNameSettingKey = "AnywhereSliderSettings.CustomCssFileVersion";
  public const string AnywhereSlidersTableName = "SS_AS_AnywhereSlider";
  public const string SlidesTableName = "SS_AS_Slide";
  public static IDictionary<ConditionType, IList<object>> AvailableConditionTypes = (IDictionary<ConditionType, IList<object>>) new Dictionary<ConditionType, IList<object>>()
  {
    {
      (ConditionType) 4,
      (IList<object>) new List<object>()
      {
        (object) (CustomerConditionProperty) 0,
        (object) (CustomerConditionProperty) 2,
        (object) (CustomerConditionProperty) 4,
        (object) (CustomerConditionProperty) 3,
        (object) (CustomerConditionProperty) 5,
        (object) (CustomerConditionProperty) 1
      }
    },
    {
      (ConditionType) 3,
      (IList<object>) new List<object>()
      {
        (object) (ProductConditionProperty) 1,
        (object) (ProductConditionProperty) 0,
        (object) (ProductConditionProperty) 4,
        (object) (ProductConditionProperty) 5,
        (object) (ProductConditionProperty) 11,
        (object) (ProductConditionProperty) 12,
        (object) (ProductConditionProperty) 2,
        (object) (ProductConditionProperty) 8,
        (object) (ProductConditionProperty) 10,
        (object) (ProductConditionProperty) 6,
        (object) (ProductConditionProperty) 7,
        (object) (ProductConditionProperty) 3,
        (object) (ProductConditionProperty) 9,
        (object) (ProductConditionProperty) 13,
        (object) (ProductConditionProperty) 14,
        (object) (ProductConditionProperty) 15,
        (object) (ProductConditionProperty) 16 /*0x10*/
      }
    },
    {
      (ConditionType) 1,
      (IList<object>) new List<object>()
      {
        (object) (ManufacturerConditionProperty) 0,
        (object) (ManufacturerConditionProperty) 1
      }
    },
    {
      (ConditionType) 2,
      (IList<object>) new List<object>()
      {
        (object) (CategoryConditionProperty) 0,
        (object) (CategoryConditionProperty) 1
      }
    },
    {
      (ConditionType) 5,
      (IList<object>) new List<object>()
    },
    {
      (ConditionType) 6,
      (IList<object>) new List<object>()
      {
        (object) (CategoryConditionProperty) 0,
        (object) (CategoryConditionProperty) 1
      }
    },
    {
      (ConditionType) 7,
      (IList<object>) new List<object>()
      {
        (object) (VendorConditionProperty) 0,
        (object) (VendorConditionProperty) 1
      }
    }
  };
}
