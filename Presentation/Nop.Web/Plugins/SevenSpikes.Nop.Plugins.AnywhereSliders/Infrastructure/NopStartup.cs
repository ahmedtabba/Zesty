// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Infrastructure.NopStartup
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nop.Core.Infrastructure;

#nullable disable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Infrastructure;

public class NopStartup : INopStartup
{
  public int Order => 2001;

  public void Configure(IApplicationBuilder application)
  {
  }

  public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
  {
  }
}
