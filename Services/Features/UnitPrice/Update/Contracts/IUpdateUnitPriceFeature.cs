namespace Services.Features.UnitPrice.Update.Contracts;

public interface IUpdateUnitPriceFeature
{
    public Task UpdateAsync(BusinessObjects.Entities.UnitPrice unitPrice);
}