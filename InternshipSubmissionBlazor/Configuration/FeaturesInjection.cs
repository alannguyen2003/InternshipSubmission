using Services.Features.Product.Create.Contracts;
using Services.Features.Product.Create.Implementation;
using Services.Features.Product.Create.Rules;
using Services.Features.Product.Delete.Contracts;
using Services.Features.Product.Delete.Implementation;
using Services.Features.Product.Get.Contracts;
using Services.Features.Product.Get.Implementation;
using Services.Features.Product.Update.Contracts;
using Services.Features.Product.Update.Implementation;
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
using Services.Features.Supplier.Get.Contracts;
using Services.Features.Supplier.Get.Implements;
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
        services.AddScoped<IGetRawUnitPriceFeature, GetRawUnitPriceFeature>();
        
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
        services.AddScoped<IGetRawProductCategoriesFeature, GetRawProductCategoryFeature>();
        
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

    public static IServiceCollection AddProductFeaturesInjection(this IServiceCollection services)
    {
        //Get
        services.AddScoped<IGetProductsFeature, GetProductsFeature>();
        
        //Get By Id
        services.AddScoped<IGetProductByIdFeature, GetProductByIdFeature>();
        //Create
        services.AddScoped<ICreateProductFeature, CreateProductFeature>();
        services.AddScoped<ProductRules>();
        //Update
        services.AddScoped<IUpdateProductFeature, UpdateProductFeature>();
        services.AddScoped<Services.Features.Product.Update.Rules.ProductRules>();
        //Delete
        services.AddScoped<IDeleteProductFeature, DeleteProductFeature>();
        return services;
    }

    public static IServiceCollection AddSupplierFeaturesInjection(this IServiceCollection services)
    {
        //Get
        services.AddScoped<IGetSuppliersFeature, GetSuppliersFeature>();
        services.AddScoped<IGetSupplierByIdFeature, GetSupplierByIdFeature>();
        //Create
        //Update
        //Delete
        return services;
    }
}