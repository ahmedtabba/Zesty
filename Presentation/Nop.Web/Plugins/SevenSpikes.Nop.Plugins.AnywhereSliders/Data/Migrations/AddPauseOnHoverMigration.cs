// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Data.Migrations.AddPauseOnHoverMigration
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
public class AddPauseOnHoverMigration : AutoReversingMigration
{
  protected IMigrationManager _migrationManager;

  public AddPauseOnHoverMigration(IMigrationManager migrationManager)
  {
    this._migrationManager = migrationManager;
  }

  public virtual void Up()
  {
    if (((MigrationBase) this).Schema.Table("SS_AS_AnywhereSlider").Column("PauseOnHover").Exists())
      return;
    ((IColumnOptionSyntax<IAlterTableColumnOptionOrAddColumnOrAlterColumnSyntax, IAlterTableColumnOptionOrAddColumnOrAlterColumnOrForeignKeyCascadeSyntax>) ((IColumnTypeSyntax<IAlterTableColumnOptionOrAddColumnOrAlterColumnSyntax>) ((IAlterTableAddColumnOrAlterColumnSyntax) ((MigrationBase) this).Alter.Table("SS_AS_AnywhereSlider")).AddColumn("PauseOnHover")).AsBoolean()).WithDefaultValue((object) false);
  }
}
