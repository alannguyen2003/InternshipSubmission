using Repositories.Abstraction;
using Services.Features.Product.Update.Contracts;
using Services.Features.Product.Update.Rules;

namespace Services.Features.Product.Update.Implementation;

public class UpdateProductFeature : IUpdateProductFeature
{
    private readonly IProductRepository _productRepository;
    private readonly ProductRules _productRules;

    public UpdateProductFeature(IProductRepository productRepository, ProductRules productRules)
    {
        _productRepository = productRepository;
        _productRules = productRules;
    }
    
    public async Task UpdateAsync(BusinessObjects.Entities.Product product)
    {
        await _productRules.EnsureProductNameIsNotNullOrEmpty(product.ProductName);

        await _productRepository.UpdateProductAsync(product);
    }
}