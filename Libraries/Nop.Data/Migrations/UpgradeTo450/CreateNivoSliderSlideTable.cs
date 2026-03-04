using FluentMigrator;
using Nop.Data.Migrations;

namespace Nop.Data.Migrations.UpgradeTo450
{
    [NopMigration("2026-05-04 04:00:00", "Create NivoSliderSlide Table ", MigrationProcessType.Update)]
    public class CreateNivoSliderSlideTable : MigrationBase
    {
        public override void Up()
        {
            if (!Schema.Table("NivoSliderSlide").Exists())
            {
                Create.Table("NivoSliderSlide")
                    .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                    .WithColumn("Text").AsString(1000).Nullable()
                    .WithColumn("Link").AsString(1000).Nullable()
                    .WithColumn("AltText").AsString(500).Nullable()
                    .WithColumn("CaptionHtml").AsString(int.MaxValue).Nullable()
                    .WithColumn("PictureId").AsInt32()
                    .WithColumn("PictureProductId").AsInt32().Nullable() // ✅ ضفنا الـ Product Picture ID
                    .WithColumn("DisplayOrder").AsInt32().WithDefaultValue(0)
                    .WithColumn("IsActive").AsBoolean().WithDefaultValue(true);
            }
        }

        public override void Down()
        {
            // Rollback غير مدعوم رسميًا
        }
    }
}