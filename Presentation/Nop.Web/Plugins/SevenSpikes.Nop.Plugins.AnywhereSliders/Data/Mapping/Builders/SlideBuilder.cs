// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Data.Mapping.Builders.SlideBuilder
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using FluentMigrator.Builders;
using FluentMigrator.Builders.Create.Table;
using Nop.Data.Extensions;
using Nop.Data.Mapping.Builders;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.Sliders;
using System.Data;

#nullable disable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Data.Mapping.Builders;

public class SlideBuilder : NopEntityBuilder<Slide>
{
  public virtual void MapEntity(CreateTableExpressionBuilder table)
  {
    ((IColumnOptionSyntax<ICreateTableColumnOptionOrWithColumnSyntax, ICreateTableColumnOptionOrForeignKeyCascadeOrWithColumnSyntax>) ((IColumnTypeSyntax<ICreateTableColumnOptionOrWithColumnSyntax>) ((ICreateTableWithColumnSyntax) FluentMigratorExtensions.ForeignKey<Slider>(((IColumnTypeSyntax<ICreateTableColumnOptionOrWithColumnSyntax>) table.WithColumn("SliderId")).AsInt32(), (string) null, (string) null, Rule.Cascade)).WithColumn("SlideType")).AsInt32()).NotNullable();
  }
}
