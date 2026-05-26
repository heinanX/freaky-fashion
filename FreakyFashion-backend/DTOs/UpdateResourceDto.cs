namespace FreakyFashion_backend.DTOs
{
    public class UpdateResourceDto
    {
        public string Op { get; set; } = null!;
        public string Path { get; set; } = null!;
        public string Value { get; set; } = null!;
    }
}

// Disable update of Id and UrlSlug properties (confirm slug with teacher)