using Dapper;
using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.model;
using RentMeFurnitureRentalSystem.Model;
using System.Data;

namespace RentMeFurnitureRentalSystem.DAL;
/// <summary>
/// Rental DAL class that handles all database interactions for rentals
/// </summary>
public class RentalDAL
{
    /// <summary>
    /// Get all rentals from the database by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public static RentalItem GetRentalById(int id)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var results = connection.Query<RentalItem>(QueryStrings.GetRentalById, new { Id = id });

        return results.ElementAt(0);
    }
    /// <summary>
    /// get return by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public static RentalItem GetReturnById(int id)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var results = connection.Query<RentalItem>(QueryStrings.GetReturnById, new { Id = id });

        return results.ElementAt(0);
    }
    /// <summary>
    /// get all rentals
    /// </summary>
    /// <param name="rentalId"></param>
    /// <returns></returns>
    public static List<RentalItem> GetRentalItems(int rentalId)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var results = connection.Query<RentalItem>(QueryStrings.GetRentalItems, new { Id = rentalId });

        return results.ToList();
    }
    /// <summary>
    /// get rental total
    /// </summary>
    /// <param name="rentalId"></param>
    /// <returns></returns>
    public static decimal GetRentalTotal(int rentalId) 
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var results = connection.QuerySingle<decimal>(QueryStrings.GetRentalTotal, new { Id = rentalId });

        return results;
    }
    /// <summary>
    /// get rental by customer
    /// </summary>
    /// <param name="customer"></param>
    /// <returns></returns>
    public static List<RentalItem> GetRentalsByCustomer(Customer customer)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var results = connection.Query<RentalItem>(QueryStrings.GetRentalByMember, customer);

        return results.ToList();
    }
    /// <summary>
    /// create rental in the database
    /// </summary>
    /// <param name="rental"></param>
    /// <returns></returns>
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
    /// <summary>
    /// create rental item in the database
    /// </summary>
    /// <param name="rentalItem"></param>
    /// <returns></returns>
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
    /// <summary>
    /// create return in the database
    /// </summary>
    /// <param name="rental"></param>
    /// <returns></returns>
    public static int CreateReturn(RentalItem rental)
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
    /// <summary>
    /// create return item in the database
    /// </summary>
    /// <param name="rentalItem"></param>
    /// <returns></returns>
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
    /// <summary>
    /// get return items
    /// </summary>
    /// <param name="returnId"></param>
    /// <returns></returns>
    public static List<Furniture> GetReturnItems(int returnId)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var results = connection.Query<Furniture>(QueryStrings.GetReturnItems, new { Id = returnId });

        return results.ToList();
    }
    /// <summary>
    /// get return total
    /// </summary>
    /// <param name="returnId"></param>
    /// <returns></returns>
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