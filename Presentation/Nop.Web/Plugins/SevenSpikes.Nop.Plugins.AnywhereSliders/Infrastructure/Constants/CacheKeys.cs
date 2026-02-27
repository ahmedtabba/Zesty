// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Infrastructure.Constants.CacheKeys
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Nop.Core.Caching;

#nullable disable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Infrastructure.Constants;

public static class CacheKeys
{
  public const string CachePattern = "nop.pres.anywheresliders.";
  public const string WidgetCachePattern = "nop.pres.anywheresliders.widget.";

  public static CacheKey WidgetDictionaryCacheKey
  {
    get
    {
      return new CacheKey("nop.pres.anywheresliders.widgetdictionary", new string[1]
      {
        "nop.pres.anywheresliders."
      });
    }
  }

  public static CacheKey CacheKey
  {
    get
    {
      return new CacheKey("nop.pres.anywheresliders.widget.{0}-{1}-{2}-{3}-{4}-{5}-{6}-{7}-{8}-{9}", new string[1]
      {
        "nop.pres.anywheresliders."
      });
    }
  }
}
