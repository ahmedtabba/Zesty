using FluentMigrator.Builders.Create.Table;
using Nop.Data.Mapping.Builders;
using Nop.Plugin.Widgets.WhatCustomerSays.Domain.Entities;

namespace Nop.Plugin.Widgets.WhatCustomerSays.Data;

public class WhatCustomerSaysBuilder : NopEntityBuilder<WhatCustomerSay>
{
    public override void MapEntity(CreateTableExpressionBuilder table)
    {
        table
            .WithColumn(nameof(WhatCustomerSay.Name)).AsString(400).NotNullable()
            .WithColumn(nameof(WhatCustomerSay.Job)).AsString(400).Nullable()
            .WithColumn(nameof(WhatCustomerSay.Description)).AsString(int.MaxValue).Nullable()
            .WithColumn(nameof(WhatCustomerSay.Published)).AsBoolean()
            .WithColumn(nameof(WhatCustomerSay.DisplayOrder)).AsInt32()
            .WithColumn(nameof(WhatCustomerSay.AvatarPictureId)).AsInt32();
    }
}
