using Microsoft.AspNetCore.Routing;
using Nop.Core;
using Nop.Core.Domain.Cms;
using Nop.Services.Cms;
using Nop.Services.Common;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;
using Nop.Web.Framework.Menu;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nop.Plugin.Misc.ProductLabels
{
    public class ProductLabelsPlugin : BasePlugin, IMiscPlugin, IWidgetPlugin, IAdminMenuPlugin
    {
        public bool HideInWidgetList => false;
       private readonly IWebHelper _webHelper;
        public ProductLabelsPlugin(IWebHelper webHelper)
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

        public override Task InstallAsync()
        {
            return base.InstallAsync();
        }

        public override Task UninstallAsync()
        {
            return base.UninstallAsync();
        }
    }
}