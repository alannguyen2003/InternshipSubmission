using Repositories.Abstraction;
using Services.Features.ProductCategory.Get.Contracts;
using Services.Features.ProductCategory.Get.Contracts.DTOs;

namespace Services.Features.ProductCategory.Get.Implementation;

public class GetProductCategoriesFeature : IGetProductCategoriesFeature
{
    private readonly IProductCategoryRepository _productCategoryRepository;

    public GetProductCategoriesFeature(IProductCategoryRepository productCategoryRepository)
    {
        _productCategoryRepository = productCategoryRepository;
    }

    public async Task<List<ProductCategoryDTO>> GetProductCategoriesAsync()
    {
        var result = await _productCategoryRepository.GetProductCategoriesAsync();
        List<ProductCategoryDTO> productCategories = new List<ProductCategoryDTO>();
        foreach (var item in result)
        {
            productCategories.Add(new ProductCategoryDTO()
            {
                Id = item.Id,
                CategoryName = item.CategoryName,
                OrderNo = item.OrderNo,
                CategoryCode = item.CategoryCode,
                Notes = item.Notes
            });
        }

        return productCategories;
    }
}