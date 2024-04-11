using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Data.DBEntities
{
    public class Category
    {
        [Column("CategoryId")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Category name in english is required.")]
        public string? NameEn { get; set; }
        [Required(ErrorMessage = "Category name in arabic is required.")]
        public string? NameAr { get; set; }
        public List<ProductCategory> ProductCategories { get; set; } = [];
    }
}
