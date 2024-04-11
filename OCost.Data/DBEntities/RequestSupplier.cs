using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Data.DBEntities
{
    public class RequestSupplier
    {
        [Column("RequestSupplierId")]
        public int Id { get; set; }
        [ForeignKey(nameof(Supplier))]
        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }
        [ForeignKey(nameof(Request))]
        public int RequestId { get; set; }
        public Request? Request { get; set; }
    }
}
