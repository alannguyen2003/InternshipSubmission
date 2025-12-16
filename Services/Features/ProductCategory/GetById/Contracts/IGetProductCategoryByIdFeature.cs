namespace Services.Features.ProductCategory.GetById.Contracts;

public interface IGetProductCategoryByIdFeature
{
    public Task<BusinessObjects.Entities.ProductCategory?> GetByIdAsync(Guid id);
}