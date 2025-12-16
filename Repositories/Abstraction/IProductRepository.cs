using BusinessObjects.Entities;

namespace Repositories.Abstraction;

public interface IProductRepository
{
    public Task<List<Product>> GetProductsAsync();
    public Task<Product?> GetProductByIdAsync(Guid id);
    public Task<Product?> GetProductByNameAsync(string productName);
    public Task AddNewProductAsync(Product product);
    public Task UpdateProductAsync(Product product);
    public Task DeleteProductAsync(Product product);
}