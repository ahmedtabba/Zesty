using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Misc.ProductLabels.Models;
using Nop.Plugin.Misc.ProductLabels.Services;
using Nop.Services.Catalog;
using Nop.Web.Framework.Components;

using System.Linq;
using System.Threading.Tasks;

namespace Nop.Plugin.Misc.ProductLabels.Components
{
    public class ProductLabelViewComponent : NopViewComponent
    {
        private readonly IProductLabelService _productLabelService;
        private readonly IProductService _productService;

        public ProductLabelViewComponent(IProductLabelService productLabelService , IProductService productService)
        {
            _productLabelService = productLabelService;
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string widgetZone, object additionalData)
        {
            int productId = 0;

            if (additionalData is int id)
                productId = id;

            if (productId == 0)
                return Content("");

            var labels = await _productLabelService.GetByProductIdAsync(productId);

            var model = new PublicInfoModel
            {
                Labels = labels
                    .OrderBy(x => x.DisplayOrder)
                    .Select(x => new ProductLabelPublicModel
                    {
                        Id = x.Id,
                        LabelText = x.LabelText,
                        DisplayOrder = x.DisplayOrder
                    }).ToList()
            };

            return View("~/Plugins/Misc.ProductLabels/Views/Public/Default.cshtml", model);
        }
    }
}