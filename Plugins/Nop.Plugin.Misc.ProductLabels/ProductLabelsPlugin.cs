using Microsoft.AspNetCore.Routing;
using Nop.Core;
using Nop.Core.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nop.Services.Cms;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;
using Nop.Services.Common;
using Nop.Web.Framework.Menu;
using Nop.Services.Configuration;

namespace Nop.Plugin.Misc.ProductLabels
{
    public class ProductLabelsPlugin : BasePlugin, IMiscPlugin, IWidgetPlugin
    {
       private readonly IWebHelper _webHelper;
        public ProductLabelsPlugin(IWebHelper webHelper , ISettingService settingService)
        {
            _webHelper = webHelper;
        }

        public Task<IList<string>> GetWidgetZonesAsync()
        {
            return Task.FromResult<IList<string>>(new List<string>
            {
                PublicWidgetZones.ProductDetailsTop
            });
        }

        
        public string GetWidgetViewComponentName(string widgetZone)
        {
            return "ProductLabels";
        }


        public Task ManageSiteMapAsync(SiteMapNode rootNode)
        {
            var menuItem = new SiteMapNode
            {
                Title = "Product Labels",
                Visible = true,
                ControllerName = "ProductLabels",
                ActionName = "List",
                RouteValues = new RouteValueDictionary
                {
                    { "area", "Admin" }
                }
            };

            rootNode.ChildNodes.Add(menuItem);

            return Task.CompletedTask;
        }


        public override string GetConfigurationPageUrl()
        {
            return  _webHelper.GetStoreLocation() + "/Admin/ProductLabels/Configure";
        }

        public override async Task InstallAsync()
        {
            await base.InstallAsync();
        }

        public override async Task UninstallAsync()
        {
            await base.UninstallAsync();
        }
        public bool HideInWidgetList => false;
    }
}