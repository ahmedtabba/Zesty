using FluentMigrator;
using Nop.Data.Extensions;
using Nop.Data.Migrations;
using Nop.Plugin.Widgets.WhatCustomerSays.Domain.Entities;

namespace Nop.Plugin.Widgets.WhatCustomerSays.Data;

[NopMigration("2026-02-10 00:00:00", "WhatCustomerSays table", MigrationProcessType.Installation)]
public class WhatCustomerSaysMigration : AutoReversingMigration
{
    public override void Up()
    {
        Create.TableFor<WhatCustomerSay>();
    }
}
