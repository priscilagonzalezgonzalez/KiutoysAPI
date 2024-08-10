using Application.Interfaces.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace KiutoysApp.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var products = _productService.ListAllProducts();

            return Ok(products);
        }

        [HttpGet("available")]
        public IActionResult GetAllAvailable()
        {
            var products = _productService.ListAllAvailableProducts();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null){
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Product product)
        {            
            if (product == null)
            {
                return BadRequest("Product is null.");
            }

            _productService.AddProduct(product);

            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _productService.DeleteProduct(id);
            return NoContent();
        }
    }
}