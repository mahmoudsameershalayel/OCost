using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OCoast.API.Infrastructure.Services.ApplicationUserServices;
using OCoast.API.Infrastructure.Services.TokenServices;
using OCoast.Core.APIDtos;

namespace OCoast.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly IApplicationUserService _applicationUserService;
        private readonly ITokenService _tokenService;
        public AccountController(IApplicationUserService applicationUserService, ITokenService tokenService)
        {
            _applicationUserService = applicationUserService;
            _tokenService = tokenService;
        }
        [HttpPost]
        public async Task<ActionResult<UserDto>> Login(LoginDto dto)
        {
            var item = _applicationUserService.GetUserByEmail(dto.Email).Result;
            if (item != null)
            {
                var result = await _applicationUserService.CheckPassword(item, dto.Password);
                if (!result) return Unauthorized("Invalid Username OR Password");
                return new UserDto
                {
                    UserName = item.UserName,
                    Token = await _tokenService.CreateToken(item),
                    Gender = item.Gender
                };
            }
            return Unauthorized("Invalid Username");
        }
    }
}
