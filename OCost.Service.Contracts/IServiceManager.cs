using OCoast.API.Infrastructure.Services.ApplicationUserServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Service.Contracts
{
    public interface IServiceManager
    {
        IApplicationUserService ApplicationUserService { get; }
        IAccountService AccountService { get; }
        IProductService ProductService { get; }
    }
}
