using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnlineMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetValuesAsync()
        {
            return Ok(new int[]
            {
                1, 2, 3,4, 5, 6, 67, 8
            });
        }
    }
}
