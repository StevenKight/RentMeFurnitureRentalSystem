using Dapper;
using MySql.Data.MySqlClient;
using RentMeFurnitureRentalSystem.Model;

namespace RentMeFurnitureRentalSystem.DAL;

public class CustomerDal
{
    #region Methods

    public static List<Customer> GetAllCustomers()
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);

        var results = connection.Query<Customer>(QueryStrings.GetCustomers);

        return results.ToList();
    }

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

    public static bool DeleteCustomer(Customer customer)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var affected = connection.Execute(QueryStrings.DeleteCustomer, customer);

        return affected > 0;
    }

    public static bool UpdateCustomer(Customer customer)
    {
        using var connection = new MySqlConnection(Connection.ConnectionString);
        connection.Open();

        var affected = connection.Execute(QueryStrings.UpdateCustomer, customer);

        return affected > 0;
    }

    #endregion
}