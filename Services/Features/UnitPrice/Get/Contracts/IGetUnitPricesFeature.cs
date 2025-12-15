using Services.Features.UnitPrice.Get.Contracts.DTOs;

namespace Services.Features.UnitPrice.Get.Contracts;

public interface IGetUnitPricesFeature
{
    public Task<List<UnitPriceDTO>> GetUnitPricesAsync();
}