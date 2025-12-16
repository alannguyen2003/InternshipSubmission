using Repositories.Abstraction;
using Services.Features.Product.Delete.Contracts;

namespace Services.Features.Product.Delete.Implementation;

public class DeleteProductFeature : IDeleteProductFeature
{
    private readonly IProductRepository _productRepository;

    public DeleteProductFeature(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    public async Task DeleteAsync(Guid id)
    {
        var product = await _productRepository.GetProductByIdAsync(id);
        await _productRepository.DeleteProductAsync(product);
    }
}