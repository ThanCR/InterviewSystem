using InterviewSystem.BL.ProductBL;
using InterviewSystem.ET.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewSystem.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductDescriptionController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(200)]
        public IActionResult GetAllProductDescriptions()
        {
            return Ok(new BLProducts().GetProductDescriptions());
        }
        [HttpGet("/ProductDescription/{idProductDescription}")]
        [ProducesResponseType(200)]
        public IActionResult GetProductDescription(int idProductDescription)
        {
            return Ok(new BLProducts().GetProductDescriptionById(idProductDescription));
        }

        [HttpPost]
        public IActionResult RegisterProductDescription([FromBody] ProductDescription productDescription)
        {
            return Ok(new BLProducts().RegisterProductDescription(productDescription));
        }
        [HttpPut]
        [ProducesResponseType(201)]
        public IActionResult UpdateProductDescription([FromBody] ProductDescription productDescription)
        {
            return Ok(new BLProducts().UpdateProductDescription(productDescription));
        }
        [HttpDelete("/ProductDescription/{idProductDescription}")]
        [ProducesResponseType(200)]
        public IActionResult DeleteProductDescription(int idProductDescription)
        {
            return Ok(new BLProducts().DeleteProductDescription(idProductDescription));
        }
    }
}
