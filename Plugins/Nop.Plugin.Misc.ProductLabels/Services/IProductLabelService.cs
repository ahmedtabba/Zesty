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
        Task<IList<ProductLabel>> GetAllAsync();
        Task<ProductLabel> GetByIdAsync(int id);
        Task InsertAsync(ProductLabel label);
        Task UpdateAsync(ProductLabel label);
        Task DeleteAsync(ProductLabel label);

        // mapping
        Task InsertMappingAsync(ProductLabelProduct mapping);
        Task DeleteMappingsByLabelIdAsync(int labelId);
        Task<IList<ProductLabelProduct>> GetMappingsByLabelIdAsync(int labelId);
        Task<IList<ProductLabel>> GetByProductIdsAsync(IList<int> productIds);
    }
}
