namespace FreakyFashion_backend.DTOs.Products
{
    public class CreateProductDto
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Price { get; set; }
        public string Image { get; set; } = null!;
        public List<int> Categories { get; set; } = null!;
    }
}