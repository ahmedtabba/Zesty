// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Services.ISliderService
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using SevenSpikes.Nop.EntitySettings.MarkerInterfaces;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.Sliders;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable disable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Services;

public interface ISliderService
{
  Task<IList<Slider>> GetAllSlidersAsync();

  Task<IList<Slider>> GetSlidersByWidgetZoneAsync(string widgetZone);

  Task<Slider> GetSliderByIdAsync(int id);

  Task<Slider> GetAvailableSliderByIdAsync(int id);

  Task<Slider> GetAvailableSliderBySystemNameAsync(string systemName);

  Task<IList<Slider>> SearchSlidersAsync(string searchName);

  Task InsertSliderAsync(Slider slider);

  Task UpdateSliderAsync(Slider slider);

  Task DeleteSliderAsync(Slider slider);

  Task AddOrUpdateEntitySettingsAsync<T>(T sliderEntitySettings, int sliderId) where T : IEntitySettings, new();

  Task<T> GetSliderSettingsAsync<T>(int sliderId) where T : IEntitySettings, new();

  Task<IList<Slide>> GetAllSlidesBySliderIdAsync(int sliderId);

  Task<IList<Slide>> GetAllVisibleSlidesAsync(int sliderId);

  Task<IList<Slide>> GetAllSlidesAsync();

  Task<Slide> GetSlideByIdAsync(int slideId);

  Task InsertSlideAsync(Slide slide);

  Task UpdateSlideAsync(Slide slide);

  Task DeleteSlideAsync(Slide slide);
}
