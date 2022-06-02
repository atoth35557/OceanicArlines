using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class RoutesController : ControllerBase
    {
        [HttpGet]
        [Route("test")]
        public async Task<IActionResult> Index()
        {
            return Ok("Placeholder");
        }
    }
}
