using BusinessObjects.Entities;

namespace Repositories.Abstraction;

public interface IUnitPriceRepository
{
    public Task<List<UnitPrice>> GetAllUnitPricesAsync();
    public Task<UnitPrice?> GetUnitPriceByUnitNameAsync(string unitName);
    public Task AddUnitPriceAsync(UnitPrice unitPrice);
    public Task UpdateUnitPriceAsync(UnitPrice unitPrice);
    public Task DeleteUnitPriceAsync(UnitPrice unitPrice);
}