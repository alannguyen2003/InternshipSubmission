namespace Services.Features.Product.Get.Contracts;

public interface IGetProductByIdFeature
{
    public Task<BusinessObjects.Entities.Product?> GetByIdAsync(Guid id);
}