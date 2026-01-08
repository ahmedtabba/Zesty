using FluentMigrator;
using Nop.Data.Migrations;
using static LinqToDB.Reflection.Methods.LinqToDB;

namespace Nop.Data.Migrations.UpgradeTo450
{
    [NopMigration("2026-01-05 01:00:00","Add CoverPictureId to News",  MigrationProcessType.Update)]
    public class AddCoverPictureIdToNews:MigrationBase
    {
        public override void Up()
        {
            if (!Schema.Table("News").Column("CoverPictureId").Exists())
            {
                Create.Column("CoverPictureId")
                    .OnTable("News")
                    .AsInt32()
                    .Nullable();
            }
        }
        public override void Down()
        {
            // no rollback
        }

    }
}
