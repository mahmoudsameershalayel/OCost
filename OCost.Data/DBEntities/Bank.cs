using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Data.DBEntities
{
    public class Bank
    {
        [Column("BankId")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Bank name in english is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name in english is 60 characters.")]
        public string NameEn { get; set; } = string.Empty;
        [Required(ErrorMessage = "Bank name in arabic is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name in arabic is 60 characters.")]
        public string NameAr { get; set; } = string.Empty;
        public string AccountNo { get; set; }  = string.Empty;
        public string IBAN { get; set; } = string.Empty;
        public string SortCode { get; set; } = string.Empty ;

    }
}
