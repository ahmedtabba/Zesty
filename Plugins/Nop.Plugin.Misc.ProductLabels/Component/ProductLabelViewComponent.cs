using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Misc.ProductLabels.Models;
using Nop.Plugin.Misc.ProductLabels.Services;
using Nop.Services.Catalog;
using Nop.Web.Framework.Components;

using System.Linq;
using System.Threading.Tasks;

namespace Nop.Plugin.Misc.ProductLabels.Components
{
    [ViewComponent(Name = "ProductLabels")]
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

            // additionalData can be an int (productId), the ProductDetailsModel, or an anonymous object containing Id/ProductId
            if (additionalData is int id)
            {
                productId = id;
            }
            else if (additionalData != null)
            {
                var type = additionalData.GetType();
                var prop = type.GetProperty("Id") ?? type.GetProperty("ProductId") ?? type.GetProperty("id") ?? type.GetProperty("productId");
                if (prop != null)
                {
                    var val = prop.GetValue(additionalData);
                    if (val is int i)
                        productId = i;
                    else if (val is long l)
                        productId = (int)l;
                    else if (val != null)
                        int.TryParse(val.ToString(), out productId);
                }
            }

            if (productId == 0)
                return Content(string.Empty);

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

            // render the public view that displays labels
            return View("~/Plugins/Misc.ProductLabels/Views/PublicInfo.cshtml", model);
        }
    }
}