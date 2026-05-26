using FreakyFashion_backend.DTOs.Categories;

namespace FreakyFashion_backend.Core.Interfaces;

public interface ICategoryService
{
    Task<List<CategoryDto>> GetAllCategoriesAsync();
    Task<CategoryDto> GetCategoryByIdAsync(int id);
    Task<List<CategoryDto>> GetCategoriesBySlugAsync(string slug);
    Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
    //public Task UpdateCategory(UpdateCategoryDto createProductDto);
    Task DeleteCategoryAsync(int id);
}
