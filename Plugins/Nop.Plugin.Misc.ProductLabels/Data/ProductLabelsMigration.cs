using FluentMigrator;
using Nop.Data.Extensions;
using Nop.Data.Migrations;
using Nop.Plugin.Misc.ProductLabels.Domain;

namespace Nop.Plugin.Misc.ProductLabels.Data
{
    [NopMigration("2026/03/28 10:00:00:0000000", "ProductLabels schema", MigrationProcessType.Installation)]
    public class ProductLabelsMigration : AutoReversingMigration
    {
        public override void Up()
        {
            Create.TableFor<ProductLabel>();
            Create.TableFor<ProductLabelProduct>();
        }
    }
}