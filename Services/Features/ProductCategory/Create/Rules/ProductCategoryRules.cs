using BusinessObjects.Constants.ProductCategory;
using BusinessObjects.Exceptions;
using Repositories.Abstraction;

namespace Services.Features.ProductCategory.Create.Rules;

public class ProductCategoryRules
{
    private readonly IProductCategoryRepository _productCategoryRepository;

    public ProductCategoryRules(IProductCategoryRepository productCategoryRepository)
    {
        _productCategoryRepository = productCategoryRepository;
    }

    public async Task EnsureProductCategoryNameIsNotDuplicate(string productCategoryName)
    {
        BusinessObjects.Entities.ProductCategory? found =
            await _productCategoryRepository.GetProductCategoryByNameAsync(productCategoryName);
        if (found != null)
            throw new BusinessException("400",
                ProductCategoryMessage.EN.BusinessRuleException.PRODUCT_CATEGORY_IS_DUPLICATE);
    }

    public async Task EnsureProductCategoryNameIsNotNullOrEmpty(string productCategoryName)
    {
        if (string.IsNullOrEmpty(productCategoryName))
            throw new BusinessException("400",
                ProductCategoryMessage.EN.BusinessRuleException.PRODUCT_CATEGORY_IS_NULL_OR_EMPTY);
    }
}