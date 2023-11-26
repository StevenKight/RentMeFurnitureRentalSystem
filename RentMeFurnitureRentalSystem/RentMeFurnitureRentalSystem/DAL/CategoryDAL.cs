using Dapper;
using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.model;

namespace RentMeFurnitureRentalSystem.DAL;
/// <summary>
/// The CategoryDAL class
/// </summary>
public class CategoryDAL
{
    /// <summary>
    /// Gets the categories from the database
    /// </summary>
    /// <returns>List of Categories</returns>
    public static IList<Category> GetCategories()
    {
        var list = new List<Category>();
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var results = connection.Query<Category>(QueryStrings.GetCategories);

        foreach (var item in results) list.Add(item);
        return list;
    }
}