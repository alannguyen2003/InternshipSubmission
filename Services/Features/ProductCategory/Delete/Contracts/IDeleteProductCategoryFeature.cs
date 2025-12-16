namespace Services.Features.ProductCategory.Delete.Contracts;

public interface IDeleteProductCategoryFeature
{
    public Task DeleteAsync(Guid id);
}