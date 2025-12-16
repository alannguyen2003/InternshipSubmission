namespace Services.Features.Supplier.Get.Contracts;

public interface IGetSuppliersFeature
{
    public Task<List<BusinessObjects.Entities.Supplier>> GetAsync();
}