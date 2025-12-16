using BusinessObjects.Entities;
using DataAccessObjects.DAOs;
using Repositories.Abstraction;

namespace Repositories;

public class ProductCategoryRepository : IProductCategoryRepository
{
    private const string PRODUCT_CATEGORY_PREFIX = "PD";
    public async Task<List<ProductCategory>> GetProductCategoriesAsync()
    {
        var result = await ProductCategoryDAO.Instance.Get();
        return result?.ToList() ?? new List<ProductCategory>();
    }

    public async Task<ProductCategory?> GetProductCategoryByIdAsync(Guid categoryId)
    {
        return await ProductCategoryDAO.Instance.GetById(categoryId);
    }

    public async Task<ProductCategory?> GetProductCategoryByNameAsync(string productCategoryName)
    {
        var result = await ProductCategoryDAO.Instance.Get(filter:
            filter => filter.CategoryName.Equals(productCategoryName));
        return result.FirstOrDefault();
    }

    public async Task AddNewProductCategoryAsync(ProductCategory productCategory)
    {
        var categories = await ProductCategoryDAO.Instance.Get();
        var lastCategory = categories?.Any() == true ? categories.Max(item => item.OrderNo) : 0;
        productCategory.OrderNo = lastCategory + 1;
        productCategory.CategoryCode = PRODUCT_CATEGORY_PREFIX + CreateCodePostFix(productCategory.OrderNo);
        await ProductCategoryDAO.Instance.Insert(productCategory);
    }

    private string CreateCodePostFix(int code)
    {
        return code.ToString("D6");
    }

    public async Task UpdateProductCategoryAsync(ProductCategory productCategory)
    {
        await ProductCategoryDAO.Instance.Update(productCategory);
    }

    public async Task DeleteProductCategoryAsync(ProductCategory productCategory)
    {
        await ProductCategoryDAO.Instance.Delete(productCategory);
    }
}