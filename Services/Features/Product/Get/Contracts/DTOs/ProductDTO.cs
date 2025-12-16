namespace Services.Features.Product.Get.Contracts.DTOs;

public class ProductDTO
{
    public Guid Id { get; set; }
    public string ProductName { get; set; }
    public string ProductCode { get; set; }
    public int OrderNo { get; set; }
    public string CategoryName { get; set; }
    public string UnitPrice { get; set; }
    public string? Notes { get; set; }
}