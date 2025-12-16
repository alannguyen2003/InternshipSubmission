using Services.Features.Product.Get.Contracts.DTOs;

namespace Services.Features.Product.Get.Contracts;

public interface IGetProductsFeature
{
    public Task<List<ProductDTO>> GetProductsAsync();
}