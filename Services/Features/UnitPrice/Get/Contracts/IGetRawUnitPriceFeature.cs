namespace Services.Features.UnitPrice.Get.Contracts;

public interface IGetRawUnitPriceFeature
{
    public Task<List<BusinessObjects.Entities.UnitPrice>> GetAsync();
}