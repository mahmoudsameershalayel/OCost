
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Data.DBEntities
{
    public class ProductSupplier
    {
        [Column("ProductSupplierId")]
        public int Id { get; set; }
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        [ForeignKey(nameof(Supplier))]
        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }
    }
}
