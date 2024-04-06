using OCoast.Data.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCoast.API.Infrastructure.Services.ApplicationUserServices
{
    public interface IApplicationUserService
    {
        public Task<ApplicationUser> GetUserByEmail(string email);
        public Task<bool> CheckPassword(ApplicationUser user, string password);
    }
}
