using Services.Features.ProductCategory.Create.Contracts.DTOs;

namespace Services.Features.ProductCategory.Create.Contracts;

public interface ICreateProductCategoryFeature
{
    public Task CreateAsync(ProductCategoryDTO productCategory);
}