using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NicController : ControllerBase
    {
        private readonly IConfiguration config;
        public NicController(IConfiguration config)
        {
            this.config = config;
        }

        [HttpGet("createUser")]
        public IActionResult Create()
        {
            return Ok("success from Create Method");
        }
    }
}
