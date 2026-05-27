using FreakyFashion_backend.Core.Interfaces;
using FreakyFashion_backend.DTOs.Products;
using Microsoft.AspNetCore.Mvc;

namespace FreakyFashion.Controllers
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

        // For a higher grade, make this paginated: GET /api/products[?page=1&pageSize=10]
        [HttpGet]
        public async Task<ActionResult> Get([FromQuery] string? slug)
        {
            List<ProductDto> products;
            if (slug != null)
            {
                products = await _productService.GetProductsBySlugAsync(slug);

            } else
            {
                products = await _productService.GetAllProductsAsync();
            }

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                ProductDto product = await _productService.GetProductByIdAsync(id);
                return Ok(product);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }


        [HttpPost]
        //[Authorize]
        public async Task<ActionResult> Post([FromBody] CreateProductDto dto)
        {
            try
            {
                await _productService.CreateProductAsync(dto);
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                // write why the bad request was made, i.e . missing fields, invalid data, etc.
            }
        }

        // For a higher grade, make this update the whole product: PATCH /api/products/{id}

        //[HttpPatch("{id}")]
        //[Authorize]
        //public async Task<ActionResult> Patch(int id, [FromBody] UpdateResourceDto dto)
        //{
        //}


        [HttpDelete("{id}")]
        //[Authorize]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _productService.DeleteProductAsync(id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
