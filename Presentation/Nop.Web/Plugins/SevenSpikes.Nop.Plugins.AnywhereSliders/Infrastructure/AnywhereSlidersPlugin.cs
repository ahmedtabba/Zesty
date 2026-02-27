// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Infrastructure.AnywhereSlidersPlugin
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Nop.Core.Domain.Cms;
using Nop.Services.Configuration;
using SevenSpikes.Nop.Conditions.Services;
using SevenSpikes.Nop.Framework.Plugin;
using SevenSpikes.Nop.Mappings.Services;
using SevenSpikes.Nop.Scheduling.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Infrastructure;

public class AnywhereSlidersPlugin : BaseAdminWidgetPlugin7Spikes
{
  private readonly 
  #nullable disable
  IConditionsInstallerService _conditionsInstallerService;
  private readonly IMappingInstallerService _mappingInstallerService;
  private readonly ISchedulingInstallerService _schedulingInstallerService;
  private readonly ISettingService _settingService;
  private readonly WidgetSettings _widgetSettings;
  private static readonly List<MenuItem7Spikes> MenuItems;

  private static bool IsTrialVersion => false;

  public AnywhereSlidersPlugin(
    IConditionsInstallerService conditionsInstallerService,
    IMappingInstallerService mappingInstallerService,
    ISchedulingInstallerService schedulingInstallerService,
    ISettingService settingService,
    WidgetSettings widgetSettings)
    : base(AnywhereSlidersPlugin.MenuItems, "SevenSpikes.Plugins.AnywhereSliders.Admin.Menu.MenuName", "SevenSpikes.Nop.Plugins.AnywhereSliders", AnywhereSlidersPlugin.IsTrialVersion, "http://www.nop-templates.com/anywhere-sliders-plugin-for-nopcommerce")
  {
    this._conditionsInstallerService = conditionsInstallerService;
    this._mappingInstallerService = mappingInstallerService;
    this._schedulingInstallerService = schedulingInstallerService;
    this._settingService = settingService;
    this._widgetSettings = widgetSettings;
  }

  public virtual string GetConfigurationPageUrl()
  {
    return ((BaseAdminPlugin7Spikes) this).StoreLocation + "Admin/AnywhereSlidersAdmin/List";
  }

  public virtual string GetWidgetViewComponentName(string widgetZone) => "AnywhereSliders";

  protected virtual async Task InstallAdditionalSettingsAsync()
  {
    await this._conditionsInstallerService.InstallConditionsForEntityAsync(SevenSpikes.Nop.Plugins.AnywhereSliders.Infrastructure.Constants.Plugin.EntityType);
    await this._mappingInstallerService.InstallMappingsForEntityAsync(SevenSpikes.Nop.Plugins.AnywhereSliders.Infrastructure.Constants.Plugin.EntityType);
    await this._schedulingInstallerService.InstallSchedulingForEntityAsync(SevenSpikes.Nop.Plugins.AnywhereSliders.Infrastructure.Constants.Plugin.EntityType);
    if (!this._widgetSettings.ActiveWidgetSystemNames.Contains("SevenSpikes.Nop.Plugins.AnywhereSliders"))
    {
      this._widgetSettings.ActiveWidgetSystemNames.Add("SevenSpikes.Nop.Plugins.AnywhereSliders");
      await this._settingService.SaveSettingAsync<WidgetSettings>(this._widgetSettings, 0);
    }
    if (!this._widgetSettings.ActiveWidgetSystemNames.Contains("Widgets.NivoSlider"))
      return;
    this._widgetSettings.ActiveWidgetSystemNames.Remove("Widgets.NivoSlider");
    await this._settingService.SaveSettingAsync<WidgetSettings>(this._widgetSettings, 0);
  }

  protected virtual async Task UninstallAdditionalSettingsAsync()
  {
    await this._conditionsInstallerService.UnInstallConditionsForEntityAsync(SevenSpikes.Nop.Plugins.AnywhereSliders.Infrastructure.Constants.Plugin.EntityType);
    await this._mappingInstallerService.UnInstallMappingsForEntityAsync(SevenSpikes.Nop.Plugins.AnywhereSliders.Infrastructure.Constants.Plugin.EntityType);
    await this._schedulingInstallerService.UnInstallSchedulingForEntityAsync(SevenSpikes.Nop.Plugins.AnywhereSliders.Infrastructure.Constants.Plugin.EntityType);
  }

  static AnywhereSlidersPlugin()
  {
    List<MenuItem7Spikes> menuItem7SpikesList = new List<MenuItem7Spikes>();
    MenuItem7Spikes menuItem7Spikes = new MenuItem7Spikes();
    ((MenuItem7Spikes) ref menuItem7Spikes).SubMenuName = "SevenSpikes.Plugins.AnywhereSliders.Admin.Submenus.ManageSliders";
    ((MenuItem7Spikes) ref menuItem7Spikes).SubMenuRelativePath = "AnywhereSlidersAdmin/List";
    menuItem7SpikesList.Add(menuItem7Spikes);
    AnywhereSlidersPlugin.MenuItems = menuItem7SpikesList;
  }
}
