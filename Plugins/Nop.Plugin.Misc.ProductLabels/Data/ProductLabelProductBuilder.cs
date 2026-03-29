using FluentMigrator.Builders.Create.Table;
using Nop.Data.Mapping.Builders;
using Nop.Plugin.Misc.ProductLabels.Domain;
using Nop.Data.Extensions;

namespace Nop.Plugin.Misc.ProductLabels.Data
{
    public class ProductLabelProductBuilder : NopEntityBuilder<ProductLabelProduct>
    {
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(ProductLabelProduct.ProductLabelId)).AsInt32().ForeignKey<ProductLabel>()
                .WithColumn(nameof(ProductLabelProduct.ProductId)).AsInt32().ForeignKey<Nop.Core.Domain.Catalog.Product>();
        }
    }
}
