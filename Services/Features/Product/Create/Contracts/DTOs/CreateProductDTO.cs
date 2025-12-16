namespace Services.Features.Product.Create.Contracts.DTOs;

public class CreateProductDTO
{
    public string ProductName { get; set; }
    public Guid ProductCategoryId { get; set; }
    public string ProductCategoryName { get; set; }
    public Guid UnitPriceId { get; set; }
    public string UnitPriceName { get; set; }
    public string Notes { get; set; }
}