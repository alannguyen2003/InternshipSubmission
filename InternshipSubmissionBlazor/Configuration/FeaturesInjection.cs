using Services.Features.ProductCategory.Create.Contracts;
using Services.Features.ProductCategory.Create.Implementation;
using Services.Features.ProductCategory.Create.Rules;
using Services.Features.ProductCategory.Delete.Contracts;
using Services.Features.ProductCategory.Delete.Implementation;
using Services.Features.ProductCategory.Get.Contracts;
using Services.Features.ProductCategory.Get.Implementation;
using Services.Features.ProductCategory.GetById.Contracts;
using Services.Features.ProductCategory.GetById.Implementation;
using Services.Features.ProductCategory.Update.Contracts;
using Services.Features.ProductCategory.Update.Implementation;
using Services.Features.UnitPrice.Create.Contracts;
using Services.Features.UnitPrice.Create.Implementation;
using Services.Features.UnitPrice.Create.Rules;
using Services.Features.UnitPrice.Delete.Contracts;
using Services.Features.UnitPrice.Delete.Implementation;
using Services.Features.UnitPrice.Get.Contracts;
using Services.Features.UnitPrice.Get.Implementation;
using Services.Features.UnitPrice.GetById.Contracts;
using Services.Features.UnitPrice.GetById.Implementation;
using Services.Features.UnitPrice.Update.Contracts;
using Services.Features.UnitPrice.Update.Implementation;

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
        
        //Delete
        services.AddScoped<IDeleteUnitPriceFeature, DeleteUnitPriceFeature>();
        services.AddScoped<Services.Features.UnitPrice.Delete.Rules.UnitPriceRules>();
        
        //Get By Id
        services.AddScoped<IGetUnitPriceByIdFeature, GetUnitPriceByIdFeature>();
        
        //Update
        services.AddScoped<IUpdateUnitPriceFeature, UpdateUnitPriceFeature>();
        services.AddScoped<Services.Features.UnitPrice.Update.Rules.UnitPriceRules>();
        return services;
    }

    public static IServiceCollection AddProductCategoryFeaturesInjection(this IServiceCollection services)
    {
        //Get
        services.AddScoped<IGetProductCategoriesFeature, GetProductCategoriesFeature>();
        
        //Get by id
        services.AddScoped<IGetProductCategoryByIdFeature, GetProductCategoryByIdFeature>();
        
        //Create
        services.AddScoped<ICreateProductCategoryFeature, CreateProductCategoryFeature>();
        services.AddScoped<ProductCategoryRules>();
        
        //Delete
        services.AddScoped<IDeleteProductCategoryFeature, DeleteProductCategoryFeature>();
        services.AddScoped<Services.Features.ProductCategory.Delete.Rules.ProductCategoryRules>();
        
        //Update
        services.AddScoped<IUpdateProductCategoryFeature, UpdateProductCategoryFeature>();
        services.AddScoped<Services.Features.ProductCategory.Update.Rules.ProductCategoryRules>();
        return services;
    }
}