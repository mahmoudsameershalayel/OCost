using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OCost.API.Infrastructure.ApiResponse;

namespace OCost.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected async Task<IActionResult> GetResponse(Func<Task<APIResponseViewModel>> func) {
            return Ok(await func());
        }
    }
}
