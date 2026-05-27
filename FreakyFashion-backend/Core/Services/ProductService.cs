using FreakyFashion_backend.Core.Interfaces;
using FreakyFashion_backend.Data.Models;
using FreakyFashion_backend.Data.Repos;
using FreakyFashion_backend.Data.Repos.Interfaces;
using FreakyFashion_backend.DTOs.Products;
using FreakyFashion_backend.Helpers;

namespace FreakyFashion_backend.Core.Services;

public class ProductService : IProductService
{
    private readonly IProductRepo _productRepo;
    private readonly ICategoryRepo _categoryRepo;

    public ProductService(IProductRepo productRepo, ICategoryRepo categoryRepo)
    {
        _productRepo = productRepo;
        _categoryRepo = categoryRepo;
    }

    public async Task CreateProductAsync(CreateProductDto dto)
    {
        List<Category> categoryIds = await _categoryRepo.GetCategoriesByIdsAsync(dto.Categories);
        if (categoryIds.Count != dto.Categories.Count)
            throw new KeyNotFoundException("One or more categories were not found.");

        string productName = dto.Name.ToLower().Trim();
        string urlSlug = HelperMethods.SlugifyName(productName);
        Product newProduct = new()
        {
            Name = productName,
            Description = dto.Description.Trim(),
            Price = dto.Price,
            Image = dto.Image.Trim(),
            UrlSlug = urlSlug,
            Categories = categoryIds
        };
        await _productRepo.CreateProductAsync(newProduct);
    }

    public async Task DeleteProductAsync(int id)
    {
        await _productRepo.DeleteProductAsync(id);
    }

    public async Task<List<ProductDto>> GetAllProductsAsync()
    {
        return await _productRepo.GetAllProductsAsync();
    }

    public async Task<ProductDto> GetProductByIdAsync(int id)
    {
        return await _productRepo.GetProductByIdAsync(id);
    }

    public async Task<List<ProductDto>> GetProductsBySlugAsync(string slug)
    {
        return await _productRepo.GetProductsBySlugAsync(slug);
    }
}