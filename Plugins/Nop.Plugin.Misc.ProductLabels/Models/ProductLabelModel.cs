using Microsoft.AspNetCore.Mvc.Rendering;
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
        public IList<int> SelectedProductIds { get; set; } = new List<int>();
        public IList<string> ProductNames { get; set; } = new List<string>();

        [Required]
        public string LabelText { get; set; }

        public bool IsPublished { get; set; }

        public int DisplayOrder { get; set; }
        public IList<SelectListItem> AvailableProducts { get; set; }
    }
}
