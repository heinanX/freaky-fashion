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
            if (slug != null)
            {
                // handle slug search
                Console.WriteLine(slug);
                return Ok();
            }

            List<ProductDto> products = await _productService.GetAllProductsAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                // return Product
                Console.WriteLine(id);
                return Ok();
            } catch (KeyNotFoundException ex)
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
                Console.WriteLine(dto);
                return Created();
                //return Created(productDto);
            }
            catch (Exception ex) { 
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
                Console.WriteLine(id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
