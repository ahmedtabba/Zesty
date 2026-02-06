using FluentMigrator;
using Nop.Data.Migrations;

namespace Nop.Data.Migrations
{
    [NopMigration("2026-02-06 02:00:00", "Add HoverPictureId to Category table and make it nullable", MigrationProcessType.Update)]
    public class AddHoverPictureIdToCategory : MigrationBase
    {
        public override void Up()
        {
            if (!Schema.Table("Category").Column("HoverPictureId").Exists())
            {
                Alter.Table("Category")
                    .AddColumn("HoverPictureId")
                    .AsInt32()
                    .Nullable();
            }
        }
        public override void Down()
        {
            
        }

    }
}
