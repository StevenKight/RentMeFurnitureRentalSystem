using Dapper;
using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.model;
using RentMeFurnitureRentalSystem.Model;
using System.Data;

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

    public static int CreateRental(RentalItem rental)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var param = new DynamicParameters();
        param.Add("memberId", rental.Member_id);
        param.Add("employeeNum", rental.Employee_num);
        param.Add("startDate", rental.Start_date);
        param.Add("dueDate", rental.Due_date);
        param.Add("rentalId", dbType: DbType.Int32, direction: ParameterDirection.Output);

        connection.Query<int>("CreateRental", param, commandType: CommandType.StoredProcedure);
        var newId = param.Get<int>("rentalId");

        return newId;
    }

    public static bool CreateRentalItem(RentalItem rentalItem) // TODO: Use transaction
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var param = new DynamicParameters();
        param.Add("rentalId", rentalItem.Rental_id);
        param.Add("furnitureId", rentalItem.Furniture_id);
        param.Add("rentedQuantity", rentalItem.Quantity);

        var outcome = connection.Query<int>("CreateRentalItem", param, commandType: CommandType.StoredProcedure);

        return outcome != null;
    }
}