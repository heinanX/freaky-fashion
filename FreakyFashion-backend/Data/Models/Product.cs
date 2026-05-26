namespace FreakyFashion_backend.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Price { get; set; }
        public string Image { get; set; } = null!;
        public string UrlSlug { get; set; } = null!;
        public List<Category> Categories { get; set; } = new List<Category>();
    }
}
