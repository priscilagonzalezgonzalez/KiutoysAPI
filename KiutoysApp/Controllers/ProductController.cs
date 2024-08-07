using Application.Interfaces.Services;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        /* [HttpGet]
        public IActionResult GetAll()
        {
            var products = _context.Products
            .Include(p => p.productCategoryRelations).ToList();

            return Ok(products);
        } */

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null){
                return NotFound();
            }
            return Ok(product);
        }
    }
}