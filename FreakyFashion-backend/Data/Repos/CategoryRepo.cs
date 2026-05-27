using FreakyFashion_backend.Data.Models;
using FreakyFashion_backend.Data.Repos.Interfaces;
using FreakyFashion_backend.DTOs.Categories;
using Microsoft.EntityFrameworkCore;

namespace FreakyFashion_backend.Data.Repos
{
    public class CategoryRepo : ICategoryRepo
    {

        private readonly FreakyFashionDbContext _db;

        public CategoryRepo(FreakyFashionDbContext db)
        {
            _db = db;
        }

        public async Task CreateCategoryAsync(Category category)
        {
            await _db.Categories.AddAsync(category);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteCategoryAsync(int id)
        {
            Category? category = await _db.Categories.FindAsync(id);
            if (category == null) throw new KeyNotFoundException($"Category with ID {id} not found.");

            _db.Categories.Remove(category);
            await _db.SaveChangesAsync();
        }

        public async Task<List<CategoryDto>> GetAllCategoriesAsync()
        {
            List<Category> categories = await _db.Categories
                .Include(c => c.Products)
                .ToListAsync();

            return categories.Select(CategoryMapper.ToDto).ToList();
        }

        public async Task<List<CategoryDto>> GetCategoriesBySlugAsync(string slug)
        {
            List<Category> categories = await _db.Categories
               .Include(c => c.Products)
               .Where(c => c.UrlSlug.Contains(slug))
               .ToListAsync();

            return categories.Select(CategoryMapper.ToDto).ToList();
        }

        public async Task<CategoryDto> GetCategoryByIdAsync(int id)
        {
            Category? category = await _db.Categories
                .Include(c => c.Products)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (category == null) throw new KeyNotFoundException($"Category with ID {id} not found.");

            return CategoryMapper.ToDto(category);
        }

        public async Task<List<Category>> GetCategoriesByIdsAsync(List<int> ids)
        {
            return await _db.Categories.Where(c => ids.Contains(c.Id)).ToListAsync();
        }
    }
}
