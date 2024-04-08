using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Data.DBEntities
{
    public class RequestLine
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int RequestId { get; set; }
        public Request Request { get; set; } = new Request();
        public int ProductId { get; set; }
        public Product Product { get; set; } = new Product();
    }
}
