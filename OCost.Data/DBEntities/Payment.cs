using OCost.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Data.DBEntities
{
    public class Payment
    {
        [Column("PaymentId")]
        public int Id { get; set; }
        public Currency Currency { get; set; }
        [ForeignKey(nameof(Bank))]            
        public int BankId { get; set; }
        public Bank? Bank { get; set; } 
    }
}
