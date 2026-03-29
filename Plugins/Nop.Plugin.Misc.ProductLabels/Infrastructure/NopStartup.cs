using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nop.Core.Infrastructure;
using Nop.Data;
using Nop.Plugin.Misc.ProductLabels.Domain;
using Nop.Plugin.Misc.ProductLabels.Services;

namespace Nop.Plugin.Misc.ProductLabels.Infrastructure
{
    public class NopStartup : INopStartup
    {
        public int Order => 3000;

        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProductLabelService, ProductLabelService>();
        }

        public void Configure(IApplicationBuilder application)
        {
        }
    }
}