using InterviewSystem.BL.ProductBL;
using InterviewSystem.ET.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewSystem.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(200)]
        public IActionResult GetAllProducts()
        {
            return Ok(new BLProducts().GetProducts());
        }
        [HttpGet("/Product/{idProduct}")]
        [ProducesResponseType(200)]
        public IActionResult GetProduct(int idProduct)
        {
            return Ok(new BLProducts().GetProductById(idProduct));
        }

        [HttpPost]
        public IActionResult RegisterProduct([FromBody] Product product)
        {
            return Ok(new BLProducts().RegisterProduct(product));
        }
        [HttpPut]
        [ProducesResponseType(201)]
        public IActionResult UpdateProduct([FromBody] Product product)
        {
            return Ok(new BLProducts().UpdateProduct(product));
        }
        [HttpDelete("/Product/{idProduct}")]
        [ProducesResponseType(200)]
        public IActionResult DeleteProduct(int idProduct)
        {
            return Ok(new BLProducts().DeleteProduct(idProduct));
        }
    }
}
