namespace FreakyFashion_backend.DTOs.Auth
{
    public class AuthDto
    {
        public string access_token { get; set; } = null!;
        public string token_type { get; set; } = null!;
        public string expires_in { get; set; } = null!;
    }
}
