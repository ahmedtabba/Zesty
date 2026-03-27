using Nop.Data;
using Nop.Plugin.Misc.ProductLabels.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Misc.ProductLabels.Services
{
    public class ProductLabelService : IProductLabelService
    {
        private readonly IRepository<ProductLabel> _repository;
        public ProductLabelService(IRepository<ProductLabel> repository)
        {
            _repository = repository;
        }
        public Task DeleteAsync(ProductLabel label) => _repository.DeleteAsync(label);

        public async Task<IList<ProductLabel>> GetAllAsync() => await _repository.Table.ToListAsync();

        public async Task<ProductLabel> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IList<ProductLabel>> GetByProductIdAsync(int productId)
        {
           return await _repository.Table.Where(pl => pl.ProductId == productId && pl.IsPublished).ToListAsync();
        }

        public Task InsertAsync(ProductLabel label) =>  _repository.InsertAsync(label);

        public Task UpdateAsync(ProductLabel label) => _repository.UpdateAsync(label);
    }
}
