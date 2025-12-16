using Repositories;
using Repositories.Abstraction;

namespace InternshipSubmissionBlazor.Configuration;

public static class ServiceInjection
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IUnitPriceRepository, UnitPriceRepository>();
        services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<ISupplierRepository, SupplierRepository>();
        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddUnitPriceFeaturesInjection();
        services.AddProductCategoryFeaturesInjection();
        services.AddProductFeaturesInjection();
        services.AddSupplierFeaturesInjection();
        return services;
    }
}