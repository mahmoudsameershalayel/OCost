using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Data.DBEntities
{
    public class RequestSupplier
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; } = new Supplier();
        public int RequestId { get; set; }
        public Request Request { get; set; } = new Request();
    }
}
