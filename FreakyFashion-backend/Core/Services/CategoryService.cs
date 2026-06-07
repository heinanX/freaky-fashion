using FreakyFashion_backend.Core.Interfaces;
using FreakyFashion_backend.Data.Models;
using FreakyFashion_backend.Data.Repos.Interfaces;
using FreakyFashion_backend.DTOs.Categories;
using FreakyFashion_backend.Helpers;

namespace FreakyFashion_backend.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepo _categoryRepo;

        public CategoryService (ICategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        public async Task<CategoryDto> CreateCategoryAsync(CreateCategoryDto dto)
        {
            string categoryName = dto.Name.ToLower().Trim();
            string urlSlug = HelperMethods.SlugifyName(categoryName);
            Category newCategory = new()
            {
                CategoryName = categoryName,
                Image = dto.Image.Trim(),
                UrlSlug = urlSlug
            };

            Category response = await _categoryRepo.CreateCategoryAsync(newCategory);
            return CategoryMapper.ToDto(response);
        }

        public async Task DeleteCategoryAsync(int id)
        {
            await _categoryRepo.DeleteCategoryAsync(id);
        }

        public async Task<List<CategoryDto>> GetAllCategoriesAsync()
        {
            return await _categoryRepo.GetAllCategoriesAsync();
        }

        public async Task<List<CategoryDto>> GetCategoriesBySlugAsync(string slug)
        {
            return await _categoryRepo.GetCategoriesBySlugAsync(slug.ToLower().Trim());
        }

        public async Task<CategoryDto> GetCategoryByIdAsync(int id)
        {
            return await _categoryRepo.GetCategoryByIdAsync(id);
        }
    }
}
