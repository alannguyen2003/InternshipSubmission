using BusinessObjects.Exceptions;
using Repositories.Abstraction;
using Services.Features.UnitPrice.Create.Contracts;
using Services.Features.UnitPrice.Create.Contracts.DTOs;
using Services.Features.UnitPrice.Create.Rules;

namespace Services.Features.UnitPrice.Create.Implementation;

public class CreateUnitPriceFeature : ICreateUnitPriceFeature
{
    private readonly IUnitPriceRepository _unitPriceRepository;
    private readonly UnitPriceRules _rules;

    public CreateUnitPriceFeature(IUnitPriceRepository unitPriceRepository, UnitPriceRules rules)
    {
        _unitPriceRepository = unitPriceRepository;
        _rules = rules;
    }
    
    public async Task CreateAsync(CreateUnitPriceDTO createUnitPrice)
    {
        try
        {
            await _rules.EnsureUnitPriceIsNotNullOrEmpty(createUnitPrice.UnitPriceName);
            await _rules.EnsureUnitPriceIsNotDuplicate(createUnitPrice.UnitPriceName);

            BusinessObjects.Entities.UnitPrice unitPrice = new BusinessObjects.Entities.UnitPrice()
            {
                Id = new Guid(),
                UnitPriceName = createUnitPrice.UnitPriceName,
                Notes = createUnitPrice.Notes
            };

            await _unitPriceRepository.AddUnitPriceAsync(unitPrice);
        }
        catch (Exception ex)
        {
            throw new BusinessException("400", ex.Message);
        }
    }
}