using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nop.Data;
using Nop.Plugin.Misc.ProductLabels.Domain;

namespace Nop.Plugin.Misc.ProductLabels.Services
{
    public class ProductLabelService : IProductLabelService
    {
        private readonly IRepository<ProductLabel> _repository;
        private readonly IRepository<ProductLabelProduct> _mappingRepository;

        public ProductLabelService(IRepository<ProductLabel> repository, IRepository<ProductLabelProduct> mappingRepository)
        {
            _repository = repository;
            _mappingRepository = mappingRepository;
        }

        public Task DeleteAsync(ProductLabel label) => _repository.DeleteAsync(label);

        public async Task<IList<ProductLabel>> GetAllAsync() => await _repository.Table.ToListAsync();

        public async Task<ProductLabel> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);

        public async Task<IList<ProductLabel>> GetByProductIdAsync(int productId)
        {
            var mappings = await _mappingRepository.Table.Where(m => m.ProductId == productId).ToListAsync();
            var labelIds = mappings.Select(m => m.ProductLabelId).ToList();
            return await _repository.Table.Where(pl => labelIds.Contains(pl.Id) && pl.IsPublished).ToListAsync();
        }

        public Task InsertAsync(ProductLabel label) => _repository.InsertAsync(label);

        public Task UpdateAsync(ProductLabel label) => _repository.UpdateAsync(label);

        public Task InsertMappingAsync(ProductLabelProduct mapping) => _mappingRepository.InsertAsync(mapping);

        public async Task DeleteMappingsByLabelIdAsync(int labelId)
        {
            var maps = await _mappingRepository.Table.Where(m => m.ProductLabelId == labelId).ToListAsync();
            foreach (var m in maps)
                await _mappingRepository.DeleteAsync(m);
        }

        public async Task<IList<ProductLabelProduct>> GetMappingsByLabelIdAsync(int labelId)
        {
            return await _mappingRepository.Table.Where(m => m.ProductLabelId == labelId).ToListAsync();
        }

        public async Task<IList<ProductLabel>> GetByProductIdsAsync(IList<int> productIds)
        {
            var mappings = await _mappingRepository.Table.Where(m => productIds.Contains(m.ProductId)).ToListAsync();
            var labelIds = mappings.Select(m => m.ProductLabelId).Distinct().ToList();
            return await _repository.Table.Where(pl => labelIds.Contains(pl.Id) && pl.IsPublished).ToListAsync();
        }
    }
}
