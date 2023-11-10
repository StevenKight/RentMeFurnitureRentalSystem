using Dapper;
using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.model;

namespace RentMeFurnitureRentalSystem.DAL;

public class FurnitureDAL
{
    #region Methods

    public static IList<Furniture> GetFurniture()
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var result = connection.Query<Furniture>(QueryStrings.GetFurniture);
        return result.ToList();
    }

    public static IList<Furniture> GetRentableFurniture()
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var result = connection.Query<Furniture>(QueryStrings.GetRentableFurniture);
        return result.ToList();
    }

    public static IList<Furniture> GetFurnitureById(int id)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var result = connection.Query<Furniture>(QueryStrings.GetFurnitureById, new { id });
        return result.ToList();
    }

    public static IList<Furniture> GetFurnitureByCategory(string category)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var result = connection.Query<Furniture>(QueryStrings.GetFurnitureByCategory, new { category });
        return result.ToList();
    }

    public static IList<Furniture> GetFurnitureByStyle(string style)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var result = connection.Query<Furniture>(QueryStrings.GetFurnitureByStyle, new { style });
        return result.ToList();
    }

    public static IList<Furniture> GetRentableFurnitureById(int id)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var result = connection.Query<Furniture>(QueryStrings.GetRentableFurnitureById, new { id });
        return result.ToList();
    }

    public static IList<Furniture> GetRentableFurnitureByCategory(string category)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var result = connection.Query<Furniture>(QueryStrings.GetRentableFurnitureByCategory, new { category });
        return result.ToList();
    }

    public static IList<Furniture> GetRentableFurnitureByStyle(string style)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var result = connection.Query<Furniture>(QueryStrings.GetRentableFurnitureByStyle, new { style });
        return result.ToList();
    }

    public static bool CreateFurniture(Furniture furniture)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        try
        {
            var result = connection.Execute(QueryStrings.CreateFurniture, furniture);
            return result > 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return false;
        }
    }

    #endregion
}