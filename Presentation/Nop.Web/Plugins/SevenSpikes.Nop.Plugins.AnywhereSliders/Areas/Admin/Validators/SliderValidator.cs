// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Validators.SliderValidator
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using FluentValidation;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Sliders;
using System;
using System.Linq.Expressions;

#nullable disable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Validators;

public class SliderValidator : AbstractValidator<SliderModel>
{
  public SliderValidator(ILocalizationService localizationService)
  {
    RuleBuilderOptionsExtension.WithMessageAwait<SliderModel, string>(DefaultValidatorExtensions.NotNull<SliderModel, string>((IRuleBuilder<SliderModel, string>) this.RuleFor<string>((Expression<Func<SliderModel, string>>) (x => x.SystemName))), localizationService.GetResourceAsync("SevenSpikes.Plugins.AnywhereSliders.Fields.SystemName.IsRequired"));
    RuleBuilderOptionsExtension.WithMessageAwait<SliderModel, int>(DefaultValidatorExtensions.NotNull<SliderModel, int>((IRuleBuilder<SliderModel, int>) this.RuleFor<int>((Expression<Func<SliderModel, int>>) (x => x.AutoplaySpeed))), localizationService.GetResourceAsync("SevenSpikes.Plugins.AnywhereSliders.Fields.AutoplaySpeed.IsRequired"));
    RuleBuilderOptionsExtension.WithMessageAwait<SliderModel, int>(DefaultValidatorExtensions.NotNull<SliderModel, int>((IRuleBuilder<SliderModel, int>) this.RuleFor<int>((Expression<Func<SliderModel, int>>) (x => x.Speed))), localizationService.GetResourceAsync("SevenSpikes.Plugins.AnywhereSliders.Fields.Speed.IsRequired"));
  }
}
