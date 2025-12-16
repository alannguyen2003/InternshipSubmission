namespace Services.Features.Product.Delete.Contracts;

public interface IDeleteProductFeature
{
    public Task DeleteAsync(Guid id);
}