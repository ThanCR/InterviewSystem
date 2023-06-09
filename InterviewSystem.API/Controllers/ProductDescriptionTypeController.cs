using InterviewSystem.BL.ProductBL;
using InterviewSystem.ET.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewSystem.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductDescriptionTypeController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(200)]
        public IActionResult GetAllProductDescriptionTypes()
        {
            return Ok(new BLProducts().GetProductDescriptionTypes());
        }
        [HttpGet("/ProductDescriptionType/{idProductDescriptionType}")]
        [ProducesResponseType(200)]
        public IActionResult GetProductDescriptionType(int idProductDescriptionType)
        {
            return Ok(new BLProducts().GetProductDescriptionTypeById(idProductDescriptionType));
        }

        [HttpPost]
        public IActionResult RegisterProductDescriptionType([FromBody] ProductDescriptionType productDescriptionType)
        {
            return Ok(new BLProducts().RegisterProductDescriptionType(productDescriptionType));
        }
        [HttpPut]
        [ProducesResponseType(201)]
        public IActionResult UpdateProductDescriptionType([FromBody] ProductDescriptionType productDescriptionType)
        {
            return Ok(new BLProducts().UpdateProductDescriptionType(productDescriptionType));
        }
        [HttpDelete("/ProductDescriptionType/{idProductDescriptionType}")]
        [ProducesResponseType(200)]
        public IActionResult DeleteProductDescriptionType(int idProductDescriptionType)
        {
            return Ok(new BLProducts().DeleteProductDescriptionType(idProductDescriptionType));
        }
    }
}
