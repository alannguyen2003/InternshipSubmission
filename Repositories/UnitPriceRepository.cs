using BusinessObjects.Entities;
using DataAccessObjects.DAOs;
using Repositories.Abstraction;

namespace Repositories;

public class UnitPriceRepository : IUnitPriceRepository
{
    public UnitPriceRepository()
    {
    }
    
    public async Task<List<UnitPrice>> GetAllUnitPricesAsync()
    {
        var result = await UnitPriceDAO.Instance.Get();
        return result?.ToList() ?? new  List<UnitPrice>();
    }

    public async Task<UnitPrice?> GetUnitPriceByUnitNameAsync(string unitName)
    {
        var result =
            await UnitPriceDAO.Instance.Get(filter: filter =>
                filter.UnitPriceName.ToLower().Equals(unitName.ToLower()));
        return result.FirstOrDefault();
    }

    public async Task<UnitPrice?> GetUnitPriceByUnitIdAsync(Guid unitId)
    {
        var result = await UnitPriceDAO.Instance.Get(filter: filter =>
            filter.Id.ToString().ToLower().Equals(unitId.ToString().ToLower()));
        return result.FirstOrDefault();
    }

    public async Task AddUnitPriceAsync(UnitPrice unitPrice)
    {
        await UnitPriceDAO.Instance.Insert(unitPrice);
    }

    public async Task UpdateUnitPriceAsync(UnitPrice unitPrice)
    {
        await UnitPriceDAO.Instance.Update(unitPrice);
    }

    public async Task DeleteUnitPriceAsync(UnitPrice? unitPrice)
    {
        await UnitPriceDAO.Instance.Delete(unitPrice);
    }
}