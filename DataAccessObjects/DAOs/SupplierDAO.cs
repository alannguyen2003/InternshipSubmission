using BusinessObjects.Entities;

namespace DataAccessObjects.DAOs;

public class SupplierDAO : DataAccessBase<Supplier>
{
    private static SupplierDAO _instance;

    public SupplierDAO()
    {
    }

    public static SupplierDAO Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SupplierDAO();
            }

            return _instance;
        }
    }
}