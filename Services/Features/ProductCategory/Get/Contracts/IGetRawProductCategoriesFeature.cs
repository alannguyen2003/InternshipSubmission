namespace Services.Features.ProductCategory.Get.Contracts;

public interface IGetRawProductCategoriesFeature
{
    public Task<List<BusinessObjects.Entities.ProductCategory>> GetAsync();
}