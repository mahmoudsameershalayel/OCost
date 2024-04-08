using OCost.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Data.DBEntities
{
    public class Request
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DueDate { get; set; }
        public RequestStatus Status { get; set; }
        public List<RequestSupplier> RequestSuppliers { get; set; } = new List<RequestSupplier>();
    }
}
