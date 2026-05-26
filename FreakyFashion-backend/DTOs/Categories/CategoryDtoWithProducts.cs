using FreakyFashion_backend.DTOs.Products;

namespace FreakyFashion_backend.DTOs.Categories
{
    public class CategoryDtoWithProducts
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Image { get; set; } = null!;
        public string? UrlSlug { get; set; }
        public ProductDto[] Products { get; set; } = null!;
    }
}
