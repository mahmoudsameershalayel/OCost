
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Data.DBEntities
{
    public class ProductSupplier
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = new Product();
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; } = new Supplier();
    }
}
