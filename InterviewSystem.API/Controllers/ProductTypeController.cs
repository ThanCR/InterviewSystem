using InterviewSystem.BL.ProductBL;
using InterviewSystem.ET.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllProductTypes() => Ok( new BLProducts().GetProductTypes());
        [HttpGet]
        public IActionResult GetProductType(int idProductType) => Ok(new BLProducts().GetProductTypeById(idProductType));
        [HttpPost]
        public IActionResult RegisterProductType([FromBody] ProductType productType) => Ok( new BLProducts().RegisterProductType(productType));
        [HttpPut]
        public IActionResult UpdateProductType([FromBody]  ProductType productType) => Ok(new BLProducts().UpdateProductType(productType));
        [HttpDelete]
        public IActionResult DeleteProductType(int idProductType) => Ok( new BLProducts().DeleteProductType(idProductType));
    }
}
