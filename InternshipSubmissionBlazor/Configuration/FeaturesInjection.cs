using Services.Features.UnitPrice.Create.Contracts;
using Services.Features.UnitPrice.Create.Implementation;
using Services.Features.UnitPrice.Create.Rules;
using Services.Features.UnitPrice.Get.Contracts;
using Services.Features.UnitPrice.Get.Implementation;

namespace InternshipSubmissionBlazor.Configuration;

public static class FeaturesInjection
{
    public static IServiceCollection AddUnitPriceFeaturesInjection(this IServiceCollection services)
    {
        //Create
        services.AddScoped<ICreateUnitPriceFeature, CreateUnitPriceFeature>();
        services.AddScoped<UnitPriceRules>();
        
        //Get
        services.AddScoped<IGetUnitPricesFeature, GetUnitPricesFeature>();
        return services;
    }
}