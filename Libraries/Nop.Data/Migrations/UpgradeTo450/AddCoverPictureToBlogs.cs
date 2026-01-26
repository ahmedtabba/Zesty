using FluentMigrator;
using Nop.Data.Migrations;

namespace Nop.Data.Migrations.UpgradeTo450
{
    [NopMigration(
        "2026-01-25 01:00:00",
        "Add PictureId to BlogPost",
        MigrationProcessType.Update)]
    public class AddPictureIdToBlogPost : MigrationBase
    {
        public override void Up()
        {
            if (!Schema.Table("BlogPost").Column("PictureId").Exists())
            {
                Create.Column("PictureId")
                    .OnTable("BlogPost")
                    .AsInt32()
                    .NotNullable()
                    .WithDefaultValue(0);
            }
        }

        public override void Down()
        {
            // nop policy: no rollback
        }
    }
}
