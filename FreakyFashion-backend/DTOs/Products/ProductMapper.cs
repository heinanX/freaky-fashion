using FreakyFashion_backend.Data.Models;

namespace FreakyFashion_backend.DTOs.Products
{
    public class ProductMapper
    {
        public static ProductDto ToDto(Product p) => new ProductDto
        {
            Id = p.Id,
            Name = p.Name,
            Description = p.Description,
            Price = p.Price,
            Image = p.Image,
            UrlSlug = p.UrlSlug
        };
    }
}
