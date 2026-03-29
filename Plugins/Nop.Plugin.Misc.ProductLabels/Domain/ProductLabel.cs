using Nop.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Misc.ProductLabels.Domain
{
    public class ProductLabel : BaseEntity
    {
        public string LabelText { get; set; }
        public bool IsPublished { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedOnUtc { get; set; }
    }
}
