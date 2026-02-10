using Nop.Web.Framework.Models;

namespace Nop.Plugin.Widgets.WhatCustomerSays.Models;

public record WhatCustomerSaysModel : BaseNopEntityModel
{
    public string Name { get; set; }
    public string Job { get; set; }
    public string Description { get; set; }

    public bool Published { get; set; }
    public int DisplayOrder { get; set; }

    public int AvatarPictureId { get; set; }
}
