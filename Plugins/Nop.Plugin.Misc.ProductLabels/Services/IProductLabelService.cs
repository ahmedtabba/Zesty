using Nop.Plugin.Misc.ProductLabels.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Misc.ProductLabels.Services
{
    public interface IProductLabelService
    {
        Task<IList<ProductLabel>> GetByProductIdAsync(int productId);
        Task InsertAsync(ProductLabel label);
        Task UpdateAsync(ProductLabel label);
        Task DeleteAsync(ProductLabel label);
        Task<IList<ProductLabel>> GetAllAsync();
        Task<ProductLabel> GetByIdAsync(int id);
    }
}
