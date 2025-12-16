using Repositories.Abstraction;
using Services.Features.UnitPrice.Update.Contracts;
using Services.Features.UnitPrice.Update.Rules;

namespace Services.Features.UnitPrice.Update.Implementation;

public class UpdateUnitPriceFeature : IUpdateUnitPriceFeature
{
    private readonly IUnitPriceRepository _unitPriceRepository;
    private readonly UnitPriceRules _unitPriceRules;

    public UpdateUnitPriceFeature(IUnitPriceRepository unitPriceRepository, UnitPriceRules unitPriceRules)
    {
        _unitPriceRepository = unitPriceRepository;
        _unitPriceRules = unitPriceRules;
    }
    
    public async Task UpdateAsync(BusinessObjects.Entities.UnitPrice unitPrice)
    {
        await _unitPriceRules.EnsureUnitPriceExists(unitPrice.Id);
        await _unitPriceRules.EnsureUnitPriceNameIsNotNullOrEmpty(unitPrice.UnitPriceName);
        await _unitPriceRules.EnsureUnitPriceNameIsNotDuplicate(unitPrice.UnitPriceName, unitPrice.Id.ToString());
        
        await _unitPriceRepository.UpdateUnitPriceAsync(unitPrice);
    }
}