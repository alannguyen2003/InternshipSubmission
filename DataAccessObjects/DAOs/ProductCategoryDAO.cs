using BusinessObjects.Entities;

namespace DataAccessObjects.DAOs;

public class ProductCategoryDAO : DataAccessBase<ProductCategory>
{
    private static ProductCategoryDAO _instance;

    public ProductCategoryDAO()
    {
    }

    public static ProductCategoryDAO Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new ProductCategoryDAO();
            }

            return _instance;
        }
    }   
}