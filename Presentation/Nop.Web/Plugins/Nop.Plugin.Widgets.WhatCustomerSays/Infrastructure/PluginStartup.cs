using AutoMapper.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Nop.Core.Infrastructure;
using Nop.Plugin.Widgets.WhatCustomerSays.Services;

namespace Nop.Plugin.Widgets.WhatCustomerSays.Infrastructure;

public class PluginStartup : INopStartup
{
    public void ConfigureServices(IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configuration)
    {
        services.AddScoped<IWhatCustomerSaysService, WhatCustomerSaysService>();
    }

    public void Configure(IApplicationBuilder application)
    {
    }


    public int Order => 3000;
}
