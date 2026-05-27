using FreakyFashion_backend.Data.Models;
using FreakyFashion_backend.DTOs.Categories;

namespace FreakyFashion_backend.Data.Repos.Interfaces;

public interface ICategoryRepo
{
    Task<List<CategoryDto>> GetAllCategoriesAsync();
    Task<CategoryDto> GetCategoryByIdAsync(int id);
    Task<List<CategoryDto>> GetCategoriesBySlugAsync(string slug);
    Task CreateCategoryAsync(Category createCategoryDto);
    Task DeleteCategoryAsync(int id);
    Task<List<Category>> GetCategoriesByIdsAsync(List<int> ids);
}
