using Repositories.Abstraction;
using Services.Features.Supplier.Get.Contracts;

namespace Services.Features.Supplier.Get.Implements;

public class GetSuppliersFeature : IGetSuppliersFeature
{
    private readonly ISupplierRepository _supplierRepository;

    public GetSuppliersFeature(ISupplierRepository supplierRepository)
    {
        _supplierRepository = supplierRepository;
    }
    
    public async Task<List<BusinessObjects.Entities.Supplier>> GetAsync()
    {
        return await _supplierRepository.GetAllSuppliers();
    }
}