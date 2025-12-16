using BusinessObjects.Exceptions;
using Repositories.Abstraction;
using Services.Features.UnitPrice.Delete.Contracts;
using Services.Features.UnitPrice.Delete.Rules;

namespace Services.Features.UnitPrice.Delete.Implementation;

public class DeleteUnitPriceFeature : IDeleteUnitPriceFeature
{
    private readonly IUnitPriceRepository _unitPriceRepository;
    private readonly UnitPriceRules _unitPriceRules;

    public DeleteUnitPriceFeature(IUnitPriceRepository unitPriceRepository, UnitPriceRules unitPriceRules)
    {
        _unitPriceRepository = unitPriceRepository;
        _unitPriceRules = unitPriceRules;
    }
    
    public async Task DeleteAsync(Guid id)
    {
        await _unitPriceRules.EnsureUnitPriceExist(id);

        BusinessObjects.Entities.UnitPrice? unitPrice = await _unitPriceRepository.GetUnitPriceByUnitIdAsync(id);
        Console.WriteLine(unitPrice.Id.ToString(), " ", id.ToString());
        await _unitPriceRepository.DeleteUnitPriceAsync(unitPrice);
    }
}