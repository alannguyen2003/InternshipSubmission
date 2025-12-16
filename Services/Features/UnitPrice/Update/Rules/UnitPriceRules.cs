using BusinessObjects.Constants.UnitPrice;
using BusinessObjects.Exceptions;
using Repositories.Abstraction;

namespace Services.Features.UnitPrice.Update.Rules;

public class UnitPriceRules
{
    private readonly IUnitPriceRepository _unitPriceRepository;

    public UnitPriceRules(IUnitPriceRepository unitPriceRepository)
    {
        _unitPriceRepository = unitPriceRepository;
    }

    public async Task EnsureUnitPriceExists(Guid id)
    {
        BusinessObjects.Entities.UnitPrice? unitPrice = await _unitPriceRepository.GetUnitPriceByUnitIdAsync(id);
        if (unitPrice == null)
            throw new BusinessException("400", UnitPriceMessage.EN.BusinessRuleException.UNIT_PRICE_IS_NOT_EXIST);
    }

    public async Task EnsureUnitPriceNameIsNotNullOrEmpty(string unitPriceName)
    {
        if (string.IsNullOrEmpty(unitPriceName))
            throw new BusinessException("400", UnitPriceMessage.EN.BusinessRuleException.UNIT_PRICE_IS_NULL_OR_EMPTY);
    }

    public async Task EnsureUnitPriceNameIsNotDuplicate(string unitPriceName, string id)
    {
        BusinessObjects.Entities.UnitPrice? unitPrice = await _unitPriceRepository.GetUnitPriceByUnitNameAsync(unitPriceName);
        if (unitPrice != null && id.ToLower() != unitPrice.Id.ToString().ToLower()) 
            throw new BusinessException("400", UnitPriceMessage.EN.BusinessRuleException.UNIT_PRICE_IS_DUPLICATE);
    }
}