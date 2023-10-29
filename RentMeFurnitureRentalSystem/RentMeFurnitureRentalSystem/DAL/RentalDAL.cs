using Dapper;
using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.model;

namespace RentMeFurnitureRentalSystem.DAL;

public class RentalDAL
{
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