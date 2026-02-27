// Decompiled with JetBrains decompiler
// Type: SevenSpikes.Nop.Plugins.AnywhereSliders.Data.Migrations.SchemaMigration
// Assembly: SevenSpikes.Nop.Plugins.AnywhereSliders, Version=4.5.322.25, Culture=neutral, PublicKeyToken=null
// MVID: B1250110-0BDB-4DB1-9D3B-B9E308207D3F
// Assembly location: C:\Users\MSi\Desktop\NopCommerce\مجلد جديد\Plugins\SevenSpikes.Nop.Plugins.AnywhereSliders\SevenSpikes.Nop.Plugins.AnywhereSliders.dll

using Nop.Data.Migrations;
using SevenSpikes.Nop.Framework.Migrations;
using SevenSpikes.Nop.Plugins.AnywhereSliders.Domain.Sliders;
using System;
using System.Collections.Generic;

#nullable disable
namespace SevenSpikes.Nop.Plugins.AnywhereSliders.Data.Migrations;

[NopMigration]
public class SchemaMigration(IMigrationManager migrationManager) : Base7SpikesSchemaMigration(migrationManager)
{
  public virtual void Up()
  {
    this.CreateOrUpdateTableIfExist<Slider>("SS_AS_AnywhereSlider", Array.Empty<ForeignKeyInfo>());
    this.CreateOrUpdateTableIfExist<Slide>("SS_AS_Slide", new ForeignKeyInfo[1]
    {
      new ForeignKeyInfo()
      {
        FromTable = "SS_AS_Slide",
        ForeignColumn = "SliderId",
        ToTable = "SS_AS_AnywhereSlider",
        PrimaryColumn = "Id",
        OldForeignKeyNames = (IList<string>) new List<string>()
        {
          "SliderImage_Slider",
          "FK_SS_AS_SliderImage_SS_AS_AnywhereSlider_SliderId"
        }
      }
    });
  }

  public virtual void Down()
  {
    this.DeleteTablesIfExist(new string[2]
    {
      "SS_AS_Slide",
      "SS_AS_AnywhereSlider"
    });
  }
}
