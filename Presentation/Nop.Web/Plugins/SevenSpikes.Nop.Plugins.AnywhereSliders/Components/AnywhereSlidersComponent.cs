// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Components.AnywhereSlidersComponent
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Nop.Core;
using Nop.Core.Caching;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Customers;
using Nop.Core.Domain.Stores;
using Nop.Core.Infrastructure;
using Nop.Services.Catalog;
using Nop.Services.Customers;
using Nop.Services.Media;
using Nop.Services.Stores;
using Nop.Services.Topics;
using Nop.Services.Vendors;
using Nop.Web.Framework.Components;
using SevenSpikes.Nop.Conditions.Domain;
using SevenSpikes.Nop.Conditions.Domain.FakeEntity;
using SevenSpikes.Nop.Conditions.Helpers;
using SevenSpikes.Nop.Conditions.Services;
using SevenSpikes.Nop.Framework.Components;
using SevenSpikes.Nop.Framework.Theme;
using SevenSpikes.Nop.Mappings.Domain;
using SevenSpikes.Nop.Mappings.Services;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.Sliders;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Helpers;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Infrastructure.Constants;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Models;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Services;
using SevenSpikes.Nop.Scheduling.Domain;
using SevenSpikes.Nop.Scheduling.Helpers;
using SevenSpikes.Nop.Scheduling.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

#nullable enable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Components;

[ViewComponent(Name = "AnywhereSliders")]
public class AnywhereSlidersComponent : Base7SpikesComponent
{
  private readonly 
  #nullable disable
  ISliderService _sliderService;
  private readonly IProductService _productService;
  private readonly IManufacturerService _manufacturerService;
  private readonly ICategoryService _categoryService;
  private readonly ITopicService _topicService;
  private readonly IVendorService _vendorService;
  private readonly IPictureService _pictureService;
  private readonly IStoreMappingService _storeMappingService;
  private readonly IWorkContext _workContext;
  private readonly IWebHelper _webHelper;
  private readonly IConditionService _conditionService;
  private readonly IConditionChecker _conditionChecker;
  private readonly ISchedulingService _schedulingService;
  private readonly ISchedulingChecker _schedulingChecker;
  private readonly IEntityWidgetMappingService _entityWidgetMappingService;
  private readonly IStoreContext _storeContext;
  private readonly IStoreService _storeService;
  private readonly ICustomCssHelper _customCssHelper;
  private readonly IWebHostEnvironment _webHostEnvironment;
  private const string WidgetSliderIdFormat = "WidgetSlider-{0}-{1}";
  private IStaticCacheManager _staticCacheManager;

  private IStaticCacheManager StaticCacheManager
  {
    get
    {
      if (this._staticCacheManager == null)
        this._staticCacheManager = EngineContext.Current.Resolve<IStaticCacheManager>((IServiceScope) null);
      return this._staticCacheManager;
    }
  }

  public AnywhereSlidersComponent(
    ISliderService sliderService,
    IPictureService pictureService,
    IStoreMappingService storeMappingService,
    IWorkContext workContext,
    IStoreContext storeContext,
    IProductService productService,
    IManufacturerService manufacturerService,
    ICategoryService categoryService,
    IWebHelper webHelper,
    IConditionService conditionService,
    IConditionChecker conditionChecker,
    ISchedulingService schedulingService,
    ISchedulingChecker schedulingChecker,
    IEntityWidgetMappingService entityWidgetMappingService,
    ITopicService topicService,
    IVendorService vendorService,
    IStoreService storeService,
    ICustomCssHelper customCssHelper,
    IWebHostEnvironment webHostEnvironment)
  {
    this._sliderService = sliderService;
    this._productService = productService;
    this._manufacturerService = manufacturerService;
    this._categoryService = categoryService;
    this._pictureService = pictureService;
    this._storeMappingService = storeMappingService;
    this._workContext = workContext;
    this._webHelper = webHelper;
    this._conditionService = conditionService;
    this._conditionChecker = conditionChecker;
    this._schedulingService = schedulingService;
    this._schedulingChecker = schedulingChecker;
    this._storeContext = storeContext;
    this._entityWidgetMappingService = entityWidgetMappingService;
    this._topicService = topicService;
    this._vendorService = vendorService;
    this._storeService = storeService;
    this._customCssHelper = customCssHelper;
    this._webHostEnvironment = webHostEnvironment;
  }

  public async Task<IViewComponentResult> InvokeAsync(string widgetZone)
  {
    AnywhereSlidersComponent slidersComponent = this;
    int productId = 0;
    if (((ViewComponent) slidersComponent).RouteData.Values.Keys.Any<string>((Func<string, bool>) (x => x.Equals("productid", StringComparison.OrdinalIgnoreCase))))
      productId = Convert.ToInt32(((ViewComponent) slidersComponent).RouteData.Values["productid"].ToString());
    int categoryId = 0;
    if (((ViewComponent) slidersComponent).RouteData.Values.Keys.Any<string>((Func<string, bool>) (x => x.Equals("categoryid", StringComparison.OrdinalIgnoreCase))))
      categoryId = Convert.ToInt32(((ViewComponent) slidersComponent).RouteData.Values["categoryId"].ToString());
    int manufacturerId = 0;
    if (((ViewComponent) slidersComponent).RouteData.Values.Keys.Any<string>((Func<string, bool>) (x => x.Equals("manufacturerid", StringComparison.OrdinalIgnoreCase))))
      manufacturerId = Convert.ToInt32(((ViewComponent) slidersComponent).RouteData.Values["manufacturerId"].ToString());
    int topicId = 0;
    if (((ViewComponent) slidersComponent).RouteData.Values.Keys.Any<string>((Func<string, bool>) (x => x.Equals("topicid", StringComparison.OrdinalIgnoreCase))))
      topicId = Convert.ToInt32(((ViewComponent) slidersComponent).RouteData.Values["topicId"].ToString());
    int vendorId = 0;
    if (((ViewComponent) slidersComponent).RouteData.Values.Keys.Any<string>((Func<string, bool>) (x => x.Equals("vendorid", StringComparison.OrdinalIgnoreCase))))
      vendorId = Convert.ToInt32(((ViewComponent) slidersComponent).RouteData.Values["vendorId"].ToString());
    if (!(await slidersComponent.StaticCacheManager.GetAsync<IDictionary<string, bool>>(CacheKeys.WidgetDictionaryCacheKey, (Func<Task<IDictionary<string, bool>>>) (async () => (IDictionary<string, bool>) (await this._entityWidgetMappingService.GetAllEntityWidgetMappingsByEntityTypeAsync(Plugin.EntityType)).GroupBy<EntityWidgetMapping, string>((Func<EntityWidgetMapping, string>) (x => x.WidgetZone)).ToDictionary<IGrouping<string, EntityWidgetMapping>, string, bool>((Func<IGrouping<string, EntityWidgetMapping>, string>) (x => x.Key), (Func<IGrouping<string, EntityWidgetMapping>, bool>) (y => true))))).ContainsKey(widgetZone))
      return (IViewComponentResult) ((ViewComponent) slidersComponent).Content(string.Empty);
    Customer customer = await slidersComponent._workContext.GetCurrentCustomerAsync();
    int workingLanguageId = ((BaseEntity) await slidersComponent._workContext.GetWorkingLanguageAsync()).Id;
    int currentStoreId = ((BaseEntity) await slidersComponent._storeContext.GetCurrentStoreAsync()).Id;
    bool secured = slidersComponent._webHelper.IsCurrentConnectionSecured();
    ICustomerService icustomerService = slidersComponent.CustomerService;
    int[] customerRoleIdsAsync = await icustomerService.GetCustomerRoleIdsAsync(await slidersComponent._workContext.GetCurrentCustomerAsync(), false);
    icustomerService = (ICustomerService) null;
    IList<int> intList = (IList<int>) customerRoleIdsAsync;
    CacheKey cacheKey = slidersComponent.StaticCacheManager.PrepareKeyForDefaultCache(CacheKeys.CacheKey, new object[11]
    {
      (object) customer,
      (object) intList,
      (object) productId,
      (object) categoryId,
      (object) manufacturerId,
      (object) topicId,
      (object) vendorId,
      (object) widgetZone,
      (object) workingLanguageId,
      (object) currentStoreId,
      (object) secured
    });
    IList<SliderCachedModel> sliderCachedModels = await slidersComponent.StaticCacheManager.GetAsync<IList<SliderCachedModel>>(cacheKey, (Func<Task<IList<SliderCachedModel>>>) (async () => await this.GetPublicSliderModelsAsync(customer, productId, categoryId, manufacturerId, topicId, vendorId, widgetZone)));
    if (sliderCachedModels.Count == 0)
      return (IViewComponentResult) ((ViewComponent) slidersComponent).Content(string.Empty);
    SlidersModel slidersModel1 = new SlidersModel();
    SlidersModel slidersModel2 = slidersModel1;
    slidersModel2.Theme = await ThemeHelper.GetPluginThemeAsync("SevenSpikes.Nop.Plugins.AnywhereSliders");
    slidersModel1.Sliders = sliderCachedModels;
    SlidersModel model = slidersModel1;
    slidersModel2 = (SlidersModel) null;
    slidersModel1 = (SlidersModel) null;
    foreach (Store store in (IEnumerable<Store>) await slidersComponent._storeService.GetAllStoresAsync())
    {
      string folderPath = slidersComponent._customCssHelper.GetFolderPath();
      if (!File.Exists($"{folderPath}\\{await slidersComponent._customCssHelper.GetFileNameAsync(((BaseEntity) store).Id)}"))
      {
        await slidersComponent._customCssHelper.WriteCustomCssToFileAsync();
        break;
      }
      folderPath = (string) null;
    }
    return (IViewComponentResult) ((NopViewComponent) slidersComponent).View<SlidersModel>("AnywhereSliders", model);
  }

  private async Task<IList<SliderCachedModel>> GetPublicSliderModelsAsync(
    Customer customer,
    int productId,
    int categoryId,
    int manufacturerId,
    int topicId,
    int vendorId,
    string widgetZone)
  {
    IList<Slider> byWidgetZoneAsync = await this._sliderService.GetSlidersByWidgetZoneAsync(widgetZone);
    List<Slider> sliders = new List<Slider>();
    foreach (Slider slider in (IEnumerable<Slider>) byWidgetZoneAsync)
    {
      bool flag = await this._storeMappingService.AuthorizeAsync<Slider>(slider);
      if (flag)
        flag = ((BaseEntity) await this._workContext.GetWorkingLanguageAsync()).Id == slider.LanguageId || slider.LanguageId == 0;
      if (flag)
        sliders.Add(slider);
    }
    if (sliders.Count > 0)
    {
      sliders = await AsyncIEnumerableExtensions.WhereAwait<Slider>((IEnumerable<Slider>) sliders, (Func<Slider, ValueTask<bool>>) (async x =>
      {
        Schedule andEntityIdAsync = await this._schedulingService.GetScheduleByEntityTypeAndEntityIdAsync(Plugin.EntityType, x.Id);
        return andEntityIdAsync != null && this._schedulingChecker.Check(andEntityIdAsync);
      })).ToListAsync<Slider>();
      sliders = await AsyncIEnumerableExtensions.WhereAwait<Slider>((IEnumerable<Slider>) sliders, (Func<Slider, ValueTask<bool>>) (async x =>
      {
        Condition condition = await this._conditionService.GetConditionByEntityTypeAndEntityIdAsync(Plugin.EntityType, x.Id, true);
        if (condition == null)
          return false;
        List<BaseEntity> baseEntityList = new List<BaseEntity>()
        {
          (BaseEntity) customer
        };
        if (productId != 0)
        {
          Product productByIdAsync = await this._productService.GetProductByIdAsync(productId);
          baseEntityList.Add((BaseEntity) productByIdAsync);
          baseEntityList.Add((BaseEntity) new ProductSpecification(productByIdAsync));
        }
        if (categoryId != 0)
          baseEntityList.Add((BaseEntity) await this._categoryService.GetCategoryByIdAsync(categoryId));
        if (manufacturerId != 0)
          baseEntityList.Add((BaseEntity) await this._manufacturerService.GetManufacturerByIdAsync(manufacturerId));
        if (topicId != 0)
          baseEntityList.Add((BaseEntity) await this._topicService.GetTopicByIdAsync(topicId));
        if (vendorId != 0)
          baseEntityList.Add((BaseEntity) await this._vendorService.GetVendorByIdAsync(vendorId));
        return await this._conditionChecker.CheckAsync(condition, (IList<BaseEntity>) baseEntityList);
      })).ToListAsync<Slider>();
    }
    IList<SliderCachedModel> list = (IList<SliderCachedModel>) sliders.Select<Slider, Task<SliderCachedModel>>((Func<Slider, Task<SliderCachedModel>>) (async x => await this.PrepareSliderCachedModelAsync(x, $"WidgetSlider-{widgetZone}-{x.Id}"))).Select<Task<SliderCachedModel>, SliderCachedModel>((Func<Task<SliderCachedModel>, SliderCachedModel>) (x => x.Result)).ToList<SliderCachedModel>();
    sliders = (List<Slider>) null;
    return list;
  }

  private async Task<SliderCachedModel> PrepareSliderCachedModelAsync(
    Slider slider,
    string sliderHtmlElementId)
  {
    AnywhereSlidersComponent slidersComponent = this;
    // ISSUE: reference to a compiler-generated method
    List<SlidePublicModel> list = (await slidersComponent._sliderService.GetAllVisibleSlidesAsync(slider.Id)).Select<Slide, Task<SlidePublicModel>>(new Func<Slide, Task<SlidePublicModel>>(slidersComponent.\u003CPrepareSliderCachedModelAsync\u003Eb__26_0)).Select<Task<SlidePublicModel>, SlidePublicModel>((Func<Task<SlidePublicModel>, SlidePublicModel>) (x => x.Result)).ToList<SlidePublicModel>();
    return new SliderCachedModel()
    {
      SliderId = slider.Id,
      SliderHtmlElementId = sliderHtmlElementId,
      PreLoadFirstImage = slider.PreLoadFirstSlide,
      Autoplay = slider.Autoplay,
      AutoplaySpeed = slider.AutoplaySpeed,
      Speed = slider.Speed,
      PauseOnHover = slider.PauseOnHover,
      Fade = slider.Fade,
      Dots = slider.Dots,
      Arrows = slider.Arrows,
      MobileBreakpoint = slider.MobileBreakpoint,
      CustomClass = slider.CustomClass,
      Slides = (IList<SlidePublicModel>) list
    };
  }
}
