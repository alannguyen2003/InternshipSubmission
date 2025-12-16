using BusinessObjects.Entities;

namespace Repositories.Abstraction;

public interface ISupplierRepository
{
    public Task<List<Supplier>> GetAllSuppliers();
    public Task<Supplier?> GetSupplierById(Guid id);
    public Task<Supplier?> GetSupplierByName(string supplierName);
    public Task AddNewSupplier(Supplier supplier);
    public Task UpdateSupplier(Supplier supplier);
    public Task DeleteSupplier(Supplier supplier);
}