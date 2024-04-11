using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                        
namespace OCost.Data.DBEntities
{
    public class RequestLine
    {
        [Column("RequestLineId")]
        public int Id { get; set; }
        public int Quantity { get; set; }
        [ForeignKey(nameof(Request))]
        public int RequestId { get; set; }
        public Request? Request { get; set; }
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
