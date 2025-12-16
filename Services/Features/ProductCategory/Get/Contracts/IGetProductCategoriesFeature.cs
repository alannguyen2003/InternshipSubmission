using BusinessObjects.Entities;
using Services.Features.ProductCategory.Get.Contracts.DTOs;

namespace Services.Features.ProductCategory.Get.Contracts;

public interface IGetProductCategoriesFeature
{
    public Task<List<ProductCategoryDTO>> GetProductCategoriesAsync();
}