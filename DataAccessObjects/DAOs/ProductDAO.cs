using BusinessObjects.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessObjects.DAOs;

public class ProductDAO : DataAccessBase<Product>
{
    private static ProductDAO _instance;

    public ProductDAO()
    {
    }

    public static ProductDAO Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new ProductDAO();
            }

            return _instance;
        }
    }

    public async Task<List<Product>> GetAllAsync()
    {
        using var context = new AppDbContext();
        return await context.Products
            .AsNoTracking()
            .Include(p => p.ProductCategory)
            .Include(p => p.UnitPrice)
            .ToListAsync();
    }
}