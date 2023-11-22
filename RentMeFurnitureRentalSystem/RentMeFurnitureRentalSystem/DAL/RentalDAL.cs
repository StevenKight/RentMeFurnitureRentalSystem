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

    public static RentalItem GetReturnById(int id)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var results = connection.Query<RentalItem>(QueryStrings.GetReturnById, new { Id = id });

        return results.ElementAt(0);
    }

    public static List<Furniture> GetRentalItems(int rentalId)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var results = connection.Query<Furniture>(QueryStrings.GetRentalItems, new { Id = rentalId });

        return results.ToList();
    }

    public static decimal GetRentalTotal(int rentalId) 
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var results = connection.QuerySingle<decimal>(QueryStrings.GetRentalTotal, new { Id = rentalId });

        return results;
    }

    public static List<RentalItem> GetRentalsByCustomer(Customer customer)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var results = connection.Query<RentalItem>(QueryStrings.GetRentalByMember, customer);

        return results.ToList();
    }

    public static int CreateRental(RentalItem rental) // TODO: This and CreateRentalItem should be in a transaction
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

    public static bool CreateRentalItem(RentalItem rentalItem)
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

    public static int CreateReturn(RentalItem rental) // TODO: This and CreateReturnItem should be in a transaction
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var param = new DynamicParameters();
        param.Add("memberId", rental.Member_id);
        param.Add("employeeNum", rental.Employee_num);
        param.Add("returnDate", rental.Start_date);
        param.Add("returnId", dbType: DbType.Int32, direction: ParameterDirection.Output);

        connection.Query<int>("CreateReturn", param, commandType: CommandType.StoredProcedure);
        var newId = param.Get<int>("returnId");

        return newId;
    }

    public static bool CreateReturnItem(RentalItem rentalItem)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var param = new DynamicParameters();
        param.Add("rentalId", rentalItem.Rental_id);
        param.Add("returnId", rentalItem.Return_id);
        param.Add("furnitureId", rentalItem.Furniture_id);
        param.Add("returnedQuantity", rentalItem.Quantity);

        var outcome = connection.Query<int>("CreateReturnItem", param, commandType: CommandType.StoredProcedure);

        return outcome != null;
    }

    public static List<Furniture> GetReturnItems(int returnId)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var results = connection.Query<Furniture>(QueryStrings.GetReturnItems, new { Id = returnId });

        return results.ToList();
    }

    public static decimal GetReturnTotal(int returnId)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        try
        {
            var results = connection.QuerySingle<decimal>(QueryStrings.GetReturnFineTotal, new { Id = returnId });

            return results;
        }
        catch (InvalidOperationException ex)
        {
            return 0;
        }
    }
}