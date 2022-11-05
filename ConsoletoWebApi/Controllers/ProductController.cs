using ConsoletoWebApi.Models;
using ConsoletoWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoletoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productService;   

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("")]
        public IActionResult AddProduct([FromBody] ProductModel product)
        {
            _productService.AddProduct(product);
            var products = _productService.GetAllProducts();

            return Ok(products);
        }
    }
}
