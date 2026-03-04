using Nop.Web.Framework.Models;
using System.Collections.Generic;

namespace Nop.Plugin.Widgets.NivoSlider.Models
{
    public record PublicInfoModel : BaseNopModel
    {
        public IList<SlideModel> Slides { get; set; }
    }
}