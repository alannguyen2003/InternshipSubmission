namespace Services.Features.ProductCategory.Get.Contracts.DTOs;

public class ProductCategoryDTO
{
    public Guid Id { get; set; }
    public string CategoryName { get; set; }
    public string CategoryCode { get; set; }
    public string Notes { get; set; }
    public int OrderNo { get; set; }
}