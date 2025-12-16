using BusinessObjects.Entities;

namespace Repositories.Abstraction;

public interface IProductCategoryRepository
{
    public Task<List<ProductCategory>> GetProductCategoriesAsync();
    public Task<ProductCategory?> GetProductCategoryByIdAsync(Guid categoryId);
    public Task<ProductCategory?> GetProductCategoryByNameAsync(string productCategoryName);
    public Task AddNewProductCategoryAsync(ProductCategory productCategory);
    public Task UpdateProductCategoryAsync(ProductCategory productCategory);
    public Task DeleteProductCategoryAsync(ProductCategory productCategory);
}