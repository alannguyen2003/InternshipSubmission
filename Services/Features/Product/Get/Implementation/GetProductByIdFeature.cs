using Repositories.Abstraction;
using Services.Features.Product.Get.Contracts;

namespace Services.Features.Product.Get.Implementation;

public class GetProductByIdFeature : IGetProductByIdFeature
{
    private readonly IProductRepository _productRepository;

    public GetProductByIdFeature(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    public async Task<BusinessObjects.Entities.Product?> GetByIdAsync(Guid id)
    {
        return await _productRepository.GetProductByIdAsync(id);
    }
}