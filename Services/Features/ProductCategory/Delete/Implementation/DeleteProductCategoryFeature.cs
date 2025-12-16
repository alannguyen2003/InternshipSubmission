using Repositories.Abstraction;
using Services.Features.ProductCategory.Delete.Contracts;
using Services.Features.ProductCategory.Delete.Rules;

namespace Services.Features.ProductCategory.Delete.Implementation;

public class DeleteProductCategoryFeature : IDeleteProductCategoryFeature
{
    private readonly IProductCategoryRepository _productCategoryRepository;
    private readonly ProductCategoryRules _productCategoryRules;

    public DeleteProductCategoryFeature(IProductCategoryRepository productCategoryRepository, ProductCategoryRules productCategoryRules)
    {
        _productCategoryRepository = productCategoryRepository;
        _productCategoryRules = productCategoryRules;
    }
    
    public async Task DeleteAsync(Guid id)
    {
        await _productCategoryRules.EnsureProductCategoryIsExists(id);

        var productCategory = await _productCategoryRepository.GetProductCategoryByIdAsync(id);
        await _productCategoryRepository.DeleteProductCategoryAsync(productCategory);
    }
}