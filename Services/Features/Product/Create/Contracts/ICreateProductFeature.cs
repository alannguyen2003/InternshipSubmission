using Services.Features.Product.Create.Contracts.DTOs;

namespace Services.Features.Product.Create.Contracts;

public interface ICreateProductFeature
{
    public Task CreateAsync(CreateProductDTO product);
}