using FreakyFashion_backend.Core.Interfaces;
using FreakyFashion_backend.Data.Repos.Interfaces;
using FreakyFashion_backend.DTOs.Products;

namespace FreakyFashion_backend.Core.Services;

public class ProductService : IProductService
{
    private readonly IProductRepo _productRepo;
    public ProductService(IProductRepo productRepo)
    {
        _productRepo = productRepo;
    }

    public async Task CreateProductAsync(CreateProductDto createProductDto)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteProductAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<ProductDto>> GetAllProductsAsync()
    {
        return await _productRepo.GetAllProductsAsync();
    }

    public async Task<ProductDto> GetProductByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<ProductDto>> GetProductsBySlugAsync(string slug)
    {
        throw new NotImplementedException();
    }
}
