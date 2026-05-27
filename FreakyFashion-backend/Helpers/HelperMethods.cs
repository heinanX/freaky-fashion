namespace FreakyFashion_backend.Helpers
{
    static public class HelperMethods
    {
        static public string SlugifyName(string name)
        {
            string urlSlug = name.Replace(" ", "-");
            return urlSlug;
        }
    }
}
