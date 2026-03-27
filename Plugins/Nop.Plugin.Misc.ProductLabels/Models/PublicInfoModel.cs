using System.Collections.Generic;

namespace Nop.Plugin.Misc.ProductLabels.Models
{
    public class PublicInfoModel
    {
        public IList<ProductLabelPublicModel> Labels { get; set; } = new List<ProductLabelPublicModel>();

        public bool HasLabels => Labels.Count > 0;
    }
}