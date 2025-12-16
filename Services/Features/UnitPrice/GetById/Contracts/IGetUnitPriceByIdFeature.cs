namespace Services.Features.UnitPrice.GetById.Contracts;

public interface IGetUnitPriceByIdFeature
{
    public Task<BusinessObjects.Entities.UnitPrice?> GetByIdAsync(Guid id);
}