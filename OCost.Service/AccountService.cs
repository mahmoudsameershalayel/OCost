using Microsoft.AspNetCore.Identity;
using OCoast.API.Infrastructure.Services.ApplicationUserServices;
using OCoast.API.Infrastructure.Services.TokenServices;
using OCoast.Data.DBEntities;
using OCost.API.Infrastructure.Services.LoggerService;
using OCost.Core.APIDtos.AccountDtos;
using OCost.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCost.Service
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ITokenService _tokenService;
        private readonly ILoggerManager _logger;

        public AccountService(UserManager<ApplicationUser> userManager, ITokenService tokenService, ILoggerManager logger)
        {
            _userManager = userManager;
            _tokenService = tokenService;
            _logger = logger;
        }

        public UserDto Login(LoginDto dto)
        {
            var item = _userManager.FindByEmailAsync(dto.Email).Result;
            var result = _userManager.CheckPasswordAsync(item, dto.Password);
            return new UserDto
            {
                UserName = item.UserName,
                Token = _tokenService.CreateToken(item).Result,
                Gender = item.Gender
            };

        }
    }
}
