using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OCoast.API.Infrastructure.Services.ApplicationUserServices;
using OCoast.API.Infrastructure.Services.TokenServices;
using OCost.API.Infrastructure.Services.LoggerService;
using OCost.Core.APIDtos.AccountDtos;
using OCost.Service.Contracts;

namespace OCoast.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly IServiceManager _service;
        public AccountController(IServiceManager service)
        {
            _service = service;
        }
        [HttpPost]
        public IActionResult Login(LoginDto dto)
        {
            var result = _service.AccountService.Login(dto);
            return Ok(result);
        }
    }
}
