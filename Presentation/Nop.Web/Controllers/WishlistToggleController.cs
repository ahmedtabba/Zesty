using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Core.Domain.Orders;
using Nop.Services.Catalog;
using Nop.Services.Orders;
using System.Linq;
using System.Threading.Tasks;

namespace Nop.Web.Controllers
{
    public class WishlistToggleController : BasePublicController
    {
        private readonly IShoppingCartService _shoppingCartService;
        private readonly IWorkContext _workContext;
        private readonly IStoreContext _storeContext;
        private readonly IProductService _productService;

        public WishlistToggleController(
            IShoppingCartService shoppingCartService,
            IWorkContext workContext,
            IStoreContext storeContext,
            IProductService productService)
        {
            _shoppingCartService = shoppingCartService;
            _workContext = workContext;
            _storeContext = storeContext;
            _productService = productService;
        }

        [HttpPost]
        public async Task<IActionResult> Toggle(int productId)
        {
            // 1️⃣ جلب السياق
            var customer = await _workContext.GetCurrentCustomerAsync();
            var store = await _storeContext.GetCurrentStoreAsync();

            // 2️⃣ جلب الـ wishlist الحالي
            var wishlist = await _shoppingCartService.GetShoppingCartAsync(
                customer,
                ShoppingCartType.Wishlist,
                store.Id);

            // 3️⃣ هل المنتج موجود مسبقًا؟
            var existingItem = wishlist.FirstOrDefault(x => x.ProductId == productId);

            // 4️⃣ إذا موجود → إزالة
            if (existingItem != null)
            {
                await _shoppingCartService.DeleteShoppingCartItemAsync(existingItem);
                return Json(new { isInWishlist = false });
            }

            // 5️⃣ جلب المنتج (إلزامي)
            var product = await _productService.GetProductByIdAsync(productId);

            if (product == null || product.Deleted || !product.Published)
                return Json(new { isInWishlist = false });

            // 6️⃣ إضافة إلى الـ wishlist
            await _shoppingCartService.AddToCartAsync(
                customer,
                product,
                ShoppingCartType.Wishlist,
                store.Id);

            return Json(new { isInWishlist = true });
        }
    }
}
