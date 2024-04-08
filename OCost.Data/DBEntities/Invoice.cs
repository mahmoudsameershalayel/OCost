using OCost.Core.Enums;
using Ointernalata.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Data.DBEntities
{                                                           
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime AmountDue { get; set; }
        public InvoiceStatus Status { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; } = new Order(); 
        public int PaymentId { get; set; }
        public Payment Payment { get; set; } = new Payment();
    }
}
