using InterviewSystem.BL.ProductBL;
using Microsoft.AspNetCore.Mvc;

namespace InterviewSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductQueryController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(200)]

        public IActionResult GetProductsByTypeName(string productTypeName)
        {
            return Ok(new BLProductQuery().GetProductsByTypeName(productTypeName));
        }        
    }
}
