using Repositories.Abstraction;
using Services.Features.Product.Get.Contracts;
using Services.Features.Product.Get.Contracts.DTOs;

namespace Services.Features.Product.Get.Implementation;

public class GetProductsFeature : IGetProductsFeature
{
    private readonly IProductRepository _productRepository;

    public GetProductsFeature(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    public async Task<List<ProductDTO>> GetProductsAsync()
    {
        List<BusinessObjects.Entities.Product> result = await _productRepository.GetProductsAsync();
        List<ProductDTO> products = new List<ProductDTO>();
        foreach (var item in result)
        {
            products.Add(new ProductDTO()
            {
                Id = item.Id,
                ProductName = item.ProductName,
                ProductCode = item.ProductCode,
                OrderNo = item.OrderNo,
                CategoryName = item.ProductCategory.CategoryName,
                UnitPrice = item.UnitPrice.UnitPriceName,
                Notes = item.Notes
            });
        }
        return products;
    }
}