using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PhishSentinel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public IActionResult Home()
        {
            return Ok();
        }
    }
}
