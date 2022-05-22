namespace SmsSystem.API.Registers
{
    public static class RegistarRepository
    {
        public static void RegisterRepository(this IServiceCollection services)
        { 
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
           services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
        }
    }
}
