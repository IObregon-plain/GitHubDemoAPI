using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GitHubDemoAPI.Controllers
{
    [ApiController]
    [Route("/")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello demo";
        }
    }
}
