using Repositories.Abstraction;
using Services.Features.ProductCategory.GetById.Contracts;

namespace Services.Features.ProductCategory.GetById.Implementation;

public class GetProductCategoryByIdFeature : IGetProductCategoryByIdFeature
{
    private readonly IProductCategoryRepository _productCategoryRepository;

    public GetProductCategoryByIdFeature(IProductCategoryRepository productCategoryRepository)
    {
        _productCategoryRepository = productCategoryRepository; 
    }
    
    public async Task<BusinessObjects.Entities.ProductCategory?> GetByIdAsync(Guid id)
    {
        var result = await _productCategoryRepository.GetProductCategoryByIdAsync(id);
        return result;
    }
}