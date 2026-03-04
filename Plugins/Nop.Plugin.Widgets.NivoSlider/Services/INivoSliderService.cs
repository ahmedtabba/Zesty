using Nop.Plugin.Widgets.NivoSlider.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nop.Plugin.Widgets.NivoSlider.Services
{
    public interface INivoSliderService
    {
        Task<IList<NivoSliderSlide>> GetAllSlidesAsync();
        Task<NivoSliderSlide> GetByIdAsync(int id);
        Task InsertSlideAsync(NivoSliderSlide slide);
        Task UpdateSlideAsync(NivoSliderSlide slide);
        Task DeleteSlideAsync(NivoSliderSlide slide);
    }
}