using OCost.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Data.DBEntities
{
    public class Product
    {
        [Column("ProductId")]
        public int Id { get; set; }
        [Required(ErrorMessage = "The product name in english is required.")]
        public string NameEn { get; set; } = string.Empty;
        [Required(ErrorMessage = "The product name in arabic is required.")]
        public string NameAr { get; set; } = string.Empty;
        [Required(ErrorMessage = "The product description in english is required.")]
        public string DescriptionEn { get; set; } = string.Empty;
        [Required(ErrorMessage = "The product description in arabic is required.")]
        public string DescriptionAr { get; set; } = string.Empty;
        public string? ImageURL { get; set; }
        public Currency? UnitPrice { get; set; }
        public List<ProductSupplier> ProductSuppliers { get; set; } = [];
        public List<ProductCategory> ProductCategories { get; set; }  = [];
    }
}
