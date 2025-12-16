using Repositories.Abstraction;
using Services.Features.Supplier.Get.Contracts;

namespace Services.Features.Supplier.Get.Implements;

public class GetSupplierByIdFeature : IGetSupplierByIdFeature
{
    private readonly ISupplierRepository _supplierRepository;

    public GetSupplierByIdFeature(ISupplierRepository supplierRepository)
    {
        _supplierRepository = supplierRepository;
    }
    
    public async Task<BusinessObjects.Entities.Supplier?> GetByIdAsync(Guid id)
    {
        return await _supplierRepository.GetSupplierById(id);
    }
}