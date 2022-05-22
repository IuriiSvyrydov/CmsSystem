namespace SmsSystem.API;

public static class ApiRoutes
{
    public const string BaseRoute = "api/[controller]";
    public static class Products
    {
        public const string IdRoute = "{id}";
        public const string GetProductById = "product/{id}";
    }
}