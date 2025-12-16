using BusinessObjects.Constants.UnitPrice;
using BusinessObjects.Exceptions;
using Repositories.Abstraction;

namespace Services.Features.UnitPrice.Delete.Rules;

public class UnitPriceRules
{
    private readonly IUnitPriceRepository _unitPriceRepository;

    public UnitPriceRules(IUnitPriceRepository unitPriceRepository)
    {
        _unitPriceRepository = unitPriceRepository;
    }

    public async Task EnsureUnitPriceExist(Guid unitPriceId)
    {
        var exists = await _unitPriceRepository.GetUnitPriceByUnitIdAsync(unitPriceId);
        if (exists == null)
            throw new BusinessException("400", UnitPriceMessage.EN.BusinessRuleException.UNIT_PRICE_IS_NOT_EXIST);
    }
}