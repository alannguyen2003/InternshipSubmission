using Repositories.Abstraction;
using Services.Features.ProductCategory.Update.Contracts;
using Services.Features.ProductCategory.Update.Contracts.DTOs;
using Services.Features.ProductCategory.Update.Rules;

namespace Services.Features.ProductCategory.Update.Implementation;

public class UpdateProductCategoryFeature : IUpdateProductCategoryFeature
{
    private readonly IProductCategoryRepository _productCategoryRepository;
    private readonly ProductCategoryRules _productCategoryRules;

    public UpdateProductCategoryFeature(IProductCategoryRepository productCategoryRepository, ProductCategoryRules productCategoryRules)
    {
        _productCategoryRepository = productCategoryRepository;
        _productCategoryRules = productCategoryRules;
    }
    
    public async Task UpdateAsync(BusinessObjects.Entities.ProductCategory productCategory)
    {
        await _productCategoryRules.EnsureProductCategoryIsExist(productCategory.Id);

        await _productCategoryRepository.UpdateProductCategoryAsync(productCategory);
    }
}