using Microsoft.AspNetCore.Mvc;

namespace Banner.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { deneme = "asd" });
        }
    }
}
