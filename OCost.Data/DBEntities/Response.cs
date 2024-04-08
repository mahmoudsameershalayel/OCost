using OCost.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Data.DBEntities
{
    public class Response
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public Currency UnitPrice { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime ValidUntil { get; set; }
        public string Comment { get; set; } = string.Empty;
        public ResponseStatus Status { get; set; }
        public int RequestLineId { get; set; }
        public RequestLine RequestLine { get; set; } = new RequestLine();
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; } = new Supplier();

    }
}
