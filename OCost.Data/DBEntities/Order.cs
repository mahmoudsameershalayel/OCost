using OCoast.Data.DBEntities;
using OCost.Core.Enums;
using OCost.Data.DBEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ointernalata.DBEntities
{
    public class Order
    {
        [Column("OrderId")]
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
        public OrderStatus Status { get; set; }
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}
