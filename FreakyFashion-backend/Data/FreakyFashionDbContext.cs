using FreakyFashion_backend.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FreakyFashion_backend.Data;

public class FreakyFashionDbContext : DbContext
{
    public FreakyFashionDbContext(DbContextOptions<FreakyFashionDbContext> options) : base(options)
    {
    }
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Product> Products { get; set; }
}
