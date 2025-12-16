using Repositories.Abstraction;
using Services.Features.UnitPrice.GetById.Contracts;

namespace Services.Features.UnitPrice.GetById.Implementation;

public class GetUnitPriceByIdFeature : IGetUnitPriceByIdFeature
{
    private readonly IUnitPriceRepository _unitPriceRepository;

    public GetUnitPriceByIdFeature(IUnitPriceRepository unitPriceRepository)
    {
        _unitPriceRepository = unitPriceRepository;    
    }
    
    public async Task<BusinessObjects.Entities.UnitPrice?> GetByIdAsync(Guid id)
    {
        BusinessObjects.Entities.UnitPrice? result = await _unitPriceRepository.GetUnitPriceByUnitIdAsync(id);
        return result;
    }
}