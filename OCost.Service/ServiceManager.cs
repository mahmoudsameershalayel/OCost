using AutoMapper;
using Microsoft.AspNetCore.Identity;
using OCoast.API.Infrastructure.Services.ApplicationUserServices;
using OCoast.API.Infrastructure.Services.TokenServices;
using OCoast.Data.DBEntities;
using OCost.API.Infrastructure.Repositories;
using OCost.API.Infrastructure.Services.LoggerService;
using OCost.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Service
{
    public class ServiceManager : IServiceManager
    {

        private readonly Lazy<IProductService> _productService;
        private readonly Lazy<IApplicationUserService> _applicationUserService;
        private readonly Lazy<AccountService> _accountService;
        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager loggerManager, IMapper mapper, UserManager<ApplicationUser> userManager , ITokenService tokenService)
        {
            _productService = new Lazy<IProductService>(() => new ProductService(repositoryManager, loggerManager, mapper));
            _applicationUserService = new Lazy<IApplicationUserService>(() => new ApplicationUserService(userManager));
            _accountService = new Lazy<AccountService>(() => new AccountService(userManager, tokenService, loggerManager));                                                                                                        
        }
        public IProductService ProductService => _productService.Value;
        public IApplicationUserService ApplicationUserService => _applicationUserService.Value;
        public IAccountService AccountService => _accountService.Value;
    }
}
