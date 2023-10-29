using Dapper;
using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.model;
using RentMeFurnitureRentalSystem.Model;

namespace RentMeFurnitureRentalSystem.DAL;

public class FurnitureDAL
{
    public static List<Furniture> GetAllFurniture()
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var results = connection.Query<Furniture>(QueryStrings.GetFurniture);


        return results.ToList();
    }
}