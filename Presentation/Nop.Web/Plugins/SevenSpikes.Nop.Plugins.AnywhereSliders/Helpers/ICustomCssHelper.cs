// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Helpers.ICustomCssHelper
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.Sliders;
using System.Threading.Tasks;

#nullable disable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Helpers;

public interface ICustomCssHelper
{
  Task SaveCustomCssAsync(Slider slider, string customCss);

  Task WriteCustomCssToFileAsync();

  Task<string> GetCustomCssAsync(Slider slider);

  Task<string> GetFileNameAsync(int storeId);

  string GetFolderPath();
}
