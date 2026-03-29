using Nop.Core;

namespace Nop.Plugin.Misc.ProductLabels.Domain
{
    public class ProductLabelProduct : BaseEntity
    {
        public int ProductLabelId { get; set; }
        public int ProductId { get; set; }
    }
}
