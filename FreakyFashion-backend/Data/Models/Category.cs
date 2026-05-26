namespace FreakyFashion_backend.Data.Models;

public class Category
{
    public int Id { get; set; }
    public string CategoryName { get; set; } = null!;
    public string Image { get; set; } = null!;
    public string UrlSlug { get; set; } = null!;
    public List<Product> Products { get; set; } = new List<Product>();

}
