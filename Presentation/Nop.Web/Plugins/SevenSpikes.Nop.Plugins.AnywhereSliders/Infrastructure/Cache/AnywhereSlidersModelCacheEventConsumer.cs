// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Infrastructure.Cache.AnywhereSlidersModelCacheEventConsumer
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Microsoft.Extensions.DependencyInjection;
using Nop.Core.Caching;
using Nop.Core.Events;
using Nop.Core.Infrastructure;
using Nop.Services.Events;
using SevenSpikes.Nop.Conditions.Domain;
using SevenSpikes.Nop.Mappings.Domain;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.Sliders;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Infrastructure.Constants;
using System;
using System.Threading.Tasks;

#nullable enable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Infrastructure.Cache;

public class AnywhereSlidersModelCacheEventConsumer : 
  IConsumer<
  #nullable disable
  EntityInsertedEvent<Slider>>,
  IConsumer<EntityDeletedEvent<Slider>>,
  IConsumer<EntityUpdatedEvent<Slider>>,
  IConsumer<EntityInsertedEvent<Slide>>,
  IConsumer<EntityDeletedEvent<Slide>>,
  IConsumer<EntityUpdatedEvent<Slide>>,
  IConsumer<EntityInsertedEvent<Condition>>,
  IConsumer<EntityDeletedEvent<Condition>>,
  IConsumer<EntityUpdatedEvent<Condition>>,
  IConsumer<EntityInsertedEvent<ConditionGroup>>,
  IConsumer<EntityDeletedEvent<ConditionGroup>>,
  IConsumer<EntityUpdatedEvent<ConditionGroup>>,
  IConsumer<EntityInsertedEvent<ConditionStatement>>,
  IConsumer<EntityDeletedEvent<ConditionStatement>>,
  IConsumer<EntityUpdatedEvent<ConditionStatement>>,
  IConsumer<EntityInsertedEvent<CustomerOverride>>,
  IConsumer<EntityDeletedEvent<CustomerOverride>>,
  IConsumer<EntityUpdatedEvent<CustomerOverride>>,
  IConsumer<EntityInsertedEvent<EntityWidgetMapping>>,
  IConsumer<EntityDeletedEvent<EntityWidgetMapping>>,
  IConsumer<EntityUpdatedEvent<EntityWidgetMapping>>
{
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

  public async Task HandleEventAsync(EntityInsertedEvent<Slider> eventMessage)
  {
    await this.StaticCacheManager.RemoveByPrefixAsync("nop.pres.anywheresliders.", Array.Empty<object>());
  }

  public async Task HandleEventAsync(EntityDeletedEvent<Slider> eventMessage)
  {
    await this.StaticCacheManager.RemoveByPrefixAsync("nop.pres.anywheresliders.", Array.Empty<object>());
  }

  public async Task HandleEventAsync(EntityUpdatedEvent<Slider> eventMessage)
  {
    await this.StaticCacheManager.RemoveByPrefixAsync("nop.pres.anywheresliders.", Array.Empty<object>());
  }

  public async Task HandleEventAsync(EntityInsertedEvent<Slide> eventMessage)
  {
    await this.StaticCacheManager.RemoveByPrefixAsync("nop.pres.anywheresliders.", Array.Empty<object>());
  }

  public async Task HandleEventAsync(EntityDeletedEvent<Slide> eventMessage)
  {
    await this.StaticCacheManager.RemoveByPrefixAsync("nop.pres.anywheresliders.", Array.Empty<object>());
  }

  public async Task HandleEventAsync(EntityUpdatedEvent<Slide> eventMessage)
  {
    await this.StaticCacheManager.RemoveByPrefixAsync("nop.pres.anywheresliders.", Array.Empty<object>());
  }

  public async Task HandleEventAsync(EntityInsertedEvent<Condition> eventMessage)
  {
    await this.StaticCacheManager.RemoveByPrefixAsync("nop.pres.anywheresliders.", Array.Empty<object>());
  }

  public async Task HandleEventAsync(EntityDeletedEvent<Condition> eventMessage)
  {
    await this.StaticCacheManager.RemoveByPrefixAsync("nop.pres.anywheresliders.", Array.Empty<object>());
  }

  public async Task HandleEventAsync(EntityUpdatedEvent<Condition> eventMessage)
  {
    await this.StaticCacheManager.RemoveByPrefixAsync("nop.pres.anywheresliders.", Array.Empty<object>());
  }

  public async Task HandleEventAsync(EntityInsertedEvent<ConditionGroup> eventMessage)
  {
    await this.StaticCacheManager.RemoveByPrefixAsync("nop.pres.anywheresliders.", Array.Empty<object>());
  }

  public async Task HandleEventAsync(EntityDeletedEvent<ConditionGroup> eventMessage)
  {
    await this.StaticCacheManager.RemoveByPrefixAsync("nop.pres.anywheresliders.", Array.Empty<object>());
  }

  public async Task HandleEventAsync(EntityUpdatedEvent<ConditionGroup> eventMessage)
  {
    await this.StaticCacheManager.RemoveByPrefixAsync("nop.pres.anywheresliders.", Array.Empty<object>());
  }

  public async Task HandleEventAsync(
    EntityInsertedEvent<ConditionStatement> eventMessage)
  {
    await this.StaticCacheManager.RemoveByPrefixAsync("nop.pres.anywheresliders.", Array.Empty<object>());
  }

  public async Task HandleEventAsync(
    EntityDeletedEvent<ConditionStatement> eventMessage)
  {
    await this.StaticCacheManager.RemoveByPrefixAsync("nop.pres.anywheresliders.", Array.Empty<object>());
  }

  public async Task HandleEventAsync(
    EntityUpdatedEvent<ConditionStatement> eventMessage)
  {
    await this.StaticCacheManager.RemoveByPrefixAsync("nop.pres.anywheresliders.", Array.Empty<object>());
  }

  public async Task HandleEventAsync(EntityInsertedEvent<CustomerOverride> eventMessage)
  {
    await this.StaticCacheManager.RemoveByPrefixAsync("nop.pres.anywheresliders.", Array.Empty<object>());
  }

  public async Task HandleEventAsync(EntityDeletedEvent<CustomerOverride> eventMessage)
  {
    await this.StaticCacheManager.RemoveByPrefixAsync("nop.pres.anywheresliders.", Array.Empty<object>());
  }

  public async Task HandleEventAsync(EntityUpdatedEvent<CustomerOverride> eventMessage)
  {
    await this.StaticCacheManager.RemoveByPrefixAsync("nop.pres.anywheresliders.", Array.Empty<object>());
  }

  public async Task HandleEventAsync(
    EntityInsertedEvent<EntityWidgetMapping> eventMessage)
  {
    if (eventMessage.Entity.EntityType != Plugin.EntityType)
      return;
    await this.StaticCacheManager.RemoveByPrefixAsync("nop.pres.anywheresliders.", Array.Empty<object>());
  }

  public async Task HandleEventAsync(
    EntityDeletedEvent<EntityWidgetMapping> eventMessage)
  {
    if (eventMessage.Entity.EntityType != Plugin.EntityType)
      return;
    await this.StaticCacheManager.RemoveByPrefixAsync("nop.pres.anywheresliders.", Array.Empty<object>());
  }

  public async Task HandleEventAsync(
    EntityUpdatedEvent<EntityWidgetMapping> eventMessage)
  {
    if (eventMessage.Entity.EntityType != Plugin.EntityType)
      return;
    await this.StaticCacheManager.RemoveByPrefixAsync("nop.pres.anywheresliders.", Array.Empty<object>());
  }
}
