using Repositories.Abstraction;
using Services.Features.Product.Create.Contracts;
using Services.Features.Product.Create.Contracts.DTOs;
using Services.Features.Product.Create.Rules;

namespace Services.Features.Product.Create.Implementation;

public class CreateProductFeature : ICreateProductFeature
{
    private readonly IProductRepository _productRepository;
    private readonly ProductRules _productRules;

    public CreateProductFeature(IProductRepository productRepository, ProductRules productRules)
    {
        _productRepository = productRepository;
        _productRules = productRules;
    }
    
    public async Task CreateAsync(CreateProductDTO product)
    {
        await _productRules.EnsureProductNameIsNotNullOrEmpty(product.ProductName);
        
        await _productRepository.AddNewProductAsync(new BusinessObjects.Entities.Product()
        {
            ProductName = product.ProductName,
            Notes = product.Notes,
            ProductCategoryId = product.ProductCategoryId,
            UnitPriceId = product.UnitPriceId,
            Id = Guid.NewGuid()
        });
    }
}