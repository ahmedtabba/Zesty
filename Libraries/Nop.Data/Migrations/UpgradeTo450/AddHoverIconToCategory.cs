using FluentMigrator;
using Nop.Data.Migrations;

namespace Nop.Data.Migrations
{
    [NopMigration("2026-02-25 19:00:00", "Add SecondPictureId to Category")]
    public class AddSecondPictureToCategory : Migration
    {
        public override void Up()
        {
            Alter.Table("Category")
                .AddColumn("HoverIconId")
                .AsInt32()
                .Nullable();
        }

        public override void Down()
        {
            Delete.Column("HoverIconId")
                .FromTable("Category");
        }
    }
}