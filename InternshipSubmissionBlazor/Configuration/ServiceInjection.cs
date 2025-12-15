using Repositories;
using Repositories.Abstraction;

namespace InternshipSubmissionBlazor.Configuration;

public static class ServiceInjection
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IUnitPriceRepository, UnitPriceRepository>();
        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddUnitPriceFeaturesInjection();
        return services;
    }
}