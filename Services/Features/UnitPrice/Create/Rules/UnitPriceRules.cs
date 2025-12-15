using BusinessObjects.Constants.UnitPrice;
using BusinessObjects.Exceptions;
using Repositories.Abstraction;

namespace Services.Features.UnitPrice.Create.Rules;

public class UnitPriceRules
{
    private readonly IUnitPriceRepository _unitPriceRepository;

    public UnitPriceRules(IUnitPriceRepository unitPriceRepository)
    {
        _unitPriceRepository = unitPriceRepository;
    }

    public async Task EnsureUnitPriceIsNotNullOrEmpty(string unitPriceName)
    {
        if (string.IsNullOrEmpty(unitPriceName))
            throw new BusinessException("400", UnitPriceMessage.EN.BusinessRuleException.UNIT_PRICE_IS_NULL_OR_EMPTY);
    }

    public async Task EnsureUnitPriceIsNotDuplicate(string unitPriceName)
    {
        var conflict = await _unitPriceRepository.GetUnitPriceByUnitNameAsync(unitPriceName);
        if (conflict != null) 
            throw new BusinessException("400", UnitPriceMessage.EN.BusinessRuleException.UNIT_PRICE_IS_DUPLICATE);
    }
}