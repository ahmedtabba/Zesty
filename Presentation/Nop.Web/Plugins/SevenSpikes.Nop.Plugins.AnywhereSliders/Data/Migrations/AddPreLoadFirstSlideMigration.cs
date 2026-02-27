// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Data.Migrations.AddPreLoadFirstSlideMigration
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using FluentMigrator;
using FluentMigrator.Builders;
using FluentMigrator.Builders.Alter.Table;
using Nop.Data.Migrations;

#nullable disable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Data.Migrations;

[NopMigration]
public class AddPreLoadFirstSlideMigration : AutoReversingMigration
{
  protected IMigrationManager _migrationManager;

  public AddPreLoadFirstSlideMigration(IMigrationManager migrationManager)
  {
    this._migrationManager = migrationManager;
  }

  public virtual void Up()
  {
    if (((MigrationBase) this).Schema.Table("SS_AS_AnywhereSlider").Column("PreLoadFirstSlide").Exists())
      return;
    ((IColumnOptionSyntax<IAlterTableColumnOptionOrAddColumnOrAlterColumnSyntax, IAlterTableColumnOptionOrAddColumnOrAlterColumnOrForeignKeyCascadeSyntax>) ((IColumnTypeSyntax<IAlterTableColumnOptionOrAddColumnOrAlterColumnSyntax>) ((IAlterTableAddColumnOrAlterColumnSyntax) ((MigrationBase) this).Alter.Table("SS_AS_AnywhereSlider")).AddColumn("PreLoadFirstSlide")).AsBoolean()).WithDefaultValue((object) false);
  }
}
