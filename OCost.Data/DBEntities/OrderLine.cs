using Ointernalata.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Data.DBEntities
{
    public class OrderLine
    {
        public int Id { get; set; }     
        public int Quantity { get; set; }
        public string UnitPrice { get; set; } = string.Empty;
        public double TotalPrice { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; } = new Order();
        public int ProductId { get; set; }
        public Product Product { get; set; } = new Product();
    }
}
