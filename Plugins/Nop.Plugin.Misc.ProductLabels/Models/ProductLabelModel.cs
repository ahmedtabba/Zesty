using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Misc.ProductLabels.Models
{
    public class ProductLabelModel
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        [Required]
        public string LabelText { get; set; }

        public bool IsPublished { get; set; }

        public int DisplayOrder { get; set; }
    }
}
