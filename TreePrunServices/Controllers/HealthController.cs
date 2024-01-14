using Microsoft.AspNetCore.Mvc;

namespace TreePrunServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet("status")]
        public IActionResult GetStatus()
        {
            return Ok();
        }
    }
}
