using Microsoft.AspNetCore.Identity;
using OCoast.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCoast.Data.DBEntities
{
    public class ApplicationUser : IdentityUser 
    {
        public string FullName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public UserType UserType { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime? Created_At { get; set; } = DateTime.Now;
        public string? Created_By { get; set; }
        public DateTime? Updated_at { get; set; } = DateTime.Now;
        public string? Updated_by { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string? City { get; set; } = string.Empty;
        public string? Country { get; set; } = string.Empty;
        public string? PostCode { get; set; } = string.Empty;
        public string? ImageURL { get; set; }
    }
}
