namespace Services.Features.Supplier.Get.Contracts;

public interface IGetSupplierByIdFeature
{
    public Task<BusinessObjects.Entities.Supplier?> GetByIdAsync(Guid id);
} 