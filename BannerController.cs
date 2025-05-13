namespace GitSubtreeMain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannerController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { deneme = "abcdefghijklmnoprstuvyzwx" });
        }
    }
}
