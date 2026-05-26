using FreakyFashion_backend.Data.Models;
using FreakyFashion_backend.Data.Repos.Interfaces;
using FreakyFashion_backend.DTOs.Products;
using static System.Net.Mime.MediaTypeNames;

namespace FreakyFashion_backend.Data.Repos
{
    public class ProductRepo : IProductRepo
    {
        public Task CreateProductAsync(CreateProductDto createProductDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductDto>> GetAllProductsAsync()
        {
            Console.WriteLine("I got in here");
            var products = new List<ProductDto>
    {
        new ProductDto { Id = 1, Name = "Black T-Shirt", Description = "A classic black t-shirt.", Price = 199, Image = "/images/black-t-shirt.png", UrlSlug = "black-t-shirt" },
        new ProductDto { Id = 2, Name = "White T-Shirt", Description = "A clean white t-shirt.", Price = 199, Image = "/images/white-t-shirt.png", UrlSlug = "white-t-shirt" },
        new ProductDto { Id = 3, Name = "Blue Jeans", Description = "Slim fit blue jeans.", Price = 499, Image = "/images/blue-jeans.png", UrlSlug = "blue-jeans" }
    };

            return products;
        }

        public Task<ProductDto> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductDto>> GetProductsBySlugAsync(string slug)
        {
            throw new NotImplementedException();
        }
    }
}
