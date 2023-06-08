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
        [HttpGet(Name = "GetAllProductTypes")]
        [ProducesResponseType(200)]
        public IActionResult GetAllProductTypes()
        {
            return Ok(new BLProducts().GetProductTypes());
        }
        //[HttpGet]
        //[ProducesResponseType(200)]
        //public IActionResult GetProductType(int idProductType) => Ok(new BLProducts().GetProductTypeById(idProductType));

        //[HttpPost]
        //public IActionResult RegisterProductType([FromBody] ProductType productType) => Ok( new BLProducts().RegisterProductType(productType));
        //[HttpPut]
        //[ProducesResponseType(200)]
        //public IActionResult UpdateProductType([FromBody]  ProductType productType) => Ok(new BLProducts().UpdateProductType(productType));
        //[HttpDelete]
        //[ProducesResponseType(200)]
        //public IActionResult DeleteProductType(int idProductType) => Ok( new BLProducts().DeleteProductType(idProductType));
    }
}
