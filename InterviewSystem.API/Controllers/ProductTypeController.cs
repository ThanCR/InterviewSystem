using InterviewSystem.BL.ProductBL;
using InterviewSystem.ET.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewSystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductTypeController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(200)]
        public IActionResult GetAllProductTypes()
        {
            return Ok(new BLProducts().GetProductTypes());
        }
        [HttpGet("/ProductType/{idProductType}")]
        [ProducesResponseType(200)]
        public IActionResult GetProductType(int idProductType)
        {
            return Ok(new BLProducts().GetProductTypeById(idProductType));
        }

        [HttpPost]
        public IActionResult RegisterProductType([FromBody] ProductType productType)
        {
            return Ok(new BLProducts().RegisterProductType(productType));
        }
        [HttpPut]
        [ProducesResponseType(201)]
        public IActionResult UpdateProductType([FromBody] ProductType productType)
        {
            return Ok(new BLProducts().UpdateProductType(productType));
        }
        [HttpDelete("/ProductType/{idProductType}")]
        [ProducesResponseType(200)]
        public IActionResult DeleteProductType(int idProductType)
        {
            return Ok(new BLProducts().DeleteProductType(idProductType));
        }
    }
}
