using Dapper;
using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.model;
using RentMeFurnitureRentalSystem.Model;

namespace RentMeFurnitureRentalSystem.DAL;

public class RentalDAL
{

    public static RentalItem GetRentalById(int id)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var results = connection.Query<RentalItem>(QueryStrings.GetRentalById, new { Id = id });

        return results.ElementAt(0);
    }

    public static List<RentalItem> GetRentalItems(int rentalId)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var results = connection.Query<RentalItem>(QueryStrings.GetRentalItems, new { Id = rentalId });

        return results.ToList();
    }

    public static decimal GetRentalTotal(int rentalId) 
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var results = connection.QuerySingle<decimal>(QueryStrings.GetRentalTotal, new { Id = rentalId });

        return results;
    }

    public static int GetRentalId(RentalItem rental)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var result = connection.Query<int>(QueryStrings.GetRentalId, rental);

        try
        {
            return result.ElementAt(0);
        }
        catch
        {
            return -1;
        }
    }

    public static bool CreateRental(RentalItem rental)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var affected = connection.Execute(QueryStrings.CreateRental, rental);

        return affected > 0;
    }

    public static bool CreateRentalItem(RentalItem rentalItem)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var affected = connection.Execute(QueryStrings.CreateRentalItem, rentalItem);

        return affected > 0;
    }
}