using FreakyFashion_backend.Core.Interfaces;
using FreakyFashion_backend.DTOs.Categories;
using Microsoft.AspNetCore.Mvc;

namespace FreakyFashion.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<ActionResult> Get([FromQuery] string? slug)
    {
        List<CategoryDto> categories = slug != null ?
            await _categoryService.GetCategoriesBySlugAsync(slug)
            :
            await _categoryService.GetAllCategoriesAsync();

        return Ok(categories);
    }


    [HttpGet("{id}")]
    public async Task<ActionResult> Get(int id)
    {
        try
        {
            CategoryDto category = await _categoryService.GetCategoryByIdAsync(id);
            return Ok(category);
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }


    [HttpPost]
    //[Authorize]
    public async Task<ActionResult> Post([FromBody] CreateCategoryDto dto)
    {
        try
        {
            await _categoryService.CreateCategoryAsync(dto);
            return Created();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }


    [HttpDelete("{id}")]
    //[Authorize]
    public async Task<ActionResult> Delete(int id)
    {
        try
        {
            await _categoryService.DeleteCategoryAsync(id);
            return NoContent();
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }

    // For a higher grade, make this update the whole product: PATCH /api/products/{id}

    //[HttpPatch("{id}")]
    //public async Task<ActionResult> Patch(int id, [FromBody] UpdateResourceDto dto)
    //{
    //}

    // For a higher grade, Delete Product from Category: DELETE /api/categories/{categoryID}/products/{productId}

    [HttpDelete("{categoryId}/products/{productId}")]
    public async Task<ActionResult> Delete(int categoryId, int productId)
    {
        try
        {
            Console.WriteLine(productId);
            return NoContent();
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }
}
