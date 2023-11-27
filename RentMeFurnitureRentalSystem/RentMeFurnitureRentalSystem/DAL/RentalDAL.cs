using System.Data;
using Dapper;
using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.Model;

namespace RentMeFurnitureRentalSystem.DAL;

/// <summary>
///     Rental DAL class that handles all database interactions for rentals
/// </summary>
public class RentalDal
{
    #region Methods

    /// <summary>
    ///     Get all rentals from the database by id
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
    ///     get return by id
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
    ///     get all rentals
    /// </summary>
    /// <param name="rentalId"></param>
    /// <returns></returns>
    public static List<Furniture> GetRentalItems(int rentalId)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var results = connection.Query<Furniture>(QueryStrings.GetRentalItems, new { Id = rentalId });

        return results.ToList();
    }

    /// <summary>
    ///     get rental total
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
    ///     get rental by customer
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
    ///     Create a rental for a user and add given furniture to the rental.
    /// </summary>
    /// <param name="rental">The rental user, employee and other data.</param>
    /// <param name="furniture">The list of furniture to rent.</param>
    /// <returns>New rental id if rental is processed, -1 otherwise.</returns>
    public static int RentFurniture(RentalItem rental, List<Furniture> furniture)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        using var transaction = connection.BeginTransaction();

        try
        {
            var newRentalId = CreateRental(rental, connection);

            foreach (var furnitureItem in furniture)
            {
                var item = new RentalItem
                {
                    RentalId = newRentalId,
                    MemberId = rental.MemberId,
                    EmployeeNum = rental.EmployeeNum,
                    StartDate = rental.StartDate,
                    DueDate = rental.DueDate,
                    FurnitureId = furnitureItem.FurnitureId,
                    Quantity = furnitureItem.Quantity
                };

                CreateRentalItem(item, connection);
            }

            transaction.Commit();

            return newRentalId;
        }
        catch (Exception ex)
        {
            transaction.Rollback();

            return -1;
        }
    }

    /// <summary>
    ///     create rental in the database
    /// </summary>
    /// <param name="rental"></param>
    /// <returns></returns>
    public static int CreateRental(RentalItem rental, MySqlConnection transactionConnection)
    {
        var param = new DynamicParameters();
        param.Add("memberId", rental.MemberId);
        param.Add("employeeNum", rental.EmployeeNum);
        param.Add("startDate", rental.StartDate);
        param.Add("dueDate", rental.DueDate);
        param.Add("rentalId", dbType: DbType.Int32, direction: ParameterDirection.Output);

        transactionConnection.Query<int>("CreateRental", param, commandType: CommandType.StoredProcedure);
        var newId = param.Get<int>("rentalId");

        return newId;
    }

    /// <summary>
    ///     create rental item in the database
    /// </summary>
    /// <param name="rentalItem"></param>
    /// <returns></returns>
    public static bool CreateRentalItem(RentalItem rentalItem, MySqlConnection transactionConnection)
    {
        var param = new DynamicParameters();
        param.Add("rentalId", rentalItem.RentalId);
        param.Add("furnitureId", rentalItem.FurnitureId);
        param.Add("rentedQuantity", rentalItem.Quantity);

        var outcome =
            transactionConnection.Query<int>("CreateRentalItem", param, commandType: CommandType.StoredProcedure);

        return outcome != null;
    }

    /// <summary>
    ///     Create a return for a user and add given furniture to the return.
    /// </summary>
    /// <param name="returnData">The return user, employee and other data.</param>
    /// <param name="furniture">The list of furniture to return.</param>
    /// <returns>New return id if return is processed, -1 otherwise.</returns>
    public static int ReturnFurniture(RentalItem returnData, List<Furniture> furniture)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        using var transaction = connection.BeginTransaction();

        try
        {
            var newReturnId = CreateReturn(returnData, connection);

            foreach (var furnitureItem in furniture)
            {
                var item = new RentalItem
                {
                    ReturnId = newReturnId,
                    RentalId = furnitureItem.RentalId,
                    MemberId = returnData.MemberId,
                    EmployeeNum = returnData.EmployeeNum,
                    StartDate = returnData.StartDate,
                    FurnitureId = furnitureItem.FurnitureId,
                    Quantity = furnitureItem.Quantity
                };

                CreateReturnItem(item, connection);
            }

            transaction.Commit();

            return newReturnId;
        }
        catch (Exception ex)
        {
            transaction.Rollback();

            return -1;
        }
    }

    /// <summary>
    ///     create return in the database
    /// </summary>
    /// <param name="rental"></param>
    /// <returns></returns>
    public static int CreateReturn(RentalItem rental, MySqlConnection transactionConnection)
    {
        var param = new DynamicParameters();
        param.Add("memberId", rental.MemberId);
        param.Add("employeeNum", rental.EmployeeNum);
        param.Add("returnDate", rental.StartDate);
        param.Add("returnId", dbType: DbType.Int32, direction: ParameterDirection.Output);

        transactionConnection.Query<int>("CreateReturn", param, commandType: CommandType.StoredProcedure);
        var newId = param.Get<int>("returnId");

        return newId;
    }

    /// <summary>
    ///     create return item in the database
    /// </summary>
    /// <param name="rentalItem"></param>
    /// <returns></returns>
    public static bool CreateReturnItem(RentalItem rentalItem, MySqlConnection transactionConnection)
    {
        var param = new DynamicParameters();
        param.Add("rentalId", rentalItem.RentalId);
        param.Add("returnId", rentalItem.ReturnId);
        param.Add("furnitureId", rentalItem.FurnitureId);
        param.Add("returnedQuantity", rentalItem.Quantity);

        var outcome =
            transactionConnection.Query<int>("CreateReturnItem", param, commandType: CommandType.StoredProcedure);

        return outcome != null;
    }

    /// <summary>
    ///     get return items
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
    ///     get return total
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

    #endregion
}