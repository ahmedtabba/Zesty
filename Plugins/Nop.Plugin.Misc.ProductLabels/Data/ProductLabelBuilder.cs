using FluentMigrator.Builders.Create.Table;
using Nop.Data.Extensions;
using Nop.Data.Mapping.Builders;
using Nop.Plugin.Misc.ProductLabels.Domain;

namespace Nop.Plugin.Misc.ProductLabels.Data
{
    public class ProductLabelBuilder : NopEntityBuilder<ProductLabel>
    {
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(ProductLabel.Id)).AsInt32().PrimaryKey().Identity()
                .WithColumn(nameof(ProductLabel.LabelText)).AsString(400).NotNullable()

                .WithColumn(nameof(ProductLabel.IsPublished)).AsBoolean().WithDefaultValue(true)

                .WithColumn(nameof(ProductLabel.DisplayOrder)).AsInt32().WithDefaultValue(0)

                .WithColumn(nameof(ProductLabel.CreatedOnUtc)).AsDateTime2().NotNullable();
        }
    }
}