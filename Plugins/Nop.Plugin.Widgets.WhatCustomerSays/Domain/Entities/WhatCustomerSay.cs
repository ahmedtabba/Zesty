using Nop.Core;

namespace Nop.Plugin.Widgets.WhatCustomerSays.Domain.Entities;

public class WhatCustomerSay : BaseEntity
{
    public string Name { get; set; }
    public string Job { get; set; }
    public string Description { get; set; }

    public bool Published { get; set; }
    public int DisplayOrder { get; set; }

    public int AvatarPictureId { get; set; }
}
