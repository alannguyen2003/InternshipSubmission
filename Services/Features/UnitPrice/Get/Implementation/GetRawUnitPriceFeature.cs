using Repositories.Abstraction;
using Services.Features.UnitPrice.Get.Contracts;

namespace Services.Features.UnitPrice.Get.Implementation;

public class GetRawUnitPriceFeature : IGetRawUnitPriceFeature
{
    private readonly IUnitPriceRepository _unitPriceRepository;

    public GetRawUnitPriceFeature(IUnitPriceRepository unitPriceRepository)
    {
        _unitPriceRepository = unitPriceRepository;
    }
    
    public async Task<List<BusinessObjects.Entities.UnitPrice>> GetAsync()
    {
        var result = await _unitPriceRepository.GetAllUnitPricesAsync();
        return result.ToList();
    }
}