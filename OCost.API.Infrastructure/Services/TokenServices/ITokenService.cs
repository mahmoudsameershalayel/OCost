using OCoast.Data.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCoast.API.Infrastructure.Services.TokenServices
{
    public interface ITokenService
    {
        Task<string> CreateToken(ApplicationUser user);
    }
}
