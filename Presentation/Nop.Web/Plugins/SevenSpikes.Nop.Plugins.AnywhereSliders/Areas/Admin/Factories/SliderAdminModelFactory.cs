// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Factories.SliderAdminModelFactory
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.DependencyInjection;
using Nop.Core;
using Nop.Core.Domain.Localization;
using Nop.Core.Infrastructure;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using SevenSpikes.Nop.Conditions.Domain;
using SevenSpikes.Nop.Conditions.Services;
using SevenSpikes.Nop.Framework;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Extensions;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Sliders;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.Sliders;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Helpers;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Infrastructure.Constants;
using SevenSpikes.Nop.Scheduling.Domain;
using SevenSpikes.Nop.Scheduling.Helpers;
using SevenSpikes.Nop.Scheduling.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable enable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Factories;

public class SliderAdminModelFactory : ISliderAdminModelFactory
{
  private 
  #nullable disable
  ISchedulingService _schedulingService;
  private readonly IConditionService _conditionService;
  private readonly ISchedulingChecker _schedulingChecker;
  private readonly ILanguageService _languageService;
  private readonly ICustomCssHelper _customCssHelper;
  private readonly ISettingService _settingService;
  private readonly IStoreContext _storeContext;

  public SliderAdminModelFactory(
    ISchedulingService schedulingService,
    IConditionService conditionService,
    ISchedulingChecker schedulingChecker,
    ILanguageService languageService,
    ICustomCssHelper customCssHelper,
    ISettingService settingService,
    IStoreContext storeContext)
  {
    this._schedulingService = schedulingService;
    this._conditionService = conditionService;
    this._schedulingChecker = schedulingChecker;
    this._languageService = languageService;
    this._customCssHelper = customCssHelper;
    this._settingService = settingService;
    this._storeContext = storeContext;
  }

  public IList<SliderModel> PrepareSlidersList(IList<Slider> sliders)
  {
    return (IList<SliderModel>) sliders.Select<Slider, Task<SliderModel>>((Func<Slider, Task<SliderModel>>) (async x =>
    {
      SliderModel sliderModel = new SliderModel()
      {
        Id = x.Id,
        SystemName = x.SystemName
      };
      Schedule schedule = await this._schedulingService.GetScheduleByEntityTypeAndEntityIdAsync(Plugin.EntityType, x.Id);
      Condition condition = await this._conditionService.GetConditionByEntityTypeAndEntityIdAsync(Plugin.EntityType, x.Id, true);
      bool isActive = false;
      if (schedule != null && condition != null)
      {
        isActive = this._schedulingChecker.Check(schedule);
        if (isActive)
        {
          isActive = condition.Active;
          if (isActive)
          {
            if ((await this._conditionService.GetConditionGroupsByConditionAsync(((BaseEntity) condition).Id)).Count == 1)
            {
              Task<ConditionGroup> byConditionAsync = this._conditionService.GetDefaultConditionGroupByConditionAsync(((BaseEntity) condition).Id);
              if (byConditionAsync != null)
              {
                ConditionStatement conditionStatement = (await this._conditionService.GetConditionStatementsByConditionGroupAsync(byConditionAsync.Id)).FirstOrDefault<ConditionStatement>();
                if (conditionStatement != null && conditionStatement.Value == "Fail")
                  isActive = false;
              }
            }
          }
        }
      }
      sliderModel.IsActive = isActive;
      SliderModel sliderModel1 = sliderModel;
      sliderModel = (SliderModel) null;
      schedule = (Schedule) null;
      condition = (Condition) null;
      return sliderModel1;
    })).Select<Task<SliderModel>, SliderModel>((Func<Task<SliderModel>, SliderModel>) (x => x.Result)).ToList<SliderModel>();
  }

  public async Task<SliderModel> PrepareSliderModelAsync()
  {
    ISettingService isettingService = this._settingService;
    bool settingByKeyAsync1 = await isettingService.GetSettingByKeyAsync<bool>("AnywhereSliderSettings.DoNotUseCustomCSSInAnywhereSliders", false, ((BaseEntity) await this._storeContext.GetCurrentStoreAsync()).Id, true);
    isettingService = (ISettingService) null;
    bool disableCustomCss = settingByKeyAsync1;
    SliderModel sliderModel1 = new SliderModel();
    sliderModel1.Autoplay = true;
    sliderModel1.AutoplaySpeed = 3000;
    sliderModel1.Speed = 1000;
    SliderModel sliderModel2 = sliderModel1;
    isettingService = this._settingService;
    bool settingByKeyAsync2 = await isettingService.GetSettingByKeyAsync<bool>("AnywhereSlidersSettings.PauseOnHover", false, ((BaseEntity) await this._storeContext.GetCurrentStoreAsync()).Id, false);
    isettingService = (ISettingService) null;
    sliderModel2.PauseOnHover = settingByKeyAsync2;
    sliderModel1.Fade = true;
    sliderModel1.Dots = false;
    sliderModel1.Arrows = false;
    sliderModel1.MobileBreakpoint = 768 /*0x0300*/;
    sliderModel1.DisableCustomCss = disableCustomCss;
    SliderModel model = sliderModel1;
    sliderModel2 = (SliderModel) null;
    sliderModel1 = (SliderModel) null;
    sliderModel1 = model;
    sliderModel1.Languages = await this.GetAvailableLanguagesAsync();
    sliderModel1 = (SliderModel) null;
    SelectListItem selectListItem = model.Languages.FirstOrDefault<SelectListItem>((Func<SelectListItem, bool>) (l => l.Selected));
    model.Language = selectListItem == null ? "0" : selectListItem.Value;
    SliderToWidgetModel sliderToWidgetModel = model.AddSliderToWidget;
    sliderToWidgetModel.SupportedWidgetZones = new SelectList((IEnumerable) await this.GetSupportedWidgetZonesAsync());
    sliderToWidgetModel = (SliderToWidgetModel) null;
    model.IsTrialVersion = false;
    SliderModel sliderModel = model;
    model = (SliderModel) null;
    return sliderModel;
  }

  public async Task<SliderModel> PrepareSliderModelAsync(Slider slider)
  {
    ISettingService isettingService = this._settingService;
    bool settingByKeyAsync = await isettingService.GetSettingByKeyAsync<bool>("AnywhereSliderSettings.DoNotUseCustomCSSInAnywhereSliders", false, ((BaseEntity) await this._storeContext.GetCurrentStoreAsync()).Id, true);
    isettingService = (ISettingService) null;
    bool disableCustomCss = settingByKeyAsync;
    SliderModel model = slider.ToModel();
    SliderModel sliderModel = model;
    sliderModel.Languages = await this.GetAvailableLanguagesAsync();
    sliderModel = (SliderModel) null;
    model.Language = slider.LanguageId.ToString();
    sliderModel = model;
    sliderModel.CustomCss = await this._customCssHelper.GetCustomCssAsync(slider);
    sliderModel = (SliderModel) null;
    SliderToWidgetModel sliderToWidgetModel = model.AddSliderToWidget;
    sliderToWidgetModel.SupportedWidgetZones = new SelectList((IEnumerable) await this.GetSupportedWidgetZonesAsync());
    sliderToWidgetModel = (SliderToWidgetModel) null;
    model.IsTrialVersion = false;
    model.DisableCustomCss = disableCustomCss;
    SliderModel sliderModel1 = model;
    model = (SliderModel) null;
    return sliderModel1;
  }

  private async Task<IEnumerable<string>> GetSupportedWidgetZonesAsync()
  {
    return await EngineContext.Current.Resolve<IInstallHelper>((IServiceScope) null).GetSupportedWidgetZonesAsync("SevenSpikes.Nop.Plugins.AnywhereSliders");
  }

  public async Task<IList<SelectListItem>> GetAvailableLanguagesAsync()
  {
    List<SelectListItem> languagesList = new List<SelectListItem>()
    {
      new SelectListItem()
      {
        Selected = true,
        Text = "All",
        Value = "0"
      }
    };
    languagesList.AddRange((await this._languageService.GetAllLanguagesAsync(false, 0)).Select<Language, SelectListItem>((Func<Language, SelectListItem>) (language => new SelectListItem()
    {
      Text = language.Name,
      Value = ((BaseEntity) language).Id.ToString()
    })));
    IList<SelectListItem> availableLanguagesAsync = (IList<SelectListItem>) languagesList;
    languagesList = (List<SelectListItem>) null;
    return availableLanguagesAsync;
  }
}
