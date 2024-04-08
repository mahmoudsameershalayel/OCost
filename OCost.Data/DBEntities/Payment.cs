using OCost.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Data.DBEntities
{
    public class Payment
    {
        public int Id { get; set; }
        public int BankId { get; set; }
        public Bank Bank { get; set; } = new Bank();
        public Currency Currency { get; set; }
    }
}
