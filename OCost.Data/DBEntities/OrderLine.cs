using OCost.Core.Enums;
using Ointernalata.DBEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Data.DBEntities
{
    public class OrderLine
    {
        [Column("OrderLineId")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Order line quantity is required.")]
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }

        [Required(ErrorMessage = "Order line currency is required.")]
        public Currency? UnitPrice { get; set; }
        [ForeignKey(nameof(Order))]
        public int OrderId { get; set; }
        public Order? Order { get; set; }
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product?Product { get; set; }
    }
}
