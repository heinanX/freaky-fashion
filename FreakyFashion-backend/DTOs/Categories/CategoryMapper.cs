using FreakyFashion_backend.Data.Models;
using FreakyFashion_backend.DTOs.Products;

namespace FreakyFashion_backend.DTOs.Categories
{
    public class CategoryMapper
    {
        public static CategoryDto ToDto(Category c) => new CategoryDto
        {
            Id = c.Id,
            Name = c.CategoryName,
            Image = c.Image,
            UrlSlug = c.UrlSlug,
            Products = c.Products.Select(ProductMapper.ToDto).ToList()
        };
    }
}
