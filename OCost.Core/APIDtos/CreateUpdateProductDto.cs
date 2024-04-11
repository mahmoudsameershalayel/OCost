using OCost.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Core.APIDtos
{
    public class CreateUpdateProductDto
    {
        [Required]
        public string NameEn { get; set; } = string.Empty;
        public string NameAr { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? ImageURL { get; set; }
        public Currency? UnitPrice { get; set; }
    }
}
