using Repositories.Abstraction;
using Services.Features.ProductCategory.Get.Contracts;

namespace Services.Features.ProductCategory.Get.Implementation;

public class GetRawProductCategoryFeature : IGetRawProductCategoriesFeature
{
    private readonly IProductCategoryRepository _productCategoryRepository;

    public GetRawProductCategoryFeature(IProductCategoryRepository productCategoryRepository)
    {
        _productCategoryRepository = productCategoryRepository;
    }
    
    public async Task<List<BusinessObjects.Entities.ProductCategory>> GetAsync()
    {
        var result = await _productCategoryRepository.GetProductCategoriesAsync();
        return result.ToList();
    }
}