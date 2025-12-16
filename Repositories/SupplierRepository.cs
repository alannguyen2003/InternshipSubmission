using BusinessObjects.Entities;
using DataAccessObjects.DAOs;
using Repositories.Abstraction;

namespace Repositories;

public class SupplierRepository : ISupplierRepository
{
    public async Task<List<Supplier>> GetAllSuppliers()
    {
        var result = await SupplierDAO.Instance.Get();
        return result.ToList();
    }

    public async Task<Supplier?> GetSupplierById(Guid id)
    {
        return await SupplierDAO.Instance.GetById(id);
    }

    public async Task<Supplier?> GetSupplierByName(string supplierName)
    {
        var result = await SupplierDAO.Instance.Get(filter:
            filter => filter.SupplierName.Equals(supplierName));
        return result.FirstOrDefault();
    }

    public async Task AddNewSupplier(Supplier supplier)
    {
        await SupplierDAO.Instance.Insert(supplier);
    }

    public async Task UpdateSupplier(Supplier supplier)
    {
        await SupplierDAO.Instance.Update(supplier);
    }

    public async Task DeleteSupplier(Supplier supplier)
    {
        await SupplierDAO.Instance.Delete(supplier);
    }
}