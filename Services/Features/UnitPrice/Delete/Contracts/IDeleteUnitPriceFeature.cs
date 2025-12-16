namespace Services.Features.UnitPrice.Delete.Contracts;

public interface IDeleteUnitPriceFeature
{
    public Task DeleteAsync(Guid id);
}