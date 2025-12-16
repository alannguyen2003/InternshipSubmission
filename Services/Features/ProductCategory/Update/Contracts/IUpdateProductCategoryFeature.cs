using Services.Features.ProductCategory.Update.Contracts.DTOs;

namespace Services.Features.ProductCategory.Update.Contracts;

public interface IUpdateProductCategoryFeature
{
    public Task UpdateAsync(BusinessObjects.Entities.ProductCategory productCategory);
}