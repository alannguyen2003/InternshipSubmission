using BusinessObjects.Constants.Product;
using BusinessObjects.Exceptions;
using Repositories.Abstraction;

namespace Services.Features.Product.Update.Rules;

public class ProductRules
{
    private readonly IProductRepository _productRepository;

    public ProductRules(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task EnsureProductNameIsNotNullOrEmpty(string productName)
    {
        if (string.IsNullOrEmpty(productName))
            throw new BusinessException("400",
                ProductMessage.EN.BusinessRuleException.PRODUCT_IS_NULL_OR_EMPTY);
    }
}