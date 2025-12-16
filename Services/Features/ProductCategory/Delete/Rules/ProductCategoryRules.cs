using BusinessObjects.Constants.ProductCategory;
using BusinessObjects.Exceptions;
using Repositories.Abstraction;

namespace Services.Features.ProductCategory.Delete.Rules;

public class ProductCategoryRules
{
    private readonly IProductCategoryRepository _productCategoryRepository;

    public ProductCategoryRules(IProductCategoryRepository productCategoryRepository)
    {
        _productCategoryRepository = productCategoryRepository;
    }

    public async Task EnsureProductCategoryIsExists(Guid id)
    {
        var result = await _productCategoryRepository.GetProductCategoryByIdAsync(id);
        if (result == null)
            throw new BusinessException("400",
                ProductCategoryMessage.EN.BusinessRuleException.PRODUCT_CATEGORY_IS_NOT_EXIST);
    }
}