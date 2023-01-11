using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnlineMarket.Api.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllCategoriesAsync()
        {
            return Ok(new List<string>()
            {
                "oziq-ovqat", "kiyim-kechak", "buyumlar", "elektronika"
            });
        }
    }
}
