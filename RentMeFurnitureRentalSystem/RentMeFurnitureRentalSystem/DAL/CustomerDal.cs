using Dapper;
using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.Model;

namespace RentMeFurnitureRentalSystem.DAL;

/// <summary>
///     The DAL for the Customer class
/// </summary>
public class CustomerDal
{
    #region Methods

    /// <summary>
    ///     Gets all customers from the database
    /// </summary>
    /// <returns>list of customers</returns>
    public static List<Customer> GetAllCustomers()
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var results = connection.Query<Customer>(QueryStrings.GetCustomers);

        return results.ToList();
    }

    /// <summary>
    ///     Gets a customer by their id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public static IList<Customer> GetCustomerByMemberId(int id)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var results = connection.Query<Customer>(QueryStrings.GetCustomerByMemberId, new { id });

        return results.ToList();
    }

    /// <summary>
    ///     Get a customer by their phone number
    /// </summary>
    /// <param name="phone"></param>
    /// <returns></returns>
    public static IList<Customer> GetCustomerByPhone(string phone)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var results = connection.Query<Customer>(QueryStrings.GetCustomerByPhone, new { phone });

        return results.ToList();
    }

    /// <summary>
    ///     Get a customer by their name
    /// </summary>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    /// <returns></returns>
    public static IList<Customer> GetCustomerByName(string firstName, string lastName)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var results =
            connection.Query<Customer>(QueryStrings.GetCustomerByName, new { fname = firstName, lname = lastName });

        return results.ToList();
    }

    /// <summary>
    ///     Create a new customer in the database
    /// </summary>
    /// <param name="newCustomer"></param>
    /// <returns></returns>
    public static bool CreateCustomer(Customer newCustomer)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        connection.Open();

        try
        {
            connection.Execute(QueryStrings.CreateCustomer, newCustomer);
            return true;
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message);
            return false;
        }
    }

    /// <summary>
    ///     delete a customer from the database
    /// </summary>
    /// <param name="customer"></param>
    /// <returns></returns>
    public static bool DeleteCustomer(Customer customer)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var affected = connection.Execute(QueryStrings.DeleteCustomer, customer);

        return affected > 0;
    }

    /// <summary>
    ///     Update a customer in the database
    /// </summary>
    /// <param name="customer"></param>
    /// <returns></returns>
    public static bool UpdateCustomer(Customer customer)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var affected = connection.Execute(QueryStrings.UpdateCustomer, customer);

        return affected > 0;
    }

    #endregion
}