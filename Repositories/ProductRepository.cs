using BusinessObjects.Entities;
using DataAccessObjects.DAOs;
using Repositories.Abstraction;

namespace Repositories;

public class ProductRepository : IProductRepository
{
    private const string PRODUCT_CATEGORY_PREFIX = "SP";

    public async Task<List<Product>> GetProductsAsync()
    {
        return await ProductDAO.Instance.GetAllAsync();
    }

    public async Task<Product?> GetProductByIdAsync(Guid id)
    {
        return await ProductDAO.Instance.GetById(id);
    }

    public async Task<Product?> GetProductByNameAsync(string productName)
    {
        var result = await ProductDAO.Instance.Get(filter:
            filter => filter.ProductName.Equals(productName));
        return result.FirstOrDefault();
    }

    public async Task AddNewProductAsync(Product product)
    {
        var products = await ProductDAO.Instance.Get();
        var lastProduct = products?.Any() == true ? products.Max(item => item.OrderNo) : 0;
        product.OrderNo = lastProduct + 1;
        product.ProductCode = PRODUCT_CATEGORY_PREFIX + CreateCodePostFix(product.OrderNo);
        await ProductDAO.Instance.Insert(product);
    }
    
    private string CreateCodePostFix(int code)
    {
        return code.ToString("D6");
    }

    public async Task UpdateProductAsync(Product product)
    {
        await ProductDAO.Instance.Update(product);
    }

    public async Task DeleteProductAsync(Product product)
    {
        await ProductDAO.Instance.Delete(product);
    }
}