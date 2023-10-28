using Dapper;
using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.model;

namespace RentMeFurnitureRentalSystem.DAL;

public class CategoryDAL
{
    public static IList<Category> GetCategories()
    {
        var list = new List<Category>();
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var results = connection.Query<Category>(QueryStrings.GetCategories);

        foreach (var item in results) list.Add(item);
        return list;
    }
}