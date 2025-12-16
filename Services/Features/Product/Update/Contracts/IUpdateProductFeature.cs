namespace Services.Features.Product.Update.Contracts;

public interface IUpdateProductFeature
{
    public Task UpdateAsync(BusinessObjects.Entities.Product product);
}