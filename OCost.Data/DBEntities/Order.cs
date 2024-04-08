using OCoast.Data.DBEntities;
using OCost.Core.Enums;
using OCost.Data.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ointernalata.DBEntities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
        public OrderStatus Status { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = new Customer();
    }
}
