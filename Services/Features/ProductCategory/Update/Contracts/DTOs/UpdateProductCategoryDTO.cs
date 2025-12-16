namespace Services.Features.ProductCategory.Update.Contracts.DTOs;

public class UpdateProductCategoryDTO
{
    public Guid Id { get; set; }
    public string CategoryCode { get; set; }
    public string CategoryName { get; set; }
    public string Notes { get; set; }
}