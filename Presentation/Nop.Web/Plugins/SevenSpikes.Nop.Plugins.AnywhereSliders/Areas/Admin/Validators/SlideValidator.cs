// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Validators.SlideValidator
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using FluentValidation;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Models.Sliders;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.Enums;
using System;
using System.Linq.Expressions;

#nullable disable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Areas.Admin.Validators;

public class SlideValidator : BaseNopValidator<SlideModel>
{
  public SlideValidator(ILocalizationService localizationService)
  {
    SlideValidator slideValidator = this;
    ((AbstractValidator<SlideModel>) this).RuleSet(NopValidationDefaults.ValidationRuleSet, (Action) (() =>
    {
      RuleBuilderOptionsExtension.WithMessageAwait<SlideModel, SlideType>(DefaultValidatorExtensions.IsInEnum<SlideModel, SlideType>((IRuleBuilder<SlideModel, SlideType>) ((AbstractValidator<SlideModel>) slideValidator).RuleFor<SlideType>((Expression<Func<SlideModel, SlideType>>) (x => x.Type))), localizationService.GetResourceAsync("SevenSpikes.Plugins.AnywhereSliders.Fields.Type.IsRequired"));
      RuleBuilderOptionsExtension.WithMessageAwait<SlideModel, string>(DefaultValidatorOptions.When<SlideModel, string>(DefaultValidatorExtensions.NotEmpty<SlideModel, string>((IRuleBuilder<SlideModel, string>) ((AbstractValidator<SlideModel>) slideValidator).RuleFor<string>((Expression<Func<SlideModel, string>>) (x => x.SystemName))), (Func<SlideModel, bool>) (x => x.Type == SlideType.Picture || x.Type == SlideType.Content), (ApplyConditionTo) 0), localizationService.GetResourceAsync("SevenSpikes.Plugins.AnywhereSliders.Fields.SystemName.IsRequired"));
      RuleBuilderOptionsExtension.WithMessageAwait<SlideModel, int>(DefaultValidatorOptions.When<SlideModel, int>(DefaultValidatorExtensions.GreaterThan<SlideModel, int>((IRuleBuilder<SlideModel, int>) ((AbstractValidator<SlideModel>) slideValidator).RuleFor<int>((Expression<Func<SlideModel, int>>) (x => x.PictureId)), 0), (Func<SlideModel, bool>) (x => x.Type == SlideType.Picture), (ApplyConditionTo) 0), localizationService.GetResourceAsync("SevenSpikes.Plugins.AnywhereSliders.Fields.Picture.IsRequired"));
      RuleBuilderOptionsExtension.WithMessageAwait<SlideModel, string>(DefaultValidatorOptions.When<SlideModel, string>(DefaultValidatorExtensions.NotEmpty<SlideModel, string>((IRuleBuilder<SlideModel, string>) ((AbstractValidator<SlideModel>) slideValidator).RuleFor<string>((Expression<Func<SlideModel, string>>) (x => x.Content))), (Func<SlideModel, bool>) (x => x.Type == SlideType.Content), (ApplyConditionTo) 0), localizationService.GetResourceAsync("SevenSpikes.Plugins.AnywhereSliders.Fields.Content.IsRequired"));
    }));
  }
}
