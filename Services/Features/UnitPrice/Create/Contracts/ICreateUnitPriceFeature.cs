using Services.Features.UnitPrice.Create.Contracts.DTOs;

namespace Services.Features.UnitPrice.Create.Contracts;

public interface ICreateUnitPriceFeature
{
    public Task CreateAsync(CreateUnitPriceDTO createUnitPrice);
}