using FreakyFashion_backend.DTOs.Products;

namespace FreakyFashion_backend.Core.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetAllProductsAsync();
        Task<ProductDto> GetProductByIdAsync(int id);
        Task<List<ProductDto>> GetProductsBySlugAsync(string slug);
        Task CreateProductAsync(CreateProductDto dto);
        Task DeleteProductAsync(int id);
    }
}