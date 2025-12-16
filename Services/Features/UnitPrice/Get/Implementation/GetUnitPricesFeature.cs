using Repositories.Abstraction;
using Services.Features.UnitPrice.Get.Contracts;
using Services.Features.UnitPrice.Get.Contracts.DTOs;

namespace Services.Features.UnitPrice.Get.Implementation;

public class GetUnitPricesFeature : IGetUnitPricesFeature
{
    private readonly IUnitPriceRepository _unitPriceRepository;

    public GetUnitPricesFeature(IUnitPriceRepository unitPriceRepository)
    
    {
        _unitPriceRepository = unitPriceRepository;
    }
    
    public async Task<List<UnitPriceDTO>> GetUnitPricesAsync()
    {
        List<BusinessObjects.Entities.UnitPrice> result = await _unitPriceRepository.GetAllUnitPricesAsync();
        List<UnitPriceDTO> unitPriceDTOs = new List<UnitPriceDTO>();

        foreach (var item in result)
        {
            UnitPriceDTO unitPriceDTO = new UnitPriceDTO()
            {
                Id = item.Id,
                UnitPriceName = item.UnitPriceName,
                Notes = item.Notes,
            };
            unitPriceDTOs.Add(unitPriceDTO);
        }
        return unitPriceDTOs;
    }
}