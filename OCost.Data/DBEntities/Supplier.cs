using OCoast.Data.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Data.DBEntities
{
    public class Supplier
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; } = string.Empty;
        public ApplicationUser ApplicationUser { get; set; } = new ApplicationUser();
        public List<ProductSupplier> ProductSuppliers { get; set; } = new List<ProductSupplier>();
        public List<RequestSupplier> RequestSuppliers { get; set; } = new List<RequestSupplier>();
    }
}
