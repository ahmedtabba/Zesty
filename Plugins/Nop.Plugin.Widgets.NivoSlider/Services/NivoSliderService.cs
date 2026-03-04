using Nop.Data;
using Nop.Plugin.Widgets.NivoSlider.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nop.Plugin.Widgets.NivoSlider.Services
{
    public class NivoSliderService : INivoSliderService
    {
        private readonly IRepository<NivoSliderSlide> _repository;

        public NivoSliderService(IRepository<NivoSliderSlide> repository)
        {
            _repository = repository;
        }

        public async Task<IList<NivoSliderSlide>> GetAllSlidesAsync()
        {
            var query = _repository.Table.OrderBy(x => x.DisplayOrder);
            return query.ToList();
        }

        public Task<NivoSliderSlide> GetByIdAsync(int id) => _repository.GetByIdAsync(id);
        public Task InsertSlideAsync(NivoSliderSlide slide) => _repository.InsertAsync(slide);
        public Task UpdateSlideAsync(NivoSliderSlide slide) => _repository.UpdateAsync(slide);
        public Task DeleteSlideAsync(NivoSliderSlide slide) => _repository.DeleteAsync(slide);
    }
}