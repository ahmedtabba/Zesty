// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Factories.ISlideAdminModelFactory
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Sliders;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.Sliders;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable disable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Factories;

public interface ISlideAdminModelFactory
{
  IList<SlideModel> PrepareSlideListModel(IList<Slide> slides);

  Task PrepareSlideModelAsync(SlideModel model);

  Task<SlideModel> PrepareSlideModelAsync(Slide slide);
}
