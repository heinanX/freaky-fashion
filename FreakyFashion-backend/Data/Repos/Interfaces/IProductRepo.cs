using FreakyFashion_backend.Data.Models;
using FreakyFashion_backend.DTOs.Products;

namespace FreakyFashion_backend.Data.Repos.Interfaces;

public interface IProductRepo
{
    Task<List<ProductDto>> GetAllProductsAsync();
    Task<ProductDto> GetProductByIdAsync(int id);
    Task<List<ProductDto>> GetProductsBySlugAsync(string slug);
    Task<Product> CreateProductAsync(Product newProduct);
    Task DeleteProductAsync(int id);
}
