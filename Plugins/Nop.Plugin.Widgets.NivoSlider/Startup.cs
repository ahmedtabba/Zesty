using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nop.Core.Infrastructure;
using Nop.Plugin.Widgets.NivoSlider.Services;

namespace Nop.Plugin.Widgets.NivoSlider
{
    public class Startup : INopStartup
    {
        // تسجيل الخدمات الخاصة بالـ plugin
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<INivoSliderService, NivoSliderService>();
        }

        // أي إعدادات عند بدء التشغيل
        public void Configure(IApplicationBuilder application)
        {
        }

        public int Order => 1;
    }
}