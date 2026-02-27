// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Infrastructure.RouteProvider
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using SevenSpikes.Nop.Framework.Routing;

#nullable disable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Infrastructure;

public class RouteProvider : BaseRouteProvider
{
  protected virtual string PluginSystemName => "SevenSpikes.Nop.Plugins.AnywhereSliders";

  public RouteProvider()
    : base(true)
  {
  }
}
