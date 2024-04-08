using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Data.DBEntities
{
    public class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string AccountNo { get; set; }  = string.Empty;
        public string IBAN { get; set; } = string.Empty;
        public string SortCode { get; set; } = string.Empty ;

    }
}
