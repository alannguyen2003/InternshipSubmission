using BusinessObjects.Entities;

namespace DataAccessObjects.DAOs;

public class UnitPriceDAO : DataAccessBase<UnitPrice>
{
    private static UnitPriceDAO _instance;

    public UnitPriceDAO()
    {
    }

    public static UnitPriceDAO Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new UnitPriceDAO();
            }

            return _instance;
        }
    }
}