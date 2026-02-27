// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Services.SliderService
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Nop.Core;
using Nop.Core.Caching;
using Nop.Core.Events;
using Nop.Data;
using SevenSpikes.Nop.EntitySettings.MarkerInterfaces;
using SevenSpikes.Nop.EntitySettings.Services.EntitySettings;
using SevenSpikes.Nop.Mappings.Domain;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.Sliders;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Infrastructure.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;

#nullable enable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Services;

public class SliderService : ISliderService
{
  private readonly 
  #nullable disable
  IEventPublisher _eventPublisher;
  private readonly IRepository<Slide> _slideRepository;
  private readonly IRepository<Slider> _sliderRepository;
  private readonly IRepository<EntityWidgetMapping> _entityWidgetMappingRepository;
  private readonly IEntitySettingService _entitySettingService;

  public SliderService(
    IEventPublisher eventPublisher,
    IRepository<Slide> slideRepository,
    IRepository<Slider> sliderRepository,
    IRepository<EntityWidgetMapping> entityWidgetMappingRepository,
    IEntitySettingService entitySettingService)
  {
    this._entitySettingService = entitySettingService;
    this._eventPublisher = eventPublisher;
    this._slideRepository = slideRepository;
    this._sliderRepository = sliderRepository;
    this._entityWidgetMappingRepository = entityWidgetMappingRepository;
  }

  public async Task<IList<Slider>> GetAllSlidersAsync()
  {
    return (IList<Slider>) await AsyncIQueryableExtensions.ToListAsync<Slider>(this._sliderRepository.Table.Select<Slider, Slider>((Expression<Func<Slider, Slider>>) (s => s)));
  }

  public async Task<IList<Slider>> GetSlidersByWidgetZoneAsync(string widgetZone)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    SliderService.\u003C\u003Ec__DisplayClass7_0 cDisplayClass70 = new SliderService.\u003C\u003Ec__DisplayClass7_0();
    // ISSUE: reference to a compiler-generated field
    cDisplayClass70.widgetZone = widgetZone;
    ParameterExpression parameterExpression1;
    ParameterExpression parameterExpression2;
    ParameterExpression parameterExpression3;
    ParameterExpression parameterExpression4;
    // ISSUE: method reference
    // ISSUE: method reference
    // ISSUE: method reference
    // ISSUE: type reference
    // ISSUE: method reference
    // ISSUE: field reference
    // ISSUE: method reference
    // ISSUE: type reference
    // ISSUE: method reference
    // ISSUE: field reference
    // ISSUE: method reference
    // ISSUE: type reference
    // ISSUE: method reference
    return (IList<Slider>) await AsyncIQueryableExtensions.ToListAsync<Slider>(this._sliderRepository.Table.Join((IEnumerable<EntityWidgetMapping>) this._entityWidgetMappingRepository.Table, Expression.Lambda<Func<Slider, int>>((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (BaseEntity.get_Id))), parameterExpression1), Expression.Lambda<Func<EntityWidgetMapping, int>>((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityWidgetMapping.get_EntityId))), parameterExpression2), (slider, widgetMapping) => new
    {
      slider = slider,
      widgetMapping = widgetMapping
    }).Where(Expression.Lambda<Func<\u003C\u003Ef__AnonymousType2<Slider, EntityWidgetMapping>, bool>>((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Convert((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression3, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType2<Slider, EntityWidgetMapping>.get_widgetMapping), __typeref (\u003C\u003Ef__AnonymousType2<Slider, EntityWidgetMapping>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityWidgetMapping.get_EntityType))), typeof (int)), (Expression) Expression.Convert((Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (Plugin.EntityType))), typeof (int))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression3, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType2<Slider, EntityWidgetMapping>.get_widgetMapping), __typeref (\u003C\u003Ef__AnonymousType2<Slider, EntityWidgetMapping>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityWidgetMapping.get_WidgetZone))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass70, typeof (SliderService.\u003C\u003Ec__DisplayClass7_0)), FieldInfo.GetFieldFromHandle(__fieldref (SliderService.\u003C\u003Ec__DisplayClass7_0.widgetZone))))), parameterExpression3)).OrderBy(Expression.Lambda<Func<\u003C\u003Ef__AnonymousType2<Slider, EntityWidgetMapping>, int>>((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType2<Slider, EntityWidgetMapping>.get_widgetMapping), __typeref (\u003C\u003Ef__AnonymousType2<Slider, EntityWidgetMapping>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityWidgetMapping.get_DisplayOrder))), parameterExpression4)).Select(data => data.slider));
  }

  public async Task<Slider> GetSliderByIdAsync(int id)
  {
    return await this._sliderRepository.GetByIdAsync(new int?(id), (Func<IStaticCacheManager, CacheKey>) null, true);
  }

  public async Task<Slider> GetAvailableSliderByIdAsync(int id)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    SliderService.\u003C\u003Ec__DisplayClass9_0 cDisplayClass90 = new SliderService.\u003C\u003Ec__DisplayClass9_0();
    // ISSUE: reference to a compiler-generated field
    cDisplayClass90.id = id;
    ParameterExpression parameterExpression;
    // ISSUE: method reference
    // ISSUE: field reference
    return await AsyncIQueryableExtensions.FirstOrDefaultAsync<Slider>(this._sliderRepository.Table.Where<Slider>(Expression.Lambda<Func<Slider, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (BaseEntity.get_Id))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass90, typeof (SliderService.\u003C\u003Ec__DisplayClass9_0)), FieldInfo.GetFieldFromHandle(__fieldref (SliderService.\u003C\u003Ec__DisplayClass9_0.id)))), parameterExpression)), (Expression<Func<Slider, bool>>) null);
  }

  public async Task<Slider> GetAvailableSliderBySystemNameAsync(string systemName)
  {
    return await AsyncIQueryableExtensions.FirstOrDefaultAsync<Slider>(this._sliderRepository.Table.Where<Slider>((Expression<Func<Slider, bool>>) (s => s.SystemName == systemName)), (Expression<Func<Slider, bool>>) null);
  }

  public async Task<IList<Slider>> SearchSlidersAsync(string searchName)
  {
    return (IList<Slider>) await AsyncIQueryableExtensions.ToListAsync<Slider>(this._sliderRepository.Table.Where<Slider>((Expression<Func<Slider, bool>>) (s => s.SystemName.Contains(searchName))));
  }

  public async Task InsertSliderAsync(Slider slider)
  {
    if (slider == null)
      throw new ArgumentNullException(nameof (slider));
    await this._sliderRepository.InsertAsync(slider, true);
    await EventPublisherExtensions.EntityInsertedAsync<Slider>(this._eventPublisher, slider);
  }

  public async Task UpdateSliderAsync(Slider slider)
  {
    if (slider == null)
      throw new ArgumentNullException(nameof (slider));
    await this._sliderRepository.UpdateAsync(slider, true);
    await EventPublisherExtensions.EntityUpdatedAsync<Slider>(this._eventPublisher, slider);
  }

  public async Task DeleteSliderAsync(Slider slider)
  {
    if (slider == null)
      throw new ArgumentNullException(nameof (slider));
    await this._sliderRepository.DeleteAsync(slider, true);
    await EventPublisherExtensions.EntityDeletedAsync<Slider>(this._eventPublisher, slider);
  }

  public async Task AddOrUpdateEntitySettingsAsync<T>(T sliderEntitySettings, int sliderId) where T : IEntitySettings, new()
  {
    if ((object) (T) sliderEntitySettings == null)
      throw new ArgumentNullException(nameof (sliderEntitySettings));
    await this._entitySettingService.SaveSettingsAsync<T>(sliderEntitySettings, Plugin.EntityType, sliderId);
  }

  public async Task<T> GetSliderSettingsAsync<T>(int sliderId) where T : IEntitySettings, new()
  {
    if (sliderId == 0)
      throw new ArgumentException("sliderId should not be 0");
    return await this._entitySettingService.LoadEntitySettingsAsync<T>(Plugin.EntityType, sliderId);
  }

  public async Task<IList<Slide>> GetAllSlidesBySliderIdAsync(int sliderId)
  {
    return (IList<Slide>) await AsyncIQueryableExtensions.ToListAsync<Slide>((IQueryable<Slide>) this._slideRepository.Table.Where<Slide>((Expression<Func<Slide, bool>>) (i => i.SliderId == sliderId)).OrderBy<Slide, int>((Expression<Func<Slide, int>>) (i => i.DisplayOrder)));
  }

  public async Task<IList<Slide>> GetAllVisibleSlidesAsync(int sliderId)
  {
    return (IList<Slide>) await AsyncIQueryableExtensions.ToListAsync<Slide>((IQueryable<Slide>) this._slideRepository.Table.Where<Slide>((Expression<Func<Slide, bool>>) (i => i.SliderId == sliderId && i.Visible)).OrderBy<Slide, int>((Expression<Func<Slide, int>>) (i => i.DisplayOrder)));
  }

  public async Task<IList<Slide>> GetAllSlidesAsync()
  {
    return (IList<Slide>) await AsyncIQueryableExtensions.ToListAsync<Slide>(this._slideRepository.Table);
  }

  public async Task<Slide> GetSlideByIdAsync(int slideId)
  {
    return await this._slideRepository.GetByIdAsync(new int?(slideId), (Func<IStaticCacheManager, CacheKey>) null, true);
  }

  public async Task InsertSlideAsync(Slide slide)
  {
    if (slide == null)
      throw new ArgumentNullException(nameof (slide));
    await this._slideRepository.InsertAsync(slide, true);
    await EventPublisherExtensions.EntityInsertedAsync<Slide>(this._eventPublisher, slide);
  }

  public async Task UpdateSlideAsync(Slide slide)
  {
    if (slide == null)
      throw new ArgumentNullException(nameof (slide));
    await this._slideRepository.UpdateAsync(slide, true);
    await EventPublisherExtensions.EntityUpdatedAsync<Slide>(this._eventPublisher, slide);
  }

  public async Task DeleteSlideAsync(Slide slide)
  {
    if (slide == null)
      throw new ArgumentNullException(nameof (slide));
    await this._slideRepository.DeleteAsync(slide, true);
    await EventPublisherExtensions.EntityDeletedAsync<Slide>(this._eventPublisher, slide);
  }
}
