using FreakyFashion_backend.Data.Models;
using FreakyFashion_backend.Data.Repos.Interfaces;
using FreakyFashion_backend.DTOs.Products;
using Microsoft.EntityFrameworkCore;

namespace FreakyFashion_backend.Data.Repos
{
    public class ProductRepo : IProductRepo
    {

        private readonly FreakyFashionDbContext _db;

        public ProductRepo(FreakyFashionDbContext db)
        {
            _db = db;
        }
        public async Task CreateProductAsync(Product newProduct)
        {
            await _db.Products.AddAsync(newProduct);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            Product? product = await _db.Products.FindAsync(id);
            if (product == null) throw new KeyNotFoundException($"Product with ID {id} not found.");

            _db.Products.Remove(product);
            await _db.SaveChangesAsync();
        }

        public async Task<List<ProductDto>> GetAllProductsAsync()
        {
            List<Product> products = await _db.Products
                            .Include(c => c.Categories)
                            .ToListAsync();

            return products.Select(ProductMapper.ToDto).ToList();
        }

        public async Task<ProductDto> GetProductByIdAsync(int id)
        {
            Product? product = await _db.Products
                .Include(p => p.Categories)
                .FirstOrDefaultAsync(p => p.Id == id);

            return product != null ?
                ProductMapper.ToDto(product)
                :
                throw new KeyNotFoundException($"Product with ID {id} not found.");

        }

        public async Task<List<ProductDto>> GetProductsBySlugAsync(string slug)
        {
            List<Product> products = await _db.Products
                          .Include(p => p.Categories)
                          .Where(p => p.UrlSlug.Contains(slug))
                          .ToListAsync();

            return products.Select(ProductMapper.ToDto).ToList();
        }
    }
}
