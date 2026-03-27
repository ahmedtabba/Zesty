using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Misc.ProductLabels.Models;
using Nop.Plugin.Misc.ProductLabels.Services;
using Nop.Web.Framework.Components;
using System.Linq;
using System.Threading.Tasks;

namespace Nop.Plugin.Misc.ProductLabels.Components
{
    public class ProductLabelViewComponent : NopViewComponent
    {
        private readonly IProductLabelService _productLabelService;

        public ProductLabelViewComponent(IProductLabelService productLabelService)
        {
            _productLabelService = productLabelService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int productId)
        {
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